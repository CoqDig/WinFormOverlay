namespace WinFormOverlay
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoadingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadingContainer
            // 
            this.LoadingContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadingContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoadingContainer.Controls.Add(this.TitleLabel);
            this.LoadingContainer.Controls.Add(this.LoadingBar);
            this.LoadingContainer.Location = new System.Drawing.Point(10, 10);
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
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(30, 14);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(85, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Chargement";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(220, 120);
            this.ControlBox = false;
            this.Controls.Add(this.LoadingContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.UseWaitCursor = true;
            this.LoadingContainer.ResumeLayout(false);
            this.LoadingContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoadingContainer;
        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Label TitleLabel;
    }
}