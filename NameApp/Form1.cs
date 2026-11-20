namespace NameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clickButton.Click += clickButton1_Click; // Event handler for the button click
        }

        private void clickButton1_Click(object sender, EventArgs e)
        {//Creating Variables
            string strName;
            int intAge;
            //Displaying the variables in a message box


            try
            {
                strName = textBox1.Text; // Converting the input to a string
                intAge = Convert.ToInt32(textBox2.Text); // Converting the input to an integer

                lblDisplay.Text = "Your name is " + strName +
                    " and your age is " + intAge;  // Displaying the name and age in a label
            }
            catch
            {
                MessageBox.Show("Please enter a valid age."); // Displaying an error message if the input is not a valid integer
            }
        }
    }
}
