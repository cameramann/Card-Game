namespace MemoryGame.Forms
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            lbl_username = new Label();
            linklbl_signup = new LinkLabel();
            linklbl_basic = new LinkLabel();
            linklbl_advanced = new LinkLabel();
            linklbl_about = new LinkLabel();
            linklbl_exit = new LinkLabel();
            pic_background = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_background).BeginInit();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoEllipsis = true;
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.Transparent;
            lbl_username.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.Ivory;
            lbl_username.Location = new Point(12, 9);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(65, 25);
            lbl_username.TabIndex = 8;
            lbl_username.Text = "Hello!";
            // 
            // linklbl_signup
            // 
            linklbl_signup.ActiveLinkColor = Color.Ivory;
            linklbl_signup.AutoSize = true;
            linklbl_signup.BackColor = Color.Transparent;
            linklbl_signup.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linklbl_signup.LinkColor = Color.LightGreen;
            linklbl_signup.Location = new Point(12, 34);
            linklbl_signup.Name = "linklbl_signup";
            linklbl_signup.Size = new Size(42, 13);
            linklbl_signup.TabIndex = 12;
            linklbl_signup.TabStop = true;
            linklbl_signup.Text = "logout";
            linklbl_signup.LinkClicked += linklbl_signup_LinkClicked;
            // 
            // linklbl_basic
            // 
            linklbl_basic.ActiveLinkColor = Color.Ivory;
            linklbl_basic.AutoSize = true;
            linklbl_basic.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_basic.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_basic.LinkColor = Color.Ivory;
            linklbl_basic.Location = new Point(12, 95);
            linklbl_basic.Name = "linklbl_basic";
            linklbl_basic.Size = new Size(177, 30);
            linklbl_basic.TabIndex = 13;
            linklbl_basic.TabStop = true;
            linklbl_basic.Text = "Start Basic Game";
            linklbl_basic.LinkClicked += linklbl_basic_LinkClicked;
            // 
            // linklbl_advanced
            // 
            linklbl_advanced.ActiveLinkColor = Color.Ivory;
            linklbl_advanced.AutoSize = true;
            linklbl_advanced.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_advanced.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_advanced.LinkColor = Color.Ivory;
            linklbl_advanced.Location = new Point(12, 145);
            linklbl_advanced.Name = "linklbl_advanced";
            linklbl_advanced.Size = new Size(225, 30);
            linklbl_advanced.TabIndex = 14;
            linklbl_advanced.TabStop = true;
            linklbl_advanced.Text = "Start Advanced Game";
            linklbl_advanced.LinkClicked += linklbl_advanced_LinkClicked;
            // 
            // linklbl_about
            // 
            linklbl_about.ActiveLinkColor = Color.Ivory;
            linklbl_about.AutoSize = true;
            linklbl_about.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_about.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_about.LinkColor = Color.Ivory;
            linklbl_about.Location = new Point(12, 200);
            linklbl_about.Name = "linklbl_about";
            linklbl_about.Size = new Size(75, 30);
            linklbl_about.TabIndex = 15;
            linklbl_about.TabStop = true;
            linklbl_about.Text = "About";
            linklbl_about.LinkClicked += linklbl_about_LinkClicked;
            // 
            // linklbl_exit
            // 
            linklbl_exit.ActiveLinkColor = Color.Ivory;
            linklbl_exit.AutoSize = true;
            linklbl_exit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_exit.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_exit.LinkColor = Color.Ivory;
            linklbl_exit.Location = new Point(12, 254);
            linklbl_exit.Name = "linklbl_exit";
            linklbl_exit.Size = new Size(50, 30);
            linklbl_exit.TabIndex = 16;
            linklbl_exit.TabStop = true;
            linklbl_exit.Text = "Exit";
            linklbl_exit.LinkClicked += linklbl_exit_LinkClicked;
            // 
            // pic_background
            // 
            pic_background.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pic_background.BackgroundImageLayout = ImageLayout.None;
            pic_background.Image = Properties.Resources.memory_background;
            pic_background.Location = new Point(318, 138);
            pic_background.Name = "pic_background";
            pic_background.Size = new Size(470, 300);
            pic_background.TabIndex = 17;
            pic_background.TabStop = false;
            // 
            // GameMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(pic_background);
            Controls.Add(linklbl_exit);
            Controls.Add(linklbl_about);
            Controls.Add(linklbl_advanced);
            Controls.Add(linklbl_basic);
            Controls.Add(linklbl_signup);
            Controls.Add(lbl_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GameMenu";
            Text = "Memory Cards";
            ((System.ComponentModel.ISupportInitialize)pic_background).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_username;
        private LinkLabel linklbl_signup;
        private LinkLabel linklbl_basic;
        private LinkLabel linklbl_advanced;
        private LinkLabel linklbl_about;
        private LinkLabel linklbl_exit;
        private PictureBox pic_background;
    }
}