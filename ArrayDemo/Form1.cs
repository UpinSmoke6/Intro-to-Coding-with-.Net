namespace ArrayDemo
{
    public partial class Form1 : Form
    {
        int[] intNumberArray = new int[5] { 0, 1, 2, 3, 4 }; //declared an array and populated it with values.
        int intCounter = 0; // used to count the number of times the button is clicked.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblNumber.Text = Convert.ToString(intNumberArray[intCounter]); // displays the value in the array intCounter.
            intCounter++; //adds 1 to the intCounter variable.
            if (intCounter > 4)
            {
                intCounter = 0; // resets the counter to 0.
                intNumberArray[4] += 10; // adds 10 to the last value in the array.
                intNumberArray[3] += 1; // adds 1 to the second last value in the array.
                intNumberArray[2] += 2; // adds 2 to the third last value in the array.
                intNumberArray[1] += 5; // adds 5 to the fourth last value in the array.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
