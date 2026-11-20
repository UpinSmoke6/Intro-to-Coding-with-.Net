namespace GuessGame
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
            btnGuess = new Button();
            btnReset = new Button();
            lblLabel1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(142, 250);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(112, 34);
            btnGuess.TabIndex = 0;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(563, 250);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 34);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblLabel1
            // 
            lblLabel1.AutoSize = true;
            lblLabel1.Location = new Point(281, 82);
            lblLabel1.Name = "lblLabel1";
            lblLabel1.Size = new Size(230, 25);
            lblLabel1.TabIndex = 2;
            lblLabel1.Text = "Pick a number from 1 to 10";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblLabel1);
            Controls.Add(btnReset);
            Controls.Add(btnGuess);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuess;
        private Button btnReset;
        private Label lblLabel1;
        private TextBox textBox1;
    }
}
