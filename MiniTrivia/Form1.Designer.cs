namespace MiniTrivia
{
    partial class Form1
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
            lblQuestion = new Label();
            txtAnswer = new TextBox();
            btnSubmit = new Button();
            lblScore = new Label();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(41, 72);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(84, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(41, 130);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(150, 31);
            txtAnswer.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(216, 130);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit!";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(41, 192);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(60, 25);
            lblScore.TabIndex = 3;
            lblScore.Text = "Score:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 577);
            Controls.Add(lblScore);
            Controls.Add(btnSubmit);
            Controls.Add(txtAnswer);
            Controls.Add(lblQuestion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtAnswer;
        private Button btnSubmit;
        private Label lblScore;
    }
}
