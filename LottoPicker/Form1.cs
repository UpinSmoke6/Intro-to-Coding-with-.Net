namespace LottoPicker
{
    public partial class Form1 : Form
    {
        int[] lottoArray = new int[5]; //creates an array that holds 5 numbers.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPickNumbers_Click(object sender, EventArgs e)
        {
            int intLoopCounter = 0; // Initialize loop counter
            //Generate random number generator
            Random rndNumber = new Random(); // Create a random number generator

          //while (intLoopCounter < 1000) // loop runs 1,000 iterations while statement is true.
            for(intLoopCounter = 0; intLoopCounter < 1000; intLoopCounter++) // know exactly time you need to know when to run
            {
                if (intLoopCounter < 150) // number of times to loop through the first ball
                {
                    lblBall1.Text = rndNumber.Next(1, 6).ToString();
                    if (intLoopCounter == 149) //last time we pick the 2nd ball.
                    {
                   
                            lottoArray[0] = Convert.ToInt32(lblBall1.Text); //puts the number int the array for the first ball.
                        }
                    }

                } // Pick a random number between 1 and 69 for the first white ball
                if (intLoopCounter < 300) {
                lblBall2.Text = rndNumber.Next(1, 6).ToString();
                    if (intLoopCounter == 299) //last time we pick the 2nd ball.
                    {
                        if (TestDouble(Convert.ToInt32(lblBall2.Text)) == -1)
                        {
                            intLoopCounter--; // subtract 1 from the loop counter to repeat the loop.
                        }
                        else
                        {
                            lottoArray[1] = Convert.ToInt32(lblBall2.Text); //puts the number int the array for the second ball.
                        }
                    }
                } // Pick a random number between 1 and 69 for the second white ball
                if (intLoopCounter < 450)
                {
                    lblBall3.Text = rndNumber.Next(1, 6).ToString();
                    if (intLoopCounter == 449) //last time we pick the 2nd ball.
                    {
                        if (TestDouble(Convert.ToInt32(lblBall3.Text)) == -1)
                        {
                            intLoopCounter--; // subtract 1 from the loop counter to repeat the loop.
                        }
                        else
                        {
                            lottoArray[2] = Convert.ToInt32(lblBall3.Text); //puts the number int the array for the third ball.
                        }
                    }
                } // Pick a random number between 1 and 69 for the third white ball
                if (intLoopCounter < 600)
                {
                    lblBall4.Text = rndNumber.Next(1, 6).ToString();
                    if (intLoopCounter == 599) //last time we pick the 2nd ball.
                    {
                        if (TestDouble(Convert.ToInt32(lblBall4.Text)) == -1)
                        {
                            intLoopCounter--; // subtract 1 from the loop counter to repeat the loop.
                        }
                        else
                        {
                            lottoArray[3] = Convert.ToInt32(lblBall4.Text); //puts the number int the array for the fourth ball.
                        }
                    }
                } // Pick a random number between 1 and 69 for the fourth white ball
                if (intLoopCounter < 750) {
                    lblBall5.Text = rndNumber.Next(1, 6).ToString();
                    if (intLoopCounter == 749) //last time we pick the 2nd ball.
                    {
                        if (TestDouble(Convert.ToInt32(lblBall5.Text)) == -1)
                        {
                            intLoopCounter--; // subtract 1 from the loop counter to repeat the loop.
                        }
                        else
                        {
                            lottoArray[4] = Convert.ToInt32(lblBall5.Text); //puts the number int the array for the fifth ball.
                        }
                    }
                } // Pick a random number between 1 and 69 for the fifth white ball
                if (intLoopCounter < 1000)
                {
                    lblBallRed.Text = rndNumber.Next(1, 26).ToString();
                } // Pick a random number between 1 and 26 for the red ball
            
            Refresh(); // Refresh the form to show the new numbers
            intLoopCounter++; // increments up by 1 each loop.
            }

        }

        public int TestDouble(int intNumber)

        {  if (lottoArray[0] == intNumber) {
                return -1;
            }
            else if (lottoArray[1] == intNumber) {
                return -1;
            }
            else if (lottoArray[2] == intNumber)
            {
                return -1;
            }
            else if (lottoArray[3] == intNumber)
            {
                return -1;
            }
            else if (lottoArray[4] == intNumber)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
