namespace UCC
{
    partial class Admin
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
            label1 = new Label();
            insert = new Button();
            delete = new Button();
            squeeze = new Button();
            search = new Button();
            profilePicture = new PictureBox();
            input = new TextBox();
            Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 55F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 65);
            label1.Name = "label1";
            label1.Size = new Size(839, 123);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // insert
            // 
            insert.BackColor = Color.Cornsilk;
            insert.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold | FontStyle.Italic);
            insert.ForeColor = SystemColors.ActiveCaptionText;
            insert.Location = new Point(99, 302);
            insert.Name = "insert";
            insert.Size = new Size(541, 172);
            insert.TabIndex = 1;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Cornsilk;
            delete.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold | FontStyle.Italic);
            delete.ForeColor = SystemColors.ActiveCaptionText;
            delete.Location = new Point(640, 302);
            delete.Name = "delete";
            delete.Size = new Size(541, 172);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // squeeze
            // 
            squeeze.BackColor = Color.Cornsilk;
            squeeze.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold | FontStyle.Italic);
            squeeze.ForeColor = SystemColors.ActiveCaptionText;
            squeeze.Location = new Point(640, 474);
            squeeze.Name = "squeeze";
            squeeze.Size = new Size(541, 172);
            squeeze.TabIndex = 4;
            squeeze.Text = "Squeeze";
            squeeze.UseVisualStyleBackColor = false;
            squeeze.Click += squeeze_Click;
            // 
            // search
            // 
            search.BackColor = Color.Cornsilk;
            search.Font = new Font("Segoe UI Semibold", 40F, FontStyle.Bold | FontStyle.Italic);
            search.ForeColor = SystemColors.ActiveCaptionText;
            search.Location = new Point(99, 474);
            search.Name = "search";
            search.Size = new Size(541, 172);
            search.TabIndex = 3;
            search.Text = "Search";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // profilePicture
            // 
            profilePicture.BorderStyle = BorderStyle.Fixed3D;
            profilePicture.Location = new Point(16, 16);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(206, 196);
            profilePicture.TabIndex = 5;
            profilePicture.TabStop = false;
            // 
            // input
            // 
            input.Font = new Font("Segoe UI", 30F);
            input.Location = new Point(99, 222);
            input.Name = "input";
            input.Size = new Size(777, 74);
            input.TabIndex = 6;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Cornsilk;
            Clear.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Clear.Location = new Point(880, 222);
            Clear.Name = "Clear";
            Clear.Size = new Size(301, 74);
            Clear.TabIndex = 7;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Image.FromFile("../../../Resources/Images/mainBG.png");
            ClientSize = new Size(1266, 677);
            Controls.Add(profilePicture);
            Controls.Add(Clear);
            Controls.Add(input);
            Controls.Add(squeeze);
            Controls.Add(search);
            Controls.Add(delete);
            Controls.Add(insert);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button insert;
        private Button delete;
        private Button squeeze;
        private Button search;
        private PictureBox profilePicture;
        private TextBox input;
        private Button Clear;
    }
}