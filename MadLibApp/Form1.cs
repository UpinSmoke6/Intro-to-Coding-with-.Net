namespace MadLibApp
{
    public partial class Form1 : Form
    {
        string[] strArray = new string[8];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            lblInput.Text = "Enter an adjective:";
        }
        private void AddToArray()
        {
             strArray[i] = txtBoxInput.Text;
            i++;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddToArray();
            txtBoxInput.Clear();
            
            if (i == 1)
            {
                lblInput.Text = "Enter a noun:";

            }
            else if (i == 2)
            {
                lblInput.Text = "Enter a verb (past tense):";

            }
            else if (i == 3)
            {
                lblInput.Text = "Enter a noun (plural):";

            }
            else if (i == 4)
            {
                lblInput.Text = "Enter an animal:";

            }
            else if (i == 5)
            {
                lblInput.Text = "Enter a verb ending in -ing:";

            }
            else if (i == 6)
            {
                lblInput.Text = "Enter a number:";

            }
            else if (i == 7)
            {
                lblInput.Text = "Enter a place:";
            }
            else if (i == 8)
            { 
                lblStory.Text = "Yesterday was the most " + strArray[0] + " day ever! I grabbed my trusty " + strArray[1] + " and " + strArray[2] + " out the door, ready for anything. Suddenly, I heard a group of " + strArray[3] + " making noise behind me. To my surprise, they were being chased by a giant " + strArray[4] + "!\r\n\r\nI started " + strArray[5] + " as fast as I could. After about " + strArray[6] + " minutes, I ended up in the middle of " + strArray[7] + ", where everyone was shouting, “!”\r\n\r\nIt was definitely a day I’ll never forget";
                btnAdd.Enabled = false;
            }
              }
        }
    }
}