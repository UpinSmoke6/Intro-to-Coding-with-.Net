using System.Security.Cryptography.Xml;

namespace Random_Quest_Generator
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string[] adjectives = {
        "mysterious", "ancient", "dangerous", "magical", "frozen"
                };

        string[] creatures =
        {
            "dragon", "robot", "wizard", "troll", "giant spider"
        };

        string[] places =
        {
            "forest", "castle", "dungeon", "mountain", "desert"
        };

        public Form1()
        {
            InitializeComponent();
            lblQuest.Text = "Generate to view a quest!";
        
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
            string adjective = adjectives[rand.Next(adjectives.Length)];
            string creature = creatures[rand.Next(creatures.Length)];
            string place = places[rand.Next(places.Length)];

            lblQuest.Text = $"The {adjective} {creature} is terrorizing the {place}!";
        }
    }
}
