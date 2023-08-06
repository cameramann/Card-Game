namespace MemoryGame
{
    partial class WelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            linklbl_start = new LinkLabel();
            linklbl_exit = new LinkLabel();
            lbl_header = new Label();
            lbl_author = new Label();
            pic_background = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_background).BeginInit();
            SuspendLayout();
            // 
            // linklbl_start
            // 
            linklbl_start.ActiveLinkColor = Color.Ivory;
            linklbl_start.AutoSize = true;
            linklbl_start.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_start.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_start.LinkColor = Color.Ivory;
            linklbl_start.Location = new Point(32, 146);
            linklbl_start.Name = "linklbl_start";
            linklbl_start.Size = new Size(173, 30);
            linklbl_start.TabIndex = 4;
            linklbl_start.TabStop = true;
            linklbl_start.Text = "Start New Game";
            linklbl_start.LinkClicked += linklbl_start_LinkClicked;
            // 
            // linklbl_exit
            // 
            linklbl_exit.ActiveLinkColor = Color.Ivory;
            linklbl_exit.AutoSize = true;
            linklbl_exit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linklbl_exit.LinkBehavior = LinkBehavior.NeverUnderline;
            linklbl_exit.LinkColor = Color.Ivory;
            linklbl_exit.Location = new Point(32, 176);
            linklbl_exit.Name = "linklbl_exit";
            linklbl_exit.Size = new Size(50, 30);
            linklbl_exit.TabIndex = 5;
            linklbl_exit.TabStop = true;
            linklbl_exit.Text = "Exit";
            linklbl_exit.LinkClicked += linklbl_exit_LinkClicked;
            // 
            // lbl_header
            // 
            lbl_header.AutoSize = true;
            lbl_header.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_header.ForeColor = Color.Ivory;
            lbl_header.Location = new Point(32, 64);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(241, 45);
            lbl_header.TabIndex = 6;
            lbl_header.Text = "Memory Cards";
            // 
            // lbl_author
            // 
            lbl_author.AutoSize = true;
            lbl_author.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_author.ForeColor = Color.Ivory;
            lbl_author.Location = new Point(267, 86);
            lbl_author.Name = "lbl_author";
            lbl_author.Size = new Size(129, 17);
            lbl_author.TabIndex = 7;
            lbl_author.Text = "by Michael Gozman";
            // 
            // pic_background
            // 
            pic_background.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pic_background.BackgroundImageLayout = ImageLayout.None;
            pic_background.Image = Properties.Resources.memory_background;
            pic_background.Location = new Point(321, 146);
            pic_background.Name = "pic_background";
            pic_background.Size = new Size(470, 300);
            pic_background.TabIndex = 8;
            pic_background.TabStop = false;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(pic_background);
            Controls.Add(lbl_author);
            Controls.Add(lbl_header);
            Controls.Add(linklbl_exit);
            Controls.Add(linklbl_start);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeScreen";
            Text = "Memory Cards";
            ((System.ComponentModel.ISupportInitialize)pic_background).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel linklbl_start;
        private LinkLabel linklbl_exit;
        private Label lbl_header;
        private Label lbl_author;
        private PictureBox pic_background;
    }
}