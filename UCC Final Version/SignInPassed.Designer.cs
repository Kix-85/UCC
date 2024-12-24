namespace UCC
{
    partial class SignInPassed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInPassed));
            panel1 = new Panel();
            //youmWaraYoum = new AxWMPLib.AxWindowsMediaPlayer();
            panel1.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)youmWaraYoum).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 36, 46, 50);
            //panel1.Controls.Add(youmWaraYoum);
            panel1.Location = new Point(28, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 616);
            panel1.TabIndex = 0;
            // 
            // youmWaraYoum
            // 
            //youmWaraYoum.Enabled = true;
            //youmWaraYoum.Location = new Point(19, 19);
            //youmWaraYoum.Name = "youmWaraYoum";
            //youmWaraYoum.OcxState = (AxHost.State)resources.GetObject("youmWaraYoum.OcxState");
            //youmWaraYoum.Size = new Size(1170, 580);
            //youmWaraYoum.TabIndex = 1;
            // 
            // SignInPassed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 677);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignInPassed";
            Text = "SignInPassed";
            Load += SignInPassed_Load;
            panel1.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)youmWaraYoum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        //private AxWMPLib.AxWindowsMediaPlayer youmWaraYoum;
    }
}