namespace UCC
{
    partial class CodingChallenge
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
            Question = new Label();
            Answer = new TextBox();
            Submit = new Button();
            Next = new Button();
            Back = new Button();
            dashBoardButton = new Button();
            SuspendLayout();
            // 
            // Question
            // 
            Question.AutoSize = true;
            Question.BackColor = Color.Transparent;
            Question.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Question.Location = new Point(575, 196);
            Question.Margin = new Padding(2, 0, 2, 0);
            Question.Name = "Question";
            Question.Size = new Size(164, 62);
            Question.TabIndex = 0;
            Question.Text = "label1";
            // 
            // Answer
            // 
            Answer.BackColor = Color.FloralWhite;
            Answer.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Answer.Location = new Point(409, 288);
            Answer.Margin = new Padding(2);
            Answer.Multiline = true;
            Answer.Name = "Answer";
            Answer.Size = new Size(478, 46);
            Answer.TabIndex = 1;
            // 
            // Submit
            // 
            Submit.BackColor = Color.Cornsilk;
            Submit.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Submit.Location = new Point(409, 366);
            Submit.Margin = new Padding(2);
            Submit.Name = "Submit";
            Submit.Size = new Size(478, 85);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // Next
            // 
            Next.BackColor = Color.Cornsilk;
            Next.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Next.Location = new Point(927, 485);
            Next.Margin = new Padding(2);
            Next.Name = "Next";
            Next.Size = new Size(285, 104);
            Next.TabIndex = 4;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = false;
            Next.Click += Next_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.Cornsilk;
            Back.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Back.Location = new Point(71, 485);
            Back.Margin = new Padding(2);
            Back.Name = "Back";
            Back.Size = new Size(295, 114);
            Back.TabIndex = 5;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // dashBoardButton
            // 
            dashBoardButton.BackColor = Color.Cornsilk;
            dashBoardButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dashBoardButton.Location = new Point(71, 59);
            dashBoardButton.Margin = new Padding(2);
            dashBoardButton.Name = "dashBoardButton";
            dashBoardButton.Size = new Size(295, 114);
            dashBoardButton.TabIndex = 6;
            dashBoardButton.Text = "Dashboard";
            dashBoardButton.UseVisualStyleBackColor = false;
            dashBoardButton.Click += dashBoardButton_Click;
            // 
            // CodingChallenge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 677);
            Controls.Add(dashBoardButton);
            Controls.Add(Back);
            Controls.Add(Next);
            Controls.Add(Submit);
            Controls.Add(Answer);
            Controls.Add(Question);
            Margin = new Padding(2);
            Name = "CodingChallenge";
            Text = "UCC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Question;
        private TextBox Answer;
        private Button Submit;
        private Button Next;
        private Button Back;
        private Button dashBoardButton;
    }
}