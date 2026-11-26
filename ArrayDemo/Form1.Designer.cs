namespace ArrayDemo
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
            btnNext = new Button();
            btnExit = new Button();
            lblNumber = new Label();
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Location = new Point(253, 224);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 34);
            btnNext.TabIndex = 0;
            btnNext.Text = "Read Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(498, 224);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BorderStyle = BorderStyle.Fixed3D;
            lblNumber.Location = new Point(315, 91);
            lblNumber.MinimumSize = new Size(50, 0);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(50, 27);
            lblNumber.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNumber);
            Controls.Add(btnExit);
            Controls.Add(btnNext);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNext;
        private Button btnExit;
        private Label lblNumber;
    }
}
