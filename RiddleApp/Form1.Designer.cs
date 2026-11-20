namespace RiddleApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnRiddle1 = new Button();
            btnAnswer1 = new Button();

            btnRiddle2 = new Button();
            btnAnswer2 = new Button();

            btnRiddle3 = new Button();
            btnAnswer3 = new Button();

            btnRiddle4 = new Button();
            btnAnswer4 = new Button();

            lblAnswer = new Label();
            lblQuestion = new Label();
            lblMyName = new Label();
            lblOutQuestion = new Label();
            lblOutAnswer = new Label();

            SuspendLayout();

            // btnRiddle1
            btnRiddle1.Location = new Point(87, 303);
            btnRiddle1.Name = "btnRiddle1";
            btnRiddle1.Size = new Size(112, 34);
            btnRiddle1.TabIndex = 0;
            btnRiddle1.Text = "Riddle 1";
            btnRiddle1.UseVisualStyleBackColor = true;
            btnRiddle1.Click += btnRiddle1_Click;

            // btnAnswer1
            btnAnswer1.Location = new Point(87, 369);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(112, 34);
            btnAnswer1.TabIndex = 1;
            btnAnswer1.Text = "Answer 1";
            btnAnswer1.UseVisualStyleBackColor = true;
            btnAnswer1.Click += btnAnswer1_Click;

            // btnRiddle2
            btnRiddle2.Location = new Point(251, 303);
            btnRiddle2.Name = "btnRiddle2";
            btnRiddle2.Size = new Size(112, 34);
            btnRiddle2.TabIndex = 2;
            btnRiddle2.Text = "Riddle 2";
            btnRiddle2.UseVisualStyleBackColor = true;
            btnRiddle2.Click += btnRiddle2_Click;

            // btnAnswer2
            btnAnswer2.Location = new Point(251, 369);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(112, 34);
            btnAnswer2.TabIndex = 3;
            btnAnswer2.Text = "Answer 2";
            btnAnswer2.UseVisualStyleBackColor = true;
            btnAnswer2.Click += btnAnswer2_Click;

            // btnRiddle3
            btnRiddle3.Location = new Point(423, 303);
            btnRiddle3.Name = "btnRiddle3";
            btnRiddle3.Size = new Size(112, 34);
            btnRiddle3.TabIndex = 4;
            btnRiddle3.Text = "Riddle 3";
            btnRiddle3.UseVisualStyleBackColor = true;
            btnRiddle3.Click += btnRiddle3_Click;

            // btnAnswer3
            btnAnswer3.Location = new Point(423, 369);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(112, 34);
            btnAnswer3.TabIndex = 5;
            btnAnswer3.Text = "Answer 3";
            btnAnswer3.UseVisualStyleBackColor = true;
            btnAnswer3.Click += btnAnswer3_Click;

            // btnRiddle4
            btnRiddle4.Location = new Point(588, 303);
            btnRiddle4.Name = "btnRiddle4";
            btnRiddle4.Size = new Size(112, 34);
            btnRiddle4.TabIndex = 6;
            btnRiddle4.Text = "Riddle 4";
            btnRiddle4.UseVisualStyleBackColor = true;
            btnRiddle4.Click += btnRiddle4_Click;

            // btnAnswer4
            btnAnswer4.Location = new Point(588, 369);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(112, 34);
            btnAnswer4.TabIndex = 7;
            btnAnswer4.Text = "Answer 4";
            btnAnswer4.UseVisualStyleBackColor = true;
            btnAnswer4.Click += btnAnswer4_Click;

            // lblAnswer
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(111, 164);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(74, 25);
            lblAnswer.TabIndex = 8;
            lblAnswer.Text = "Answer:";

            // lblQuestion
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(111, 81);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(88, 25);
            lblQuestion.TabIndex = 9;
            lblQuestion.Text = "Question:";

            // lblMyName
            lblMyName.AutoSize = true;
            lblMyName.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0
            );

            lblMyName.Location = new Point(251, 9);
            lblMyName.Name = "lblMyName";
            lblMyName.Size = new Size(249, 45);
            lblMyName.TabIndex = 10;
            lblMyName.Text = "Derek's Riddles";

            // lblOutQuestion
            lblOutQuestion.AutoSize = true;
            lblOutQuestion.Location = new Point(270, 81);
            lblOutQuestion.Name = "lblOutQuestion";
            lblOutQuestion.Size = new Size(0, 25);
            lblOutQuestion.TabIndex = 11;

            // lblOutAnswer
            lblOutAnswer.AutoSize = true;
            lblOutAnswer.Location = new Point(270, 164);
            lblOutAnswer.Name = "lblOutAnswer";
            lblOutAnswer.Size = new Size(0, 25);
            lblOutAnswer.TabIndex = 12;

            // Form1
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(lblOutAnswer);
            Controls.Add(lblOutQuestion);
            Controls.Add(lblMyName);
            Controls.Add(lblQuestion);
            Controls.Add(lblAnswer);

            Controls.Add(btnAnswer4);
            Controls.Add(btnRiddle4);
            Controls.Add(btnAnswer3);
            Controls.Add(btnRiddle3);
            Controls.Add(btnAnswer2);
            Controls.Add(btnRiddle2);
            Controls.Add(btnAnswer1);
            Controls.Add(btnRiddle1);

            Name = "Form1";
            Text = "Derek's Riddles";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRiddle1;
        private Button btnAnswer1;

        private Button btnRiddle2;
        private Button btnAnswer2;

        private Button btnRiddle3;
        private Button btnAnswer3;

        private Button btnRiddle4;
        private Button btnAnswer4;

        private Label lblAnswer;
        private Label lblQuestion;
        private Label lblMyName;
        private Label lblOutQuestion;
        private Label lblOutAnswer;
    }
}