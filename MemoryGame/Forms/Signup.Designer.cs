namespace MemoryGame
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            btn_back = new Button();
            btn_signup = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            lbl_password = new Label();
            lbl_username = new Label();
            txt_confirm = new TextBox();
            lbl_confirm = new Label();
            txt_email = new TextBox();
            lbl_email = new Label();
            lbl_title = new Label();
            lbl_error1 = new Label();
            lbl_error2 = new Label();
            lbl_error3 = new Label();
            lbl_error4 = new Label();
            linklbl_show1 = new LinkLabel();
            linklbl_show2 = new LinkLabel();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_back.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ControlText;
            btn_back.Location = new Point(30, 370);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(114, 47);
            btn_back.TabIndex = 15;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_signup
            // 
            btn_signup.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_signup.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signup.ForeColor = SystemColors.ControlText;
            btn_signup.Location = new Point(670, 370);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(104, 47);
            btn_signup.TabIndex = 14;
            btn_signup.Text = "Sign up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Location = new Point(303, 245);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(211, 23);
            txt_password.TabIndex = 19;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_username.Cursor = Cursors.IBeam;
            txt_username.Location = new Point(303, 145);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(211, 23);
            txt_username.TabIndex = 16;
            // 
            // lbl_password
            // 
            lbl_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.Ivory;
            lbl_password.Location = new Point(179, 240);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(102, 25);
            lbl_password.TabIndex = 18;
            lbl_password.Text = "Password:";
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.Ivory;
            lbl_username.Location = new Point(179, 145);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(106, 25);
            lbl_username.TabIndex = 17;
            lbl_username.Text = "Username:";
            // 
            // txt_confirm
            // 
            txt_confirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_confirm.Cursor = Cursors.IBeam;
            txt_confirm.Location = new Point(303, 293);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Size = new Size(211, 23);
            txt_confirm.TabIndex = 21;
            txt_confirm.UseSystemPasswordChar = true;
            // 
            // lbl_confirm
            // 
            lbl_confirm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_confirm.AutoSize = true;
            lbl_confirm.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_confirm.ForeColor = Color.Ivory;
            lbl_confirm.Location = new Point(101, 293);
            lbl_confirm.Name = "lbl_confirm";
            lbl_confirm.Size = new Size(180, 25);
            lbl_confirm.TabIndex = 20;
            lbl_confirm.Text = "Confirm Password:";
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_email.Cursor = Cursors.IBeam;
            txt_email.Location = new Point(303, 195);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(211, 23);
            txt_email.TabIndex = 22;
            // 
            // lbl_email
            // 
            lbl_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_email.ForeColor = Color.Ivory;
            lbl_email.Location = new Point(217, 195);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(64, 25);
            lbl_email.TabIndex = 23;
            lbl_email.Text = "Email:";
            // 
            // lbl_title
            // 
            lbl_title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.ForeColor = Color.LightGreen;
            lbl_title.Location = new Point(250, 70);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(285, 30);
            lbl_title.TabIndex = 24;
            lbl_title.Text = "Sign-up and start playing!";
            // 
            // lbl_error1
            // 
            lbl_error1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_error1.AutoSize = true;
            lbl_error1.BackColor = Color.Transparent;
            lbl_error1.ForeColor = Color.Salmon;
            lbl_error1.Location = new Point(303, 171);
            lbl_error1.Name = "lbl_error1";
            lbl_error1.Size = new Size(302, 15);
            lbl_error1.TabIndex = 25;
            lbl_error1.Text = "*User name should be between 3 and 30 characters long";
            lbl_error1.Visible = false;
            // 
            // lbl_error2
            // 
            lbl_error2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_error2.AutoSize = true;
            lbl_error2.BackColor = Color.Transparent;
            lbl_error2.ForeColor = Color.Salmon;
            lbl_error2.Location = new Point(303, 221);
            lbl_error2.Name = "lbl_error2";
            lbl_error2.Size = new Size(195, 15);
            lbl_error2.TabIndex = 26;
            lbl_error2.Text = "*Email should be in correct formant";
            lbl_error2.Visible = false;
            // 
            // lbl_error3
            // 
            lbl_error3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_error3.BackColor = Color.Transparent;
            lbl_error3.ForeColor = Color.Salmon;
            lbl_error3.Location = new Point(303, 271);
            lbl_error3.Name = "lbl_error3";
            lbl_error3.Size = new Size(296, 15);
            lbl_error3.TabIndex = 27;
            lbl_error3.Text = "*Password should be between 6 and 30 characters long\r\n\r\n";
            lbl_error3.Visible = false;
            // 
            // lbl_error4
            // 
            lbl_error4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_error4.AutoSize = true;
            lbl_error4.BackColor = Color.Transparent;
            lbl_error4.ForeColor = Color.Salmon;
            lbl_error4.Location = new Point(303, 319);
            lbl_error4.Name = "lbl_error4";
            lbl_error4.Size = new Size(143, 15);
            lbl_error4.TabIndex = 28;
            lbl_error4.Text = "*Passwords should match";
            lbl_error4.Visible = false;
            // 
            // linklbl_show1
            // 
            linklbl_show1.ActiveLinkColor = Color.Ivory;
            linklbl_show1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            linklbl_show1.AutoSize = true;
            linklbl_show1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_show1.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_show1.LinkColor = Color.Ivory;
            linklbl_show1.Location = new Point(520, 250);
            linklbl_show1.Name = "linklbl_show1";
            linklbl_show1.Size = new Size(38, 15);
            linklbl_show1.TabIndex = 30;
            linklbl_show1.TabStop = true;
            linklbl_show1.Text = "Show";
            linklbl_show1.LinkClicked += linklbl_show1_LinkClicked;
            // 
            // linklbl_show2
            // 
            linklbl_show2.ActiveLinkColor = Color.Ivory;
            linklbl_show2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            linklbl_show2.AutoSize = true;
            linklbl_show2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_show2.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_show2.LinkColor = Color.Ivory;
            linklbl_show2.Location = new Point(520, 296);
            linklbl_show2.Name = "linklbl_show2";
            linklbl_show2.Size = new Size(38, 15);
            linklbl_show2.TabIndex = 31;
            linklbl_show2.TabStop = true;
            linklbl_show2.Text = "Show";
            linklbl_show2.LinkClicked += linklbl_show2_LinkClicked;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(linklbl_show2);
            Controls.Add(linklbl_show1);
            Controls.Add(lbl_error4);
            Controls.Add(lbl_error3);
            Controls.Add(lbl_error2);
            Controls.Add(lbl_error1);
            Controls.Add(lbl_title);
            Controls.Add(txt_email);
            Controls.Add(lbl_email);
            Controls.Add(txt_confirm);
            Controls.Add(lbl_confirm);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Controls.Add(btn_back);
            Controls.Add(btn_signup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Signup";
            Text = "Sign-up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Button btn_signup;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label lbl_password;
        private Label lbl_username;
        private TextBox txt_confirm;
        private Label lbl_confirm;
        private TextBox txt_email;
        private Label lbl_email;
        private Label lbl_title;
        private Label lbl_error1;
        private Label lbl_error2;
        private Label lbl_error3;
        private Label lbl_error4;
        private LinkLabel linklbl_show1;
        private LinkLabel linklbl_show2;
    }
}