namespace SimpleCalculator
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
            btnAdd = new Button();
            btnMinus = new Button();
            btnMult = new Button();
            btnDivide = new Button();
            btnEqual = new Button();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblOperator = new Label();
            lblAnswer = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdd.Location = new Point(323, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinus.Location = new Point(323, 146);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(112, 34);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMult.Location = new Point(323, 204);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(112, 34);
            btnMult.TabIndex = 2;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDivide.Location = new Point(323, 262);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(112, 34);
            btnDivide.TabIndex = 3;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click_1;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnEqual.Location = new Point(323, 320);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(112, 34);
            btnEqual.TabIndex = 4;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(97, 210);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 31);
            txtNum2.TabIndex = 5;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(97, 94);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 31);
            txtNum1.TabIndex = 6;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperator.Location = new Point(97, 142);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(37, 38);
            lblOperator.TabIndex = 7;
            lblOperator.Text = "+";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.BorderStyle = BorderStyle.Fixed3D;
            lblAnswer.Location = new Point(97, 327);
            lblAnswer.MinimumSize = new Size(100, 0);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(100, 27);
            lblAnswer.TabIndex = 8;
            lblAnswer.Click += lblAnswer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 549);
            Controls.Add(lblAnswer);
            Controls.Add(lblOperator);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(btnEqual);
            Controls.Add(btnDivide);
            Controls.Add(btnMult);
            Controls.Add(btnMinus);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnMinus;
        private Button btnMult;
        private Button btnDivide;
        private Button btnEqual;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lblOperator;
        private Label lblAnswer;
    }
}
