
namespace MiniTrivia
{
    public partial class Form1 : Form
    {
        string[] questions =
        {
            "What languages are you learning?",
            "How many sides to a triangle?",
            "What color is the mixture of blue and red?"
        };

        string[] answers =
        {
            "C#",
            "3",
            "Purple"
        };
            int questionIndex = 0;
            int score = 0;

        public Form1()
        {
            InitializeComponent();
            lblQuestion.Text = questions[questionIndex];
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        { 
            if (txtAnswer.Text.ToLower() == answers[questionIndex].ToLower()) 
            {
               score++;
               lblScore.Text = "Your score is: " + score.ToString();
            }
            questionIndex++;
            txtAnswer.Clear();


            if (questionIndex < questions.Length)
            {
                lblQuestion.Text = questions[questionIndex];
            }
            else
            {
                lblScore.Text = "Your score is: " + score.ToString();
                btnSubmit.Enabled = false;
            }
        }
    }
}
