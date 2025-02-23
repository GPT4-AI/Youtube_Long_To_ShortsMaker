using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Controls;

namespace ShortsMaker
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500,
                Accent.LightBlue200, TextShade.WHITE);
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
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Video file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int amountOfClips;
            if (!int.TryParse(txtClipsAmount.Text, out amountOfClips) || amountOfClips <= 0)
            {
                MessageBox.Show("Enter a valid number of clips!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string outputDirectory = Path.GetDirectoryName(filePath);
            string outputExtension = Path.GetExtension(filePath);
            int interval = 50; // Clip length in seconds

            var rand = new Random();
            var startTimes = Enumerable.Range(0, (int)Math.Ceiling(GetVideoDuration(filePath) / interval))
                                       .OrderBy(x => rand.Next())
                                       .Select(x => x * interval)
                                       .Take(amountOfClips)
                                       .ToList();

            foreach (var startTime in startTimes)
            {
                string outputFile = Path.Combine(outputDirectory, $"{startTime / 60}_clip{outputExtension}");
                SplitVideo(filePath, outputFile, startTime, interval);
            }

            MessageBox.Show("Clips generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Log("Clips generated successfully.");
        }

        private double GetVideoDuration(string filePath)
        {
            string ffprobePath = "ffprobe";

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
                Log("FFprobe error: " + error);
                return 0;
            }

            return double.TryParse(output, NumberStyles.Float, CultureInfo.InvariantCulture, out double duration) ? duration : 0;
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
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action(() => richTextBox1.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}")));
            }
            else
            {
                richTextBox1.AppendText($"{DateTime.Now}: {message}{Environment.NewLine}");
            }

            richTextBox1.ScrollToCaret();
        }
    }
}
