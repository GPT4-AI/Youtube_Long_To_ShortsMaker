namespace ShortsMaker
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtYoutubeUrl;
        private System.Windows.Forms.Button btnDownloadVideo;
        private System.Windows.Forms.TextBox txtVideoPath;
        private System.Windows.Forms.Button btnBrowseVideo;
        private System.Windows.Forms.TextBox txtOutroPath;
        private System.Windows.Forms.Button btnBrowseOutro;
        private System.Windows.Forms.TextBox txtClipsAmount;
        private System.Windows.Forms.Button btnGenerateClips;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

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
            this.txtYoutubeUrl = new System.Windows.Forms.TextBox();
            this.btnDownloadVideo = new System.Windows.Forms.Button();
            this.txtVideoPath = new System.Windows.Forms.TextBox();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.txtOutroPath = new System.Windows.Forms.TextBox();
            this.btnBrowseOutro = new System.Windows.Forms.Button();
            this.txtClipsAmount = new System.Windows.Forms.TextBox();
            this.btnGenerateClips = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtYoutubeUrl
            this.txtYoutubeUrl.Location = new System.Drawing.Point(12, 30);
            this.txtYoutubeUrl.Name = "txtYoutubeUrl";
            this.txtYoutubeUrl.Size = new System.Drawing.Size(300, 20);
            this.txtYoutubeUrl.TabIndex = 0;

            // btnDownloadVideo
            this.btnDownloadVideo.Location = new System.Drawing.Point(318, 28);
            this.btnDownloadVideo.Name = "btnDownloadVideo";
            this.btnDownloadVideo.Size = new System.Drawing.Size(120, 23);
            this.btnDownloadVideo.TabIndex = 1;
            this.btnDownloadVideo.Text = "Download Video";
            this.btnDownloadVideo.UseVisualStyleBackColor = true;
            this.btnDownloadVideo.Click += new System.EventHandler(this.btnDownloadVideo_Click);

            // txtVideoPath
            this.txtVideoPath.Location = new System.Drawing.Point(12, 80);
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.Size = new System.Drawing.Size(300, 20);
            this.txtVideoPath.TabIndex = 2;

            // btnBrowseVideo
            this.btnBrowseVideo.Location = new System.Drawing.Point(318, 78);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(120, 23);
            this.btnBrowseVideo.TabIndex = 3;
            this.btnBrowseVideo.Text = "Browse Video";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);

            // txtOutroPath
            this.txtOutroPath.Location = new System.Drawing.Point(12, 130);
            this.txtOutroPath.Name = "txtOutroPath";
            this.txtOutroPath.Size = new System.Drawing.Size(300, 20);
            this.txtOutroPath.TabIndex = 4;

            // btnBrowseOutro
            this.btnBrowseOutro.Location = new System.Drawing.Point(318, 128);
            this.btnBrowseOutro.Name = "btnBrowseOutro";
            this.btnBrowseOutro.Size = new System.Drawing.Size(120, 23);
            this.btnBrowseOutro.TabIndex = 5;
            this.btnBrowseOutro.Text = "Browse Outro";
            this.btnBrowseOutro.UseVisualStyleBackColor = true;
            this.btnBrowseOutro.Click += new System.EventHandler(this.btnBrowseOutro_Click);

            // txtClipsAmount
            this.txtClipsAmount.Location = new System.Drawing.Point(12, 180);
            this.txtClipsAmount.Name = "txtClipsAmount";
            this.txtClipsAmount.Size = new System.Drawing.Size(100, 20);
            this.txtClipsAmount.TabIndex = 6;

            // btnGenerateClips
            this.btnGenerateClips.Location = new System.Drawing.Point(318, 178);
            this.btnGenerateClips.Name = "btnGenerateClips";
            this.btnGenerateClips.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateClips.TabIndex = 7;
            this.btnGenerateClips.Text = "Generate Clips";
            this.btnGenerateClips.UseVisualStyleBackColor = true;
            this.btnGenerateClips.Click += new System.EventHandler(this.btnGenerateClips_Click);

            // richTextBox1
            this.richTextBox1.Location = new System.Drawing.Point(12, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 150);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "YouTube URL";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Video Path";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Outro Path";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number of Clips";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnGenerateClips);
            this.Controls.Add(this.txtClipsAmount);
            this.Controls.Add(this.btnBrowseOutro);
            this.Controls.Add(this.txtOutroPath);
            this.Controls.Add(this.btnBrowseVideo);
            this.Controls.Add(this.txtVideoPath);
            this.Controls.Add(this.btnDownloadVideo);
            this.Controls.Add(this.txtYoutubeUrl);
            this.Name = "MainForm";
            this.Text = "Shorts Maker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
