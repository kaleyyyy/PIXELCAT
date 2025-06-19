using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamoga
{
    public partial class GameScreen : Form
    {
        string username = "Player1";
        public GameScreen()
        {
            InitializeComponent();
            this.FormClosed += GameScreen_FormClosed; // Ensure the main menu is hidden when this form is closed
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            username = textBox1.Text;
            MessageBox.Show("Your cats name is: " + username);
            label3.Hide();      // Label: "Choose a name"
            textBox1.Hide();    // Input box
            button1.Hide();
            pictureBox2.Visible = true;// Confirm button
        }

        private void GameScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
