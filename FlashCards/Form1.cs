namespace FlashCards
{
    public partial class Form1 : Form
    {
        Random rand = new Random(); // Random number generator
        int answer; // Variable to store the correct answer

        public Form1()
        {
            InitializeComponent();

            btnReset.Click -= btnReset_Click;
            btnReset.Click += btnReset_Click;

            btnCheck.Click -= btnCheck_Click;
            btnCheck.Click += btnCheck_Click;

            btnReset_Click(this, EventArgs.Empty);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            int primaryNumber = rand.Next(1, 11); // Generate a random number between 1 and 10
            lblPrimaryNumber.Text = primaryNumber.ToString();

            int secondaryNumber = rand.Next(1, 11); // Generate a second random number between 1 and 10
            lblSecondaryNumber.Text = secondaryNumber.ToString();

            if (rand.Next(0, 2) == 0) // Randomly choose between addition and subtraction
            {
                lblSign.Text = "+";
                answer = primaryNumber + secondaryNumber;
            }
            else
            {
                lblSign.Text = "-";
                answer = primaryNumber - secondaryNumber;
            }

            lblAnswer.Text = "?";
            textBox1.Clear();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(textBox1.Text); // Convert the user's input to an integer
           
            if (guess == answer) // Check if the user's guess is correct
            {
                MessageBox.Show("Correct!");
                lblAnswer.Text = answer.ToString(); // Display the correct answer
            }
            else if (guess < answer) // Check if the user's guess is too low
            {
                MessageBox.Show(
                   "Incorrect. Your guess was too low.");
            }
            else if (guess > answer) // Check if the user's guess is too high
            {
                MessageBox.Show(
                    "Incorrect. Your guess was too high.");
            }
            else
            {
                MessageBox.Show(
                    "Incorrect. Please enter a valid number.");
            }
        }

        // Your designer references this method.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}