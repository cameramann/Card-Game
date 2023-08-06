namespace MemoryGame
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_header = new TextBox();
            lbl_username = new Label();
            lbl_password = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            linklbl_signup = new LinkLabel();
            btn_login = new Button();
            btn_back = new Button();
            lbl_error1 = new Label();
            linklbl_show = new LinkLabel();
            SuspendLayout();
            // 
            // txt_header
            // 
            txt_header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_header.BackColor = Color.FromArgb(64, 64, 64);
            txt_header.BorderStyle = BorderStyle.None;
            txt_header.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            txt_header.ForeColor = Color.Ivory;
            txt_header.ImeMode = ImeMode.Off;
            txt_header.Location = new Point(274, 72);
            txt_header.Multiline = true;
            txt_header.Name = "txt_header";
            txt_header.ReadOnly = true;
            txt_header.Size = new Size(299, 61);
            txt_header.TabIndex = 0;
            txt_header.Text = "In order to start a game please \r\nLogin into your game account first.";
            txt_header.WordWrap = false;
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.Ivory;
            lbl_username.Location = new Point(202, 190);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(106, 25);
            lbl_username.TabIndex = 7;
            lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            lbl_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.Ivory;
            lbl_password.Location = new Point(202, 265);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(102, 25);
            lbl_password.TabIndex = 8;
            lbl_password.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_username.Cursor = Cursors.IBeam;
            txt_username.Location = new Point(326, 190);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(211, 23);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Location = new Point(326, 270);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(211, 23);
            txt_password.TabIndex = 10;
            txt_password.UseSystemPasswordChar = true;
            // 
            // linklbl_signup
            // 
            linklbl_signup.ActiveLinkColor = Color.Ivory;
            linklbl_signup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            linklbl_signup.AutoSize = true;
            linklbl_signup.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linklbl_signup.LinkColor = Color.LightGreen;
            linklbl_signup.Location = new Point(303, 136);
            linklbl_signup.Name = "linklbl_signup";
            linklbl_signup.Size = new Size(234, 13);
            linklbl_signup.TabIndex = 11;
            linklbl_signup.TabStop = true;
            linklbl_signup.Text = "don't have an account? click here to sign up";
            linklbl_signup.LinkClicked += linklbl_signup_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_login.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ControlText;
            btn_login.Location = new Point(670, 370);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(104, 47);
            btn_login.TabIndex = 12;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_back.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ControlText;
            btn_back.Location = new Point(30, 370);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(114, 47);
            btn_back.TabIndex = 13;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // lbl_error1
            // 
            lbl_error1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_error1.AutoSize = true;
            lbl_error1.BackColor = Color.Transparent;
            lbl_error1.ForeColor = Color.Salmon;
            lbl_error1.Location = new Point(326, 296);
            lbl_error1.Name = "lbl_error1";
            lbl_error1.Size = new Size(182, 15);
            lbl_error1.TabIndex = 26;
            lbl_error1.Text = "*Username or Password incorrect";
            lbl_error1.Visible = false;
            // 
            // linklbl_show
            // 
            linklbl_show.ActiveLinkColor = Color.Ivory;
            linklbl_show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            linklbl_show.AutoSize = true;
            linklbl_show.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_show.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_show.LinkColor = Color.Ivory;
            linklbl_show.Location = new Point(543, 273);
            linklbl_show.Name = "linklbl_show";
            linklbl_show.Size = new Size(38, 15);
            linklbl_show.TabIndex = 29;
            linklbl_show.TabStop = true;
            linklbl_show.Text = "Show";
            linklbl_show.LinkClicked += linklbl_show_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(linklbl_show);
            Controls.Add(lbl_error1);
            Controls.Add(btn_back);
            Controls.Add(btn_login);
            Controls.Add(linklbl_signup);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(txt_header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_header;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox txt_username;
        private TextBox txt_password;
        private LinkLabel linklbl_signup;
        private Button btn_login;
        private Button btn_back;
        private Label lbl_error1;
        private LinkLabel linklbl_show;
    }
}