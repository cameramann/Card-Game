using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class GameMenu : Form
    {

        //
        //Ctor
        //
        public GameMenu()
        {
            InitializeComponent();
            lbl_username.Text = $"Hello {Global.Username}!";
        }

        //
        //Buttons
        //
        private void linklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Global.Username = "";
            Global.Password = "";
            Global.Logged = false;
            this.Hide();
            Login new_main = new Login();
            new_main.Show();
        }

        private void linklbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void linklbl_basic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BasicGame new_main = new BasicGame();
            new_main.Show();
        }

        private void linklbl_advanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdvancedGame new_main = new AdvancedGame();
            new_main.Show();
        }

        private void linklbl_about_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            About new_main = new About();
            new_main.Show();
        }
    }
}
