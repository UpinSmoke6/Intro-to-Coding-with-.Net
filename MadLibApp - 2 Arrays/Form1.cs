namespace MadLibApp
{
    public partial class Form1 : Form
    {
        string[] strArray = new string[8];
        int i = 0;
        string[] strQuestionsArray =
        {
            "Enter an adjective:",
            "Enter a noun:",
            "Enter a verb (past tense):",
            "Enter a noun (plural):",
            "Enter an animal:",
            "Enter a verb ending in -ing:",
            "Enter a number:",
            "Enter a place:"
        };
        public Form1()
        {
            InitializeComponent();
            lblInput.Text = strQuestionsArray[i];
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
            
            if (i < strQuestionsArray.Length)
            {
                lblInput.Text = strQuestionsArray[i];

            }
            else
            { 
                lblStory.Text = "Yesterday was the most " + strArray[0] + " day ever! I grabbed my trusty " + strArray[1] + " and " + strArray[2] + " out the door, ready for anything. Suddenly, I heard a group of " + strArray[3] + " making noise behind me. To my surprise, they were being chased by a giant " + strArray[4] + "!\r\n\r\nI started " + strArray[5] + " as fast as I could. After about " + strArray[6] + " minutes, I ended up in the middle of " + strArray[7] + ", where everyone was shouting, “!”\r\n\r\nIt was definitely a day I’ll never forget";
                btnAdd.Enabled = false;
            }
              }
        }
    }
}