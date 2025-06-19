namespace tamoga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
           this.Hide(); // Hide the main menu form
            gameWindow.ShowDialog(); // Show the game screen as a dialog
            this.Close(); // Close the main menu form when the game screen is closed
        }
    }
}
