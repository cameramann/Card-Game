using MemoryGame.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MemoryGame
{
    public partial class Signup : Form
    {

        //
        //Properties
        //
        DBAccess objDBAccess;
        private string _username;
        private string _email;
        private string _password;

        //
        //Ctor
        //
        public Signup()
        {
            InitializeComponent();
            objDBAccess = new DBAccess();
        }

        //
        //Buttons
        //
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login new_main = new Login();
            new_main.Show();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            lbl_error1.Visible = false;
            lbl_error2.Visible = false;
            lbl_error3.Visible = false;
            lbl_error4.Visible = false;

            if (SignupCheck())
            {
                _username = txt_username.Text;
                _email = txt_email.Text;
                _password = txt_password.Text;
                SqlCommand insertCommand = new SqlCommand("insert into UsersTable(UserName,Email,Password) values(@username,@email,@password)");
                insertCommand.Parameters.AddWithValue("@username", _username);
                insertCommand.Parameters.AddWithValue("@email", _email);
                insertCommand.Parameters.AddWithValue("@password", _password);
                int row = objDBAccess.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Account Created Succesfully.");
                    this.Hide();
                    Login new_main = new Login();
                    new_main.Show();
                }
                else
                    MessageBox.Show("Error while creating account, please try again.");
            }
        }

        private void linklbl_show1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //Show Password
        {
            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.UseSystemPasswordChar = false;
                linklbl_show1.Text = "Hide";
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                linklbl_show1.Text = "Show";
            }
        }

        private void linklbl_show2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //Show Password Confirmation
        {

            if (txt_confirm.UseSystemPasswordChar)
            {
                txt_confirm.UseSystemPasswordChar = false;
                linklbl_show2.Text = "Hide";
            }
            else
            {
                txt_confirm.UseSystemPasswordChar = true;
                linklbl_show2.Text = "Show";
            }
        }

        //
        //My Code
        //
        private bool SignupCheck()
        //Signup validation
        {
            bool flag = true;
            if (txt_username.Text.Length < 3 || txt_username.Text.Length > 30)
            {
                flag = false;
                lbl_error1.Visible = true;
            }
            if (txt_email.Text.Length < 1)
            {
                flag = false;
                lbl_error2.Visible = true;
            }
            if (txt_password.Text.Length < 6 || txt_password.Text.Length > 30)
            {
                flag = false;
                lbl_error3.Visible = true;
            }
            if (!txt_password.Text.Equals(txt_confirm.Text))
            {
                flag = false;
                lbl_error4.Visible = true;
            }
            return flag;
        }
    }
}
