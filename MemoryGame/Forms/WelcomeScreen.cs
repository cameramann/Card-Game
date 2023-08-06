using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MemoryGame
{
    public partial class WelcomeScreen : Form
    {

        //
        //Ctor
        //
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        //
        //Buttons
        //
        private void linklbl_start_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login new_login = new Login();
            new_login.Show();

        }

        private void linklbl_exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
