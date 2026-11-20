namespace RiddleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        private void btnRiddle1_Click(object sender, EventArgs e)
        {
            lblOutQuestion.Text =
                "What has keys but cannot open locks?"; //puts text toward the label

            lblOutAnswer.Text = ""; //leaves the answer label blank
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            lblOutAnswer.Text = "A piano."; //puts the answer in the Answer label
        }

        private void btnRiddle2_Click(object sender, EventArgs e)
        {
            lblOutQuestion.Text =
                "What gets wetter the more it dries?"; //puts text toward the label

            lblOutAnswer.Text = ""; //leaves the answer labelblank
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            lblOutAnswer.Text = "A towel.";    //puts the answer in the Answer label
        }

        private void btnRiddle3_Click(object sender, EventArgs e)
        {
            lblOutQuestion.Text =
                "What has a face and two hands but no arms or legs?"; // puts text toward the label

            lblOutAnswer.Text = "";     //leaves the answer blank
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            lblOutAnswer.Text = "A clock.";//puts the answer in the Answer label
        }

        private void btnRiddle4_Click(object sender, EventArgs e)
        {
            lblOutQuestion.Text =
                "What can travel around the world while staying in one corner?"; //puts text toward the label

            lblOutAnswer.Text = ""; //leaves the answer blank
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            lblOutAnswer.Text = "A stamp."; //puts the answer in the Answer label
        }
    }
}