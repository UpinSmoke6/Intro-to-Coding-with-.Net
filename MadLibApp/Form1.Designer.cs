namespace MadLibApp
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
            lblTitle = new Label();
            lblInput = new Label();
            lblStory = new Label();
            txtBoxInput = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(266, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "The Unexpected Adventure";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(12, 147);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(150, 25);
            lblInput.TabIndex = 1;
            lblInput.Text = "Enter an adjective";
            // 
            // lblStory
            // 
            lblStory.AutoSize = true;
            lblStory.Location = new Point(118, 190);
            lblStory.MaximumSize = new Size(500, 500);
            lblStory.Name = "lblStory";
            lblStory.Size = new Size(0, 25);
            lblStory.TabIndex = 2;
            // 
            // txtBoxInput
            // 
            txtBoxInput.Location = new Point(295, 141);
            txtBoxInput.Name = "txtBoxInput";
            txtBoxInput.Size = new Size(150, 31);
            txtBoxInput.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(505, 138);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtBoxInput);
            Controls.Add(lblStory);
            Controls.Add(lblInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "MadLib App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInput;
        private Label lblStory;
        private TextBox txtBoxInput;
        private Button btnAdd;
    }
}
