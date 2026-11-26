namespace DiceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int dice1;
            int dice2;
            Random random = new Random();

            dice1 = random.Next(1, 7);
            dice2 = random.Next(1, 7);

            lblDiceNum1.Text = dice1.ToString();
            lblDiceNum2.Text = dice2.ToString();

            if (dice1 == dice2)
            {
                lblDouble.Text = "You rolled a double!";
                lblDouble.ForeColor = Color.Red;
            }
            else
            {
                lblDouble.Text = "";
            }

        }
    }
}
