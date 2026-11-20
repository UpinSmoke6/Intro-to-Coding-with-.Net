using System.Drawing;
using System.Windows.Forms;

namespace FlashCards
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
            lblAnswer = new Label();
            lblEquals = new Label();
            lblSecondaryNumber = new Label();
            lblSign = new Label();
            lblPrimaryNumber = new Label();
            btnReset = new Button();
            btnCheck = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.BorderStyle = BorderStyle.Fixed3D;
            lblAnswer.Location = new Point(595, 171);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(24, 27);
            lblAnswer.TabIndex = 0;
            lblAnswer.Text = "0";
            // 
            // lblEquals
            // 
            lblEquals.AutoSize = true;
            lblEquals.Location = new Point(477, 171);
            lblEquals.Name = "lblEquals";
            lblEquals.Size = new Size(24, 25);
            lblEquals.TabIndex = 1;
            lblEquals.Text = "=";
            // 
            // lblSecondaryNumber
            // 
            lblSecondaryNumber.AutoSize = true;
            lblSecondaryNumber.BorderStyle = BorderStyle.Fixed3D;
            lblSecondaryNumber.Location = new Point(371, 171);
            lblSecondaryNumber.Name = "lblSecondaryNumber";
            lblSecondaryNumber.Size = new Size(24, 27);
            lblSecondaryNumber.TabIndex = 2;
            lblSecondaryNumber.Text = "0";
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.Location = new Point(265, 171);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(24, 25);
            lblSign.TabIndex = 3;
            lblSign.Text = "+";
            // 
            // lblPrimaryNumber
            // 
            lblPrimaryNumber.AutoSize = true;
            lblPrimaryNumber.BorderStyle = BorderStyle.Fixed3D;
            lblPrimaryNumber.Location = new Point(169, 171);
            lblPrimaryNumber.Name = "lblPrimaryNumber";
            lblPrimaryNumber.Size = new Size(24, 27);
            lblPrimaryNumber.TabIndex = 4;
            lblPrimaryNumber.Text = "0";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(118, 357);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(176, 34);
            btnReset.TabIndex = 5;
            btnReset.Text = "New Challenge";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(468, 357);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(212, 34);
            btnCheck.TabIndex = 6;
            btnCheck.Text = "Check Guess";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 407);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            textBox1.Text = "Enter your answer";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(btnCheck);
            Controls.Add(btnReset);
            Controls.Add(lblPrimaryNumber);
            Controls.Add(lblSign);
            Controls.Add(lblSecondaryNumber);
            Controls.Add(lblEquals);
            Controls.Add(lblAnswer);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnswer;
        private Label lblEquals;
        private Label lblSecondaryNumber;
        private Label lblSign;
        private Label lblPrimaryNumber;
        private Button btnReset;
        private Button btnCheck;
        private TextBox textBox1;
    }
}