namespace ShortsMaker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.txtClipsAmount = new System.Windows.Forms.TextBox();
            this.btnGenerateClips = new System.Windows.Forms.Button();
            this.txtOutroPath = new System.Windows.Forms.TextBox();
            this.btnBrowseOutro = new System.Windows.Forms.Button();
            this.btnDownloadVideo = new System.Windows.Forms.Button();
            this.txtYoutubeUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Location = new System.Drawing.Point(12, 12);
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(400, 20);
            this.txtVideoPath.TabIndex = 0;
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Location = new System.Drawing.Point(418, 10);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseVideo.TabIndex = 1;
            this.btnBrowseVideo.Text = "Browse";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);
            // 
            // txtClipsAmount
            // 
            this.txtClipsAmount.Location = new System.Drawing.Point(12, 38);
            this.txtClipsAmount.Name = "txtClipsAmount";
            this.txtClipsAmount.Size = new System.Drawing.Size(100, 20);
            this.txtClipsAmount.TabIndex = 2;
            this.txtClipsAmount.Text = "5"; // Default value
            // 
            // btnGenerateClips
            // 
            this.btnGenerateClips.Location = new System.Drawing.Point(12, 64);
            this.btnGenerateClips.Name = "btnGenerateClips";
            this.btnGenerateClips.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateClips.TabIndex = 3;
            this.btnGenerateClips.Text = "Generate Clips";
            this.btnGenerateClips.UseVisualStyleBackColor = true;
            this.btnGenerateClips.Click += new System.EventHandler(this.btnGenerateClips_Click);
            // 
            // txtOutroPath
            // 
            this.txtOutroPath.Location = new System.Drawing.Point(12, 93);
            this.txtOutroPath.Name = "txtOutroPath";
            this.txtOutroPath.Size = new System.Drawing.Size(400, 20);
            this.txtOutroPath.TabIndex = 4;
            // 
            // btnBrowseOutro
            // 
            this.btnBrowseOutro.Location = new System.Drawing.Point(418, 91);
            this.btnBrowseOutro.Name = "btnBrowseOutro";
            this.btnBrowseOutro.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutro.TabIndex = 5;
            this.btnBrowseOutro.Text = "Browse";
            this.btnBrowseOutro.UseVisualStyleBackColor = true;
            this.btnBrowseOutro.Click += new System.EventHandler(this.btnBrowseOutro_Click);
            // 
            // btnDownloadVideo
            // 
            this.btnDownloadVideo.Location = new System.Drawing.Point(12, 119);
            this.btnDownloadVideo.Name = "btnDownloadVideo";
            this.btnDownloadVideo.Size = new System.Drawing.Size(100, 23);
            this.btnDownloadVideo.TabIndex = 6;
            this.btnDownloadVideo.Text = "Download Video";
            this.btnDownloadVideo.UseVisualStyleBackColor = true;
            this.btnDownloadVideo.Click += new System.EventHandler(this.btnDownloadVideo_Click);
            // 
            // txtYoutubeUrl
            // 
            this.txtYoutubeUrl.Location = new System.Drawing.Point(12, 148);
            this.txtYoutubeUrl.Name = "txtYoutubeUrl";
            this.txtYoutubeUrl.Size = new System.Drawing.Size(400, 20);
            this.txtYoutubeUrl.TabIndex = 7;
            this.txtYoutubeUrl.PlaceholderText = "Enter YouTube URL";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(505, 180);
            this.Controls.Add(this.txtYoutubeUrl);
            this.Controls.Add(this.btnDownloadVideo);
            this.Controls.Add(this.btnBrowseOutro);
            this.Controls.Add(this.txtOutroPath);
            this.Controls.Add(this.btnGenerateClips);
            this.Controls.Add(this.txtClipsAmount);
            this.Controls.Add(this.btnBrowseVideo);
            this.Controls.Add(this.txtVideoPath);
            this.Name = "MainForm";
            this.Text = "Shorts Maker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.Button btnBrowseVideo;
        private System.Windows.Forms.TextBox txtClipsAmount;
        private System.Windows.Forms.Button btnGenerateClips;
        private System.Windows.Forms.TextBox txtOutroPath;
        private System.Windows.Forms.Button btnBrowseOutro;
        private System.Windows.Forms.Button btnDownloadVideo;
        private System.Windows.Forms.TextBox txtYoutubeUrl;
    }
}
