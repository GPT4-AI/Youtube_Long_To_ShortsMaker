using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShortsMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowseVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.mkv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtVideoPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseOutro_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.mkv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutroPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnDownloadVideo_Click(object sender, EventArgs e)
        {
            string youtubeUrl = txtYoutubeUrl.Text;
            string outputDirectory = Path.GetTempPath(); // Download to temp directory
            string outputFilePath = Path.Combine(outputDirectory, "downloaded_video.mp4");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "yt-dlp",
                    Arguments = $"-f \"best[height<=1080]\" -o \"{outputFilePath}\" \"{youtubeUrl}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                }
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                MessageBox.Show("Video downloaded successfully!");
                txtVideoPath.Text = outputFilePath; // Set the video path to the downloaded file
            }
            else
            {
                MessageBox.Show($"Error downloading video: {error}");
            }
        }

        private void btnGenerateClips_Click(object sender, EventArgs e)
        {
            string filePath = txtVideoPath.Text;
            int amountOfClips = int.Parse(txtClipsAmount.Text);
            string outroPath = txtOutroPath.Text;

            string outputDirectory = Path.GetDirectoryName(filePath);
            string outputExtension = Path.GetExtension(filePath);
            int interval = 50;

            var rand = new Random();
            var startTimes = Enumerable.Range(0, (int)Math.Ceiling(GetVideoDuration(filePath) / interval))
                                       .OrderBy(x => rand.Next())
                                       .Select(x => x * interval)
                                       .ToList();
            startTimes.Add(int.MaxValue);

            for (int i = 0; i < startTimes.Count - 1; i++)
            {
                if (i < amountOfClips)
                {
                    string outputFile = Path.Combine(outputDirectory, $"{startTimes[i] / 60}_{i}{outputExtension}");
                    SplitVideo(filePath, outputFile, startTimes[i], interval, outroPath);
                }
            }

            MessageBox.Show("Clips generated successfully!");
        }

        private double GetVideoDuration(string filePath)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ffprobe",
                    Arguments = $"-v error -show_entries format=duration -of default=noprint_wrappers=1:nokey=1 \"{filePath}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return double.Parse(output);
        }

        private void SplitVideo(string filePath, string outputFile, int startTime, int duration, string outroPath = "")
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = $"-i \"{filePath}\" -ss {startTime} -t {duration} -async 1 -c copy \"{outputFile}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            process.WaitForExit();

            if (!string.IsNullOrEmpty(outroPath))
            {
                string concatList = $"file '{outputFile}'\nfile '{outroPath}'";
                string concatListPath = Path.Combine(Path.GetDirectoryName(outputFile), "concat-list.txt");
                File.WriteAllText(concatListPath, concatList);

                string concatenatedOutputPath = Path.Combine(Path.GetDirectoryName(outputFile), Path.GetFileNameWithoutExtension(outputFile) + "-with-outro.mp4");

                var concatProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "ffmpeg",
                        Arguments = $"-f concat -safe 0 -i \"{concatListPath}\" -async 1 -c copy \"{concatenatedOutputPath}\"",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    }
                };

                concatProcess.Start();
                concatProcess.WaitForExit();
            }
        }
    }
}
