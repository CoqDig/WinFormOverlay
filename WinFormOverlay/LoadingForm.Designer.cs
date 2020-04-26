﻿namespace WinFormOverlay
{
    partial class LoadingForm
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
            this.LoadingContainer = new System.Windows.Forms.Panel();
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.LoadingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadingContainer
            // 
            this.LoadingContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingContainer.Controls.Add(this.LoadingBar);
            this.LoadingContainer.Location = new System.Drawing.Point(12, 12);
            this.LoadingContainer.Name = "LoadingContainer";
            this.LoadingContainer.Size = new System.Drawing.Size(200, 100);
            this.LoadingContainer.TabIndex = 0;
            this.LoadingContainer.UseWaitCursor = true;
            // 
            // LoadingBar
            // 
            this.LoadingBar.Location = new System.Drawing.Point(33, 40);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(134, 23);
            this.LoadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.LoadingBar.TabIndex = 0;
            this.LoadingBar.UseWaitCursor = true;
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 125);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingForm";
            this.UseWaitCursor = true;
            this.LoadingContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadingContainer;
        private System.Windows.Forms.ProgressBar LoadingBar;
    }
}