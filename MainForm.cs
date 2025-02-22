using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

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
            string youtubeUrl = txtYoutubeUrl.Text.Trim();
            if (string.IsNullOrEmpty(youtubeUrl))
            {
                MessageBox.Show("Please enter a valid YouTube URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log("Download attempt failed: No URL provided.");
                return;
            }

            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputDirectory = folderDialog.SelectedPath;
                    string outputFilePath = Path.Combine(outputDirectory, "downloaded_video.mp4");

                    try
                    {
                        var process = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "yt-dlp",
                                Arguments = $"-f \"bestvideo[height<=1080]+bestaudio/best\" -o \"{outputFilePath}\" \"{youtubeUrl}\"",
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
                            MessageBox.Show("Video downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtVideoPath.Text = outputFilePath;
                            Log("Video downloaded successfully: " + outputFilePath);
                        }
                        else
                        {
                            MessageBox.Show($"Error downloading video:\n{error}", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Log($"Download error: {error}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Log("Download exception: " + ex.Message);
                    }
                }
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
                    SplitVideo(filePath, outputFile, startTimes[i], interval); // Remove outroPath
                }
            }

            MessageBox.Show("Clips generated successfully!");
            Log("Clips generated successfully.");
        }

        private double GetVideoDuration(string filePath)
        {
            string ffprobePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffprobe.exe");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffprobePath,
                    Arguments = $"-v error -show_entries format=duration -of default=noprint_wrappers=1:nokey=1 \"{filePath}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd().Trim();
            string error = process.StandardError.ReadToEnd();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                MessageBox.Show($"Error in ffprobe:\n{error}", "FFprobe Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("FFprobe error: " + error);
                return 0; // Handle the error appropriately
            }

            if (double.TryParse(output, NumberStyles.Float, CultureInfo.InvariantCulture, out double duration))
            {
                Log($"Video duration parsed: {duration} seconds.");
                return duration;
            }
            else
            {
                MessageBox.Show($"Unable to parse duration: '{output}'", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log($"Unable to parse duration: '{output}'");
                return 0; // Handle the error appropriately
            }
        }

        private void SplitVideo(string filePath, string outputFile, int startTime, int duration)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = $"-i \"{filePath}\" -ss {startTime} -t {duration} " +
                                $"-vf \"crop=ih*(9/16):ih,scale=1080:1920\" " +
                                $"-c:v libx264 -c:a aac \"{outputFile}\"",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            process.WaitForExit();

            Log($"Video split completed: {outputFile}");
        }
        
        
        private void Log(string message)
        {
            richTextBox1.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
            richTextBox1.ScrollToCaret();
        }
    }
}
