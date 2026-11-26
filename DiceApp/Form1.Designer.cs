namespace DiceApp
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
            lblDiceNum1 = new Label();
            lblDiceNum2 = new Label();
            lblDouble = new Label();
            btnRoll = new Button();
            SuspendLayout();
            // 
            // lblDiceNum1
            // 
            lblDiceNum1.AutoSize = true;
            lblDiceNum1.BorderStyle = BorderStyle.Fixed3D;
            lblDiceNum1.Location = new Point(217, 122);
            lblDiceNum1.Name = "lblDiceNum1";
            lblDiceNum1.Size = new Size(24, 27);
            lblDiceNum1.TabIndex = 0;
            lblDiceNum1.Text = "0";
            // 
            // lblDiceNum2
            // 
            lblDiceNum2.AutoSize = true;
            lblDiceNum2.BorderStyle = BorderStyle.Fixed3D;
            lblDiceNum2.Location = new Point(543, 122);
            lblDiceNum2.Name = "lblDiceNum2";
            lblDiceNum2.Size = new Size(24, 27);
            lblDiceNum2.TabIndex = 1;
            lblDiceNum2.Text = "0";
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Location = new Point(370, 342);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(0, 25);
            lblDouble.TabIndex = 2;
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(351, 224);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(112, 34);
            btnRoll.TabIndex = 3;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRoll);
            Controls.Add(lblDouble);
            Controls.Add(lblDiceNum2);
            Controls.Add(lblDiceNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiceNum1;
        private Label lblDiceNum2;
        private Label lblDouble;
        private Button btnRoll;
    }
}
