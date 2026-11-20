namespace LottoPicker
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
            label1 = new Label();
            lblBall5 = new Label();
            lblBall4 = new Label();
            lblBall3 = new Label();
            lblBall2 = new Label();
            lblBall1 = new Label();
            label8 = new Label();
            lblBallRed = new Label();
            btnPickNumbers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 117);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "White Balls";
            // 
            // lblBall5
            // 
            lblBall5.AutoSize = true;
            lblBall5.BorderStyle = BorderStyle.Fixed3D;
            lblBall5.Location = new Point(284, 163);
            lblBall5.Name = "lblBall5";
            lblBall5.Size = new Size(24, 27);
            lblBall5.TabIndex = 2;
            lblBall5.Text = "0";
            // 
            // lblBall4
            // 
            lblBall4.AutoSize = true;
            lblBall4.BorderStyle = BorderStyle.Fixed3D;
            lblBall4.Location = new Point(219, 163);
            lblBall4.Name = "lblBall4";
            lblBall4.Size = new Size(24, 27);
            lblBall4.TabIndex = 3;
            lblBall4.Text = "0";
            // 
            // lblBall3
            // 
            lblBall3.AutoSize = true;
            lblBall3.BorderStyle = BorderStyle.Fixed3D;
            lblBall3.Location = new Point(154, 163);
            lblBall3.Name = "lblBall3";
            lblBall3.Size = new Size(24, 27);
            lblBall3.TabIndex = 4;
            lblBall3.Text = "0";
            // 
            // lblBall2
            // 
            lblBall2.AutoSize = true;
            lblBall2.BorderStyle = BorderStyle.Fixed3D;
            lblBall2.Location = new Point(89, 163);
            lblBall2.Name = "lblBall2";
            lblBall2.Size = new Size(24, 27);
            lblBall2.TabIndex = 5;
            lblBall2.Text = "0";
            // 
            // lblBall1
            // 
            lblBall1.AutoSize = true;
            lblBall1.BorderStyle = BorderStyle.Fixed3D;
            lblBall1.Location = new Point(24, 163);
            lblBall1.Name = "lblBall1";
            lblBall1.Size = new Size(24, 27);
            lblBall1.TabIndex = 6;
            lblBall1.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 263);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 7;
            label8.Text = "Red Ball";
            // 
            // lblBallRed
            // 
            lblBallRed.AutoSize = true;
            lblBallRed.BorderStyle = BorderStyle.Fixed3D;
            lblBallRed.Location = new Point(24, 318);
            lblBallRed.Name = "lblBallRed";
            lblBallRed.Size = new Size(24, 27);
            lblBallRed.TabIndex = 8;
            lblBallRed.Text = "0";
            // 
            // btnPickNumbers
            // 
            btnPickNumbers.Location = new Point(24, 359);
            btnPickNumbers.Name = "btnPickNumbers";
            btnPickNumbers.Size = new Size(186, 34);
            btnPickNumbers.TabIndex = 9;
            btnPickNumbers.Text = "Pick Numbers";
            btnPickNumbers.UseVisualStyleBackColor = true;
            btnPickNumbers.Click += btnPickNumbers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 444);
            Controls.Add(btnPickNumbers);
            Controls.Add(lblBallRed);
            Controls.Add(label8);
            Controls.Add(lblBall1);
            Controls.Add(lblBall2);
            Controls.Add(lblBall3);
            Controls.Add(lblBall4);
            Controls.Add(lblBall5);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lotto Picker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label8;
        private Label lblBall1;
        private Label lblBall2;
        private Label lblBall3;
        private Label lblBall4;
        private Label lblBall5;
        private Label lblBallRed;
        private Button btnPickNumbers;
    }
}
