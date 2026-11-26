namespace Random_Quest_Generator
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
            btnGenerate = new Button();
            lblQuest = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(299, 150);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 34);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate!";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblQuest
            // 
            lblQuest.AutoSize = true;
            lblQuest.Location = new Point(12, 195);
            lblQuest.Name = "lblQuest";
            lblQuest.Size = new Size(0, 25);
            lblQuest.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblQuest);
            Controls.Add(btnGenerate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Label lblQuest;
    }
}
