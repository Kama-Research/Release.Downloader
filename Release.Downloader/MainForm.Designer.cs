﻿namespace Release.Downloader
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleValue = new System.Windows.Forms.Label();
            this.btnStartAnalogy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Downloaded Component:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitleValue
            // 
            this.lblTitleValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitleValue.Location = new System.Drawing.Point(231, 24);
            this.lblTitleValue.Name = "lblTitleValue";
            this.lblTitleValue.Size = new System.Drawing.Size(557, 32);
            this.lblTitleValue.TabIndex = 2;
            this.lblTitleValue.Text = "N/A";
            this.lblTitleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStartAnalogy
            // 
            this.btnStartAnalogy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartAnalogy.Location = new System.Drawing.Point(522, 76);
            this.btnStartAnalogy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartAnalogy.Name = "btnStartAnalogy";
            this.btnStartAnalogy.Size = new System.Drawing.Size(130, 50);
            this.btnStartAnalogy.TabIndex = 3;
            this.btnStartAnalogy.Text = "Start Again";
            this.btnStartAnalogy.UseVisualStyleBackColor = true;
            this.btnStartAnalogy.Click += new System.EventHandler(this.btnStartAnalogy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(658, 76);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 140);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStartAnalogy);
            this.Controls.Add(this.lblTitleValue);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Kama Updater";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitleValue;
        private System.Windows.Forms.Button btnStartAnalogy;
        private System.Windows.Forms.Button btnExit;
    }
}

