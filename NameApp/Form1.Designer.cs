namespace NameApp
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
            lblQuestion1 = new Label();
            lblQuestion2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            clickButton = new Button();
            lblOutput = new Label();
            lblDisplay = new Label();
            lblAnswer = new Label();
            SuspendLayout();
            // 
            // lblQuestion1
            // 
            lblQuestion1.AutoSize = true;
            lblQuestion1.Location = new Point(226, 138);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new Size(169, 25);
            lblQuestion1.TabIndex = 0;
            lblQuestion1.Text = "What is your name?";
            // 
            // lblQuestion2
            // 
            lblQuestion2.AutoSize = true;
            lblQuestion2.Location = new Point(226, 240);
            lblQuestion2.Name = "lblQuestion2";
            lblQuestion2.Size = new Size(157, 25);
            lblQuestion2.TabIndex = 1;
            lblQuestion2.Text = "What is your Age?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(458, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(458, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // clickButton
            // 
            clickButton.Location = new Point(325, 348);
            clickButton.Name = "clickButton";
            clickButton.Size = new Size(112, 34);
            clickButton.TabIndex = 4;
            clickButton.Text = "Generate";
            clickButton.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(342, 406);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 25);
            lblOutput.TabIndex = 5;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Location = new Point(325, 406);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(0, 25);
            lblDisplay.TabIndex = 6;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(248, 406);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(71, 25);
            lblAnswer.TabIndex = 7;
            lblAnswer.Text = "Results:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAnswer);
            Controls.Add(lblDisplay);
            Controls.Add(lblOutput);
            Controls.Add(clickButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblQuestion2);
            Controls.Add(lblQuestion1);
            Name = "Form1";
            Text = "User Inputs Program";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion1;
        private Label lblQuestion2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button clickButton;
        private Label lblOutput;
        private Label lblDisplay;
        private Label lblAnswer;
    }
}