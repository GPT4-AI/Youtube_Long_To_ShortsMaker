using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ShortsMaker
{
    partial class MainForm
    {
        private MaterialTextBox txtVideoPath;
        private MaterialTextBox txtOutroPath;
        private MaterialTextBox txtYoutubeUrl;
        private MaterialButton btnBrowseVideo;
        private MaterialButton btnDownloadVideo;
        private MaterialButton btnGenerateClips;
        private MaterialTextBox txtClipsAmount;
        private RichTextBox richTextBox1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtVideoPath = new MaterialTextBox();
            txtOutroPath = new MaterialTextBox();
            txtYoutubeUrl = new MaterialTextBox();
            txtClipsAmount = new MaterialTextBox();
            btnBrowseVideo = new MaterialButton();
            btnDownloadVideo = new MaterialButton();
            btnGenerateClips = new MaterialButton();
            richTextBox1 = new RichTextBox();
            btnBrowseOutro = new MaterialButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtVideoPath
            // 
            txtVideoPath.AnimateReadOnly = false;
            txtVideoPath.BorderStyle = BorderStyle.None;
            txtVideoPath.Depth = 0;
            txtVideoPath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtVideoPath.Hint = "Video Path";
            txtVideoPath.LeadingIcon = null;
            txtVideoPath.Location = new System.Drawing.Point(30, 80);
            txtVideoPath.MaxLength = 50;
            txtVideoPath.MouseState = MaterialSkin.MouseState.OUT;
            txtVideoPath.Multiline = false;
            txtVideoPath.Name = "txtVideoPath";
            txtVideoPath.Size = new System.Drawing.Size(400, 50);
            txtVideoPath.TabIndex = 0;
            txtVideoPath.Text = "";
            txtVideoPath.TrailingIcon = null;
            // 
            // txtOutroPath
            // 
            txtOutroPath.AnimateReadOnly = false;
            txtOutroPath.BorderStyle = BorderStyle.None;
            txtOutroPath.Depth = 0;
            txtOutroPath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtOutroPath.Hint = "Outro Path";
            txtOutroPath.LeadingIcon = null;
            txtOutroPath.Location = new System.Drawing.Point(30, 130);
            txtOutroPath.MaxLength = 50;
            txtOutroPath.MouseState = MaterialSkin.MouseState.OUT;
            txtOutroPath.Multiline = false;
            txtOutroPath.Name = "txtOutroPath";
            txtOutroPath.Size = new System.Drawing.Size(400, 50);
            txtOutroPath.TabIndex = 1;
            txtOutroPath.Text = "";
            txtOutroPath.TrailingIcon = null;
            // 
            // txtYoutubeUrl
            // 
            txtYoutubeUrl.AnimateReadOnly = false;
            txtYoutubeUrl.BorderStyle = BorderStyle.None;
            txtYoutubeUrl.Depth = 0;
            txtYoutubeUrl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txtYoutubeUrl.Hint = "YouTube URL";
            txtYoutubeUrl.LeadingIcon = null;
            txtYoutubeUrl.Location = new System.Drawing.Point(30, 180);
            txtYoutubeUrl.MaxLength = 50;
            txtYoutubeUrl.MouseState = MaterialSkin.MouseState.OUT;
            txtYoutubeUrl.Multiline = false;
            txtYoutubeUrl.Name = "txtYoutubeUrl";
            txtYoutubeUrl.Size = new System.Drawing.Size(400, 50);
            txtYoutubeUrl.TabIndex = 2;
            txtYoutubeUrl.Text = "";
            txtYoutubeUrl.TrailingIcon = null;
            // 
            // txtClipsAmount
            // 
            txtClipsAmount.AnimateReadOnly = false;
            txtClipsAmount.BorderStyle = BorderStyle.None;
            txtClipsAmount.Depth = 0;
            txtClipsAmount.Font = new System.Drawing.Font("Roboto", 9.6F);
            txtClipsAmount.Hint = "Number of Clips";
            txtClipsAmount.LeadingIcon = null;
            txtClipsAmount.Location = new System.Drawing.Point(30, 230);
            txtClipsAmount.MaxLength = 50;
            txtClipsAmount.MouseState = MaterialSkin.MouseState.OUT;
            txtClipsAmount.Multiline = false;
            txtClipsAmount.Name = "txtClipsAmount";
            txtClipsAmount.Size = new System.Drawing.Size(169, 50);
            txtClipsAmount.TabIndex = 3;
            txtClipsAmount.Text = "5";
            txtClipsAmount.TrailingIcon = null;
            // 
            // btnBrowseVideo
            // 
            btnBrowseVideo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrowseVideo.Density = MaterialButton.MaterialButtonDensity.Default;
            btnBrowseVideo.Depth = 0;
            btnBrowseVideo.HighEmphasis = true;
            btnBrowseVideo.Icon = null;
            btnBrowseVideo.Location = new System.Drawing.Point(450, 80);
            btnBrowseVideo.Margin = new Padding(4, 6, 4, 6);
            btnBrowseVideo.MouseState = MaterialSkin.MouseState.HOVER;
            btnBrowseVideo.Name = "btnBrowseVideo";
            btnBrowseVideo.NoAccentTextColor = System.Drawing.Color.Empty;
            btnBrowseVideo.Size = new System.Drawing.Size(126, 36);
            btnBrowseVideo.TabIndex = 4;
            btnBrowseVideo.Text = "Browse Video";
            btnBrowseVideo.Type = MaterialButton.MaterialButtonType.Contained;
            btnBrowseVideo.UseAccentColor = false;
            btnBrowseVideo.Click += btnBrowseVideo_Click;
            // 
            // btnDownloadVideo
            // 
            btnDownloadVideo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDownloadVideo.Density = MaterialButton.MaterialButtonDensity.Default;
            btnDownloadVideo.Depth = 0;
            btnDownloadVideo.HighEmphasis = true;
            btnDownloadVideo.Icon = null;
            btnDownloadVideo.Location = new System.Drawing.Point(450, 180);
            btnDownloadVideo.Margin = new Padding(4, 6, 4, 6);
            btnDownloadVideo.MouseState = MaterialSkin.MouseState.HOVER;
            btnDownloadVideo.Name = "btnDownloadVideo";
            btnDownloadVideo.NoAccentTextColor = System.Drawing.Color.Empty;
            btnDownloadVideo.Size = new System.Drawing.Size(148, 36);
            btnDownloadVideo.TabIndex = 6;
            btnDownloadVideo.Text = "Download Video";
            btnDownloadVideo.Type = MaterialButton.MaterialButtonType.Contained;
            btnDownloadVideo.UseAccentColor = false;
            btnDownloadVideo.Click += btnDownloadVideo_Click;
            // 
            // btnGenerateClips
            // 
            btnGenerateClips.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerateClips.Density = MaterialButton.MaterialButtonDensity.Default;
            btnGenerateClips.Depth = 0;
            btnGenerateClips.HighEmphasis = true;
            btnGenerateClips.Icon = null;
            btnGenerateClips.Location = new System.Drawing.Point(450, 230);
            btnGenerateClips.Margin = new Padding(4, 6, 4, 6);
            btnGenerateClips.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerateClips.Name = "btnGenerateClips";
            btnGenerateClips.NoAccentTextColor = System.Drawing.Color.Empty;
            btnGenerateClips.Size = new System.Drawing.Size(139, 36);
            btnGenerateClips.TabIndex = 7;
            btnGenerateClips.Text = "Generate Clips";
            btnGenerateClips.Type = MaterialButton.MaterialButtonType.Contained;
            btnGenerateClips.UseAccentColor = false;
            btnGenerateClips.Click += btnGenerateClips_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(30, 280);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(600, 189);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // btnBrowseOutro
            // 
            btnBrowseOutro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBrowseOutro.Density = MaterialButton.MaterialButtonDensity.Default;
            btnBrowseOutro.Depth = 0;
            btnBrowseOutro.Font = new System.Drawing.Font("Tahoma", 9F);
            btnBrowseOutro.HighEmphasis = true;
            btnBrowseOutro.Icon = null;
            btnBrowseOutro.Location = new System.Drawing.Point(450, 128);
            btnBrowseOutro.Margin = new Padding(4, 6, 4, 6);
            btnBrowseOutro.MouseState = MaterialSkin.MouseState.HOVER;
            btnBrowseOutro.Name = "btnBrowseOutro";
            btnBrowseOutro.NoAccentTextColor = System.Drawing.Color.Empty;
            btnBrowseOutro.Size = new System.Drawing.Size(132, 36);
            btnBrowseOutro.TabIndex = 5;
            btnBrowseOutro.Text = "Browse Outro";
            btnBrowseOutro.Type = MaterialButton.MaterialButtonType.Contained;
            btnBrowseOutro.UseAccentColor = false;
            btnBrowseOutro.Click += btnBrowseOutro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dfdffsf11;
            pictureBox1.Location = new System.Drawing.Point(652, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(251, 389);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(933, 500);
            Controls.Add(pictureBox1);
            Controls.Add(txtVideoPath);
            Controls.Add(txtOutroPath);
            Controls.Add(txtYoutubeUrl);
            Controls.Add(txtClipsAmount);
            Controls.Add(btnBrowseVideo);
            Controls.Add(btnBrowseOutro);
            Controls.Add(btnDownloadVideo);
            Controls.Add(btnGenerateClips);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(933, 500);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(933, 500);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shorts Maker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialButton btnBrowseOutro;
        private PictureBox pictureBox1;
    }
}
