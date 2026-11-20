namespace GuessGame
{
    public partial class Form1 : Form
    {
        int randomNumber = new Random().Next(1, 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            int guess = Convert.ToInt32(textBox1.Text);

            if (guess == randomNumber)
            {
                MessageBox.Show("Congratulations! You guessed the correct number.");
            }
            else if (guess > randomNumber)
            {
                MessageBox.Show("Your Guess is greater than the number!");
            }
            else
            {
                MessageBox.Show("Your Guess is less than the number!");
            }
            textBox1.Clear();
            textBox1.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            randomNumber = new Random().Next(1, 10);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
