using System.Diagnostics.Eventing.Reader;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string strOperator = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            strOperator = "+";
            lblOperator.Text = strOperator;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            strOperator = "-";
            lblOperator.Text = strOperator;

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            strOperator = "*";
            lblOperator.Text = strOperator;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            strOperator = "/";
            lblOperator.Text = strOperator;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Decimal decNum1;
            Decimal decNum2;
            Decimal decAnswer;

            decNum1 = Convert.ToDecimal(txtNum1.Text);
            decNum2 = Convert.ToDecimal(txtNum2.Text);
            if (strOperator == "+") // checks to see if operator is addition.
            {
                decAnswer = decNum1 + decNum2;
            }
            else if (strOperator == "-") // checks to see if operator is subtraction
            {
                decAnswer = decNum1 - decNum2;
            }

            else if (strOperator == "*") // checks to see if operator is multiply
            {
                decAnswer = decNum1 * decNum2;
            }
            else // if not the following it is division.
            {
                decAnswer = decNum1 / decNum2;
            }
            lblAnswer.Text = decAnswer.ToString();


            // % modulus operator is a remainder operator. It's division but its the remainder of the division.
            //6%4 = 2. For example, 6 divided by 4 is 1 with a remainder of 2. So the answer is 2.
            // Most commonly used for even or odd numbers.
            // ++ incrementation. Loops. or decNum1++ adds 1 to decNum1.
            // -- decrementation. Loops. or decNum1-- subtracts 1 from decNum1.

            //! = not. 5 != 3 is true.
            // > greater than operator 5 > 3 true.
            // < less than operator 5 < 3 is false.
            // <= less than or equal to 5 <= 3 is false.
            // >= greater or equal to 5 >= 3 is true.

        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            strOperator = "/";
            lblOperator.Text = strOperator;
        }
    }
}
