using System.Reflection;
using System.Windows.Forms;

namespace UCC
{
    partial class DashBoard
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
            profilePicture = new PictureBox();
            nameLabel = new Label();
            button1 = new Button();
            points = new Label();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            mainStory = new PictureBox();
            codingChallenge = new PictureBox();
            mathsChallenge = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainStory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)codingChallenge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mathsChallenge).BeginInit();
            SuspendLayout();
            // 
            // profilePicture
            // 
            profilePicture.BackgroundImageLayout = ImageLayout.Stretch;
            profilePicture.Location = new Point(23, 20);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(169, 165);
            profilePicture.TabIndex = 0;
            profilePicture.TabStop = false;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(199, 48);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(262, 38);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Mohey El Sharkawy";
            // 
            // button1
            // 
            button1.Location = new Point(377, 228);
            button1.Name = "button1";
            button1.Size = new Size(254, 71);
            button1.TabIndex = 2;
            button1.Text = "Coming Soon!!";
            button1.UseVisualStyleBackColor = true;
            // 
            // points
            // 
            points.AutoSize = true;
            points.BackColor = Color.Transparent;
            points.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            points.Location = new Point(199, 104);
            points.Name = "points";
            points.Size = new Size(127, 38);
            points.TabIndex = 3;
            points.Text = "Points: 0";
            // 
            // button2
            // 
            button2.Location = new Point(657, 228);
            button2.Name = "button2";
            button2.Size = new Size(254, 71);
            button2.TabIndex = 4;
            button2.Text = "Coming Soon!!";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(936, 228);
            button4.Name = "button4";
            button4.Size = new Size(254, 71);
            button4.TabIndex = 5;
            button4.Text = "Coming Soon!!";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(96, 228);
            button5.Name = "button5";
            button5.Size = new Size(254, 71);
            button5.TabIndex = 6;
            button5.Text = "Coming Soon!!";
            button5.UseVisualStyleBackColor = true;
            // 
            // mainStory
            // 
            mainStory.BackColor = SystemColors.ActiveCaptionText;
            mainStory.BorderStyle = BorderStyle.Fixed3D;
            mainStory.Location = new Point(475, 325);
            mainStory.Name = "mainStory";
            mainStory.Size = new Size(338, 314);
            mainStory.TabIndex = 12;
            mainStory.TabStop = false;
            mainStory.Click += mainStory_Click;
            // 
            // codingChallenge
            // 
            codingChallenge.BackColor = SystemColors.ActiveCaptionText;
            codingChallenge.BorderStyle = BorderStyle.Fixed3D;
            codingChallenge.Location = new Point(96, 325);
            codingChallenge.Name = "codingChallenge";
            codingChallenge.Size = new Size(338, 314);
            codingChallenge.TabIndex = 13;
            codingChallenge.TabStop = false;
            codingChallenge.Click += codingChallenge_Click;
            // 
            // mathsChallenge
            // 
            mathsChallenge.BackColor = SystemColors.ActiveCaptionText;
            mathsChallenge.BorderStyle = BorderStyle.Fixed3D;
            mathsChallenge.Location = new Point(852, 325);
            mathsChallenge.Name = "mathsChallenge";
            mathsChallenge.Size = new Size(338, 314);
            mathsChallenge.TabIndex = 14;
            mathsChallenge.TabStop = false;
            mathsChallenge.Click += mathsChallenge_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Old English Text MT", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 160);
            label3.Name = "label3";
            label3.Size = new Size(679, 65);
            label3.TabIndex = 15;
            label3.Text = "There is no way back anymore";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 677);
            Controls.Add(label3);
            Controls.Add(mathsChallenge);
            Controls.Add(codingChallenge);
            Controls.Add(mainStory);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(points);
            Controls.Add(button1);
            Controls.Add(nameLabel);
            Controls.Add(profilePicture);
            Name = "DashBoard";
            Text = "UCC";
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainStory).EndInit();
            ((System.ComponentModel.ISupportInitialize)codingChallenge).EndInit();
            ((System.ComponentModel.ISupportInitialize)mathsChallenge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private PictureBox profilePicture;
        private Label nameLabel;
        private Button button1;
        private Label points;
        private Button button2;
        private Button button4;
        private Button button5;
        private PictureBox mainStory;
        private PictureBox codingChallenge;
        private PictureBox mathsChallenge;
        private Label label3;
    }
}