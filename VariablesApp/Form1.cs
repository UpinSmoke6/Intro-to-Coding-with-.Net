namespace VariablesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        { //Create Variables

            char chrVar;
            int intVar;
            float fltVar;
            double dblVar;
            decimal decVar;
            bool blnVar;
            string strVar;

            try
            {

                chrVar = Convert.ToChar(txtInput.Text); // gets text from textbox.
                lblCharacter1.Text = Convert.ToString(chrVar); // displays variable in label.

            }
            catch
            {
                lblCharacter1.Text = "Error"; // displays error in label.
            }
            try
            {
                intVar = Convert.ToInt32(txtInput.Text); // gets text from textbox.
                lblInteger1.Text = Convert.ToString(intVar); // displays variable in label.
            }
            catch
            {
                lblInteger1.Text = "Error"; // displays error in label. 
            }
            try
            {
                fltVar = Convert.ToSingle(txtInput.Text); // gets text from textbox.
                lblFloat1.Text = Convert.ToString(fltVar); // displays variable in label.
            }
            catch
            {
                lblFloat1.Text = "Error"; // displays error in label. 

            }
            try
            {
                dblVar = Convert.ToDouble(txtInput.Text); // gets text from textbox.
                lblDouble1.Text = Convert.ToString(dblVar); // displays variable in label.
            }
            catch
            {
                lblDouble1.Text = "Error"; // displays error in label.
            }
            try
            {
                decVar = Convert.ToDecimal(txtInput.Text); // gets text from textbox.
                lblDecimal1.Text = Convert.ToString(decVar); // displays variable in label.

            }
            catch
            {
                lblDecimal1.Text = "Error"; // displays error in label.
            }
            try
            {
                blnVar = Convert.ToBoolean(txtInput.Text); // gets text from textbox.
                lblBoolean1.Text = Convert.ToString(blnVar); // displays variable in label.
            }
            catch
            {
                lblBoolean1.Text = "Error"; // displays error in label.
            }
            try
            {
                strVar = txtInput.Text; // gets text from textbox.
                lblString1.Text = strVar; // displays variable in label.

            }
            catch
            {
                lblString1.Text = "Error"; // displays error in label.
            }
        }
    }
}
