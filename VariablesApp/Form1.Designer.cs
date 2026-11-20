namespace VariablesApp
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
            lblInteger = new Label();
            lblCharacter = new Label();
            lblFloat = new Label();
            lblDouble = new Label();
            lblDecimal = new Label();
            lblBoolean = new Label();
            lblString = new Label();
            lblInteger1 = new Label();
            lblCharacter1 = new Label();
            lblFloat1 = new Label();
            lblDouble1 = new Label();
            lblDecimal1 = new Label();
            lblBoolean1 = new Label();
            lblString1 = new Label();
            label1 = new Label();
            txtInput = new TextBox();
            btnTest = new Button();
            SuspendLayout();
            // 
            // lblInteger
            // 
            lblInteger.AutoSize = true;
            lblInteger.Location = new Point(72, 54);
            lblInteger.Name = "lblInteger";
            lblInteger.Size = new Size(68, 25);
            lblInteger.TabIndex = 0;
            lblInteger.Text = "Integer";
            // 
            // lblCharacter
            // 
            lblCharacter.AutoSize = true;
            lblCharacter.Location = new Point(72, 87);
            lblCharacter.Name = "lblCharacter";
            lblCharacter.Size = new Size(86, 25);
            lblCharacter.TabIndex = 1;
            lblCharacter.Text = "Character";
            // 
            // lblFloat
            // 
            lblFloat.AutoSize = true;
            lblFloat.Location = new Point(72, 120);
            lblFloat.Name = "lblFloat";
            lblFloat.Size = new Size(51, 25);
            lblFloat.TabIndex = 2;
            lblFloat.Text = "Float";
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Location = new Point(72, 153);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(70, 25);
            lblDouble.TabIndex = 3;
            lblDouble.Text = "Double";
            // 
            // lblDecimal
            // 
            lblDecimal.AutoSize = true;
            lblDecimal.Location = new Point(72, 186);
            lblDecimal.Name = "lblDecimal";
            lblDecimal.Size = new Size(75, 25);
            lblDecimal.TabIndex = 4;
            lblDecimal.Text = "Decimal";
            // 
            // lblBoolean
            // 
            lblBoolean.AutoSize = true;
            lblBoolean.Location = new Point(72, 219);
            lblBoolean.Name = "lblBoolean";
            lblBoolean.Size = new Size(76, 25);
            lblBoolean.TabIndex = 5;
            lblBoolean.Text = "Boolean";
            // 
            // lblString
            // 
            lblString.AutoSize = true;
            lblString.Location = new Point(72, 252);
            lblString.Name = "lblString";
            lblString.Size = new Size(58, 25);
            lblString.TabIndex = 6;
            lblString.Text = "String";
            // 
            // lblInteger1
            // 
            lblInteger1.AutoSize = true;
            lblInteger1.Location = new Point(203, 54);
            lblInteger1.Name = "lblInteger1";
            lblInteger1.Size = new Size(22, 25);
            lblInteger1.TabIndex = 7;
            lblInteger1.Text = "0";
            // 
            // lblCharacter1
            // 
            lblCharacter1.AutoSize = true;
            lblCharacter1.Location = new Point(203, 87);
            lblCharacter1.Name = "lblCharacter1";
            lblCharacter1.Size = new Size(22, 25);
            lblCharacter1.TabIndex = 8;
            lblCharacter1.Text = "0";
            // 
            // lblFloat1
            // 
            lblFloat1.AutoSize = true;
            lblFloat1.Location = new Point(198, 120);
            lblFloat1.Name = "lblFloat1";
            lblFloat1.Size = new Size(22, 25);
            lblFloat1.TabIndex = 9;
            lblFloat1.Text = "0";
            // 
            // lblDouble1
            // 
            lblDouble1.AutoSize = true;
            lblDouble1.Location = new Point(198, 153);
            lblDouble1.Name = "lblDouble1";
            lblDouble1.Size = new Size(22, 25);
            lblDouble1.TabIndex = 10;
            lblDouble1.Text = "0";
            // 
            // lblDecimal1
            // 
            lblDecimal1.AutoSize = true;
            lblDecimal1.Location = new Point(198, 186);
            lblDecimal1.Name = "lblDecimal1";
            lblDecimal1.Size = new Size(22, 25);
            lblDecimal1.TabIndex = 11;
            lblDecimal1.Text = "0";
            // 
            // lblBoolean1
            // 
            lblBoolean1.AutoSize = true;
            lblBoolean1.Location = new Point(198, 219);
            lblBoolean1.Name = "lblBoolean1";
            lblBoolean1.Size = new Size(22, 25);
            lblBoolean1.TabIndex = 12;
            lblBoolean1.Text = "0";
            // 
            // lblString1
            // 
            lblString1.AutoSize = true;
            lblString1.Location = new Point(198, 252);
            lblString1.Name = "lblString1";
            lblString1.Size = new Size(22, 25);
            lblString1.TabIndex = 13;
            lblString1.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 319);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 14;
            label1.Text = "Enter a string to test:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(87, 362);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(150, 31);
            txtInput.TabIndex = 15;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(243, 359);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(112, 34);
            btnTest.TabIndex = 16;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 418);
            Controls.Add(btnTest);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(lblString1);
            Controls.Add(lblBoolean1);
            Controls.Add(lblDecimal1);
            Controls.Add(lblDouble1);
            Controls.Add(lblFloat1);
            Controls.Add(lblCharacter1);
            Controls.Add(lblInteger1);
            Controls.Add(lblString);
            Controls.Add(lblBoolean);
            Controls.Add(lblDecimal);
            Controls.Add(lblDouble);
            Controls.Add(lblFloat);
            Controls.Add(lblCharacter);
            Controls.Add(lblInteger);
            Name = "Form1";
            Text = "Variables App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInteger;
        private Label lblCharacter;
        private Label lblFloat;
        private Label lblDouble;
        private Label lblDecimal;
        private Label lblBoolean;
        private Label lblString;
        private Label lblInteger1;
        private Label lblCharacter1;
        private Label lblFloat1;
        private Label label1;
        private Label lblDouble1;
        private Label lblDecimal1;
        private Label lblBoolean1;
        private Label lblString1;
        private TextBox txtInput;
        private Button btnTest;
    }
}
