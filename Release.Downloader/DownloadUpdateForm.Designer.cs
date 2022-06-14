
namespace Release.Downloader
{
    partial class DownloadUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInformation = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelInformation.Location = new System.Drawing.Point(14, 9);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(239, 36);
            this.labelInformation.TabIndex = 3;
            this.labelInformation.Text = "Downloading Update...";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar.Location = new System.Drawing.Point(14, 50);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(975, 35);
            this.progressBar.TabIndex = 4;
            // 
            // labelSize
            // 
            this.labelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSize.Location = new System.Drawing.Point(835, 9);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(154, 36);
            this.labelSize.TabIndex = 5;
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DownloadUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 105);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DownloadUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DownloadUpdateForm";
            this.Load += new System.EventHandler(this.DownloadUpdateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelSize;
    }
}