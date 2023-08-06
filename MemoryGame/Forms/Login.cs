using MemoryGame.AppData;
using MemoryGame.Forms;
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
    public partial class Login : Form
    {

        //
        //Properties
        //
        DBAccess objDBAccess;
        DataTable dtUsers;
        private string _username;
        private string _password;

        //
        //Ctor
        //
        public Login()
        {

            InitializeComponent();
            objDBAccess = new DBAccess();
            dtUsers = new DataTable();
            this.ActiveControl = null;
        }

        //
        //Buttons
        //
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeScreen new_main = new WelcomeScreen();
            new_main.Show();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            _username = txt_username.Text;
            _password = txt_password.Text;
            lbl_error1.Visible = false;
            if (!String.IsNullOrEmpty(_username) && !String.IsNullOrEmpty(_password))
            {
                string query = "Select * from UsersTable Where UserName = '" + _username + "' AND Password ='" + _password + "'";
                objDBAccess.readDatathroughAdapter(query, dtUsers);
                if (dtUsers.Rows.Count == 1)
                {
                    objDBAccess.closeConn();
                    Global.Username = _username;
                    Global.Password = _password;
                    Global.Logged = true;
                    this.Hide();
                    GameMenu new_main = new GameMenu();
                    new_main.Show();
                }
                else
                    lbl_error1.Visible = true;
            }
            else
                lbl_error1.Visible = true;
        }

        private void linklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup new_main = new Signup();
            new_main.Show();
        }

        private void linklbl_show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //Show Password
        {
            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.UseSystemPasswordChar = false;
                linklbl_show.Text = "Hide";
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                linklbl_show.Text = "Show";
            }
        }
    }
}
