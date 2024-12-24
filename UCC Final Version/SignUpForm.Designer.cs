namespace UCC
{
    partial class SignUpForm
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
            panel1 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            passwordBox = new TextBox();
            criminalIDBox = new TextBox();
            crimeBox = new ComboBox();
            criminalPhoto = new PictureBox();
            femaleBox = new RadioButton();
            maleBox = new RadioButton();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            nickNameBox = new TextBox();
            ageBox = new TextBox();
            yearsBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)criminalPhoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 36, 46, 50);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(criminalIDBox);
            panel1.Controls.Add(crimeBox);
            panel1.Controls.Add(criminalPhoto);
            panel1.Controls.Add(femaleBox);
            panel1.Controls.Add(maleBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nickNameBox);
            panel1.Controls.Add(ageBox);
            panel1.Controls.Add(yearsBox);
            panel1.Location = new Point(221, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 484);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(76, 406);
            button1.Name = "button1";
            button1.Size = new Size(703, 41);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += register_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 16F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(522, 66);
            label6.Name = "label6";
            label6.Size = new Size(128, 37);
            label6.TabIndex = 7;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 16F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(252, 66);
            label7.Name = "label7";
            label7.Size = new Size(149, 37);
            label7.TabIndex = 8;
            label7.Text = "Criminal ID";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 12F);
            passwordBox.Location = new Point(543, 114);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(236, 34);
            passwordBox.TabIndex = 5;
            // 
            // criminalIDBox
            // 
            criminalIDBox.Font = new Font("Segoe UI", 12F);
            criminalIDBox.Location = new Point(273, 114);
            criminalIDBox.Name = "criminalIDBox";
            criminalIDBox.Size = new Size(236, 34);
            criminalIDBox.TabIndex = 6;
            // 
            // crimeBox
            // 
            crimeBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crimeBox.FormattingEnabled = true;
            crimeBox.Items.AddRange(new object[] { "Murderer", "Thief", "Rapist", "Sarsagy", "Foul Plate" });
            crimeBox.Location = new Point(543, 208);
            crimeBox.Name = "crimeBox";
            crimeBox.Size = new Size(236, 36);
            crimeBox.TabIndex = 4;
            // 
            // criminalPhoto
            // 
            criminalPhoto.Location = new Point(76, 66);
            criminalPhoto.Name = "criminalPhoto";
            criminalPhoto.Size = new Size(158, 158);
            criminalPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            criminalPhoto.TabIndex = 3;
            criminalPhoto.TabStop = false;
            criminalPhoto.Click += criminalPhoto_Click;
            // 
            // femaleBox
            // 
            femaleBox.AutoSize = true;
            femaleBox.BackColor = Color.Transparent;
            femaleBox.Font = new Font("Segoe UI", 12F);
            femaleBox.ForeColor = Color.White;
            femaleBox.Location = new Point(89, 306);
            femaleBox.Name = "femaleBox";
            femaleBox.Size = new Size(95, 32);
            femaleBox.TabIndex = 2;
            femaleBox.TabStop = true;
            femaleBox.Text = "Female";
            femaleBox.UseVisualStyleBackColor = false;
            // 
            // maleBox
            // 
            maleBox.AutoSize = true;
            maleBox.BackColor = Color.Transparent;
            maleBox.Font = new Font("Segoe UI", 12F);
            maleBox.ForeColor = Color.White;
            maleBox.Location = new Point(89, 281);
            maleBox.Name = "maleBox";
            maleBox.Size = new Size(76, 32);
            maleBox.TabIndex = 2;
            maleBox.TabStop = true;
            maleBox.Text = "Male";
            maleBox.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(522, 162);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 1;
            label4.Text = "Crime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(252, 162);
            label2.Name = "label2";
            label2.Size = new Size(135, 37);
            label2.TabIndex = 1;
            label2.Text = "Nickname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(76, 238);
            label5.Name = "label5";
            label5.Size = new Size(104, 37);
            label5.TabIndex = 1;
            label5.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(522, 256);
            label3.Name = "label3";
            label3.Size = new Size(64, 37);
            label3.TabIndex = 1;
            label3.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(252, 256);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 1;
            label1.Text = "Years In Jail ";
            // 
            // nickNameBox
            // 
            nickNameBox.BackColor = Color.White;
            nickNameBox.Font = new Font("Segoe UI", 12F);
            nickNameBox.Location = new Point(274, 210);
            nickNameBox.Name = "nickNameBox";
            nickNameBox.Size = new Size(236, 34);
            nickNameBox.TabIndex = 0;
            // 
            // ageBox
            // 
            ageBox.Font = new Font("Segoe UI", 12F);
            ageBox.Location = new Point(543, 304);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(236, 34);
            ageBox.TabIndex = 0;
            // 
            // yearsBox
            // 
            yearsBox.Font = new Font("Segoe UI", 12F);
            yearsBox.Location = new Point(273, 304);
            yearsBox.Name = "yearsBox";
            yearsBox.Size = new Size(236, 34);
            yearsBox.TabIndex = 0;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1266, 677);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "SignUpForm";
            Text = "signUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)criminalPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox yearsBox;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox nickNameBox;
        private TextBox ageBox;
        private RadioButton femaleBox;
        private RadioButton maleBox;
        private Label label5;
        private PictureBox criminalPhoto;
        private ComboBox crimeBox;
        private Label label6;
        private Label label7;
        private TextBox passwordBox;
        private TextBox criminalIDBox;
        private Button button1;
    }
}