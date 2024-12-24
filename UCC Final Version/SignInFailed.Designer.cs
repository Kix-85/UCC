namespace UCC
{
    partial class SignInFailed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInFailed));
            panel1 = new Panel();
            //axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            panel1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            //panel1.Controls.Add(axWindowsMediaPlayer1);
            panel1.Location = new Point(64, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 626);
            panel1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            //axWindowsMediaPlayer1.Enabled = true;
            //axWindowsMediaPlayer1.Location = new Point(3, -9);
            //axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            //axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            //axWindowsMediaPlayer1.Size = new Size(1127, 623);
            //axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 677);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        //private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}