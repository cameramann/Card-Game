namespace MemoryGame.Forms
{
    partial class AdvancedGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedGame));
            lbl_timer = new Label();
            linklbl_signup = new LinkLabel();
            btn_back = new Button();
            lbl_username = new Label();
            lbl_moves = new Label();
            lbl_score = new Label();
            pic_card17 = new PictureBox();
            pic_card16 = new PictureBox();
            pic_card15 = new PictureBox();
            pic_card14 = new PictureBox();
            pic_card13 = new PictureBox();
            pic_card12 = new PictureBox();
            pic_card11 = new PictureBox();
            pic_card10 = new PictureBox();
            pic_card9 = new PictureBox();
            pic_card8 = new PictureBox();
            pic_card7 = new PictureBox();
            pic_card6 = new PictureBox();
            pic_card5 = new PictureBox();
            pic_card1 = new PictureBox();
            pic_card2 = new PictureBox();
            pic_card3 = new PictureBox();
            pic_card4 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pic_card17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_card4).BeginInit();
            SuspendLayout();
            // 
            // lbl_timer
            // 
            lbl_timer.AutoSize = true;
            lbl_timer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_timer.ForeColor = Color.Ivory;
            lbl_timer.Location = new Point(425, 191);
            lbl_timer.Name = "lbl_timer";
            lbl_timer.Size = new Size(77, 32);
            lbl_timer.TabIndex = 49;
            lbl_timer.Text = "00:10";
            // 
            // linklbl_signup
            // 
            linklbl_signup.ActiveLinkColor = Color.Ivory;
            linklbl_signup.AutoSize = true;
            linklbl_signup.BackColor = Color.Transparent;
            linklbl_signup.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            linklbl_signup.LinkColor = Color.LightGreen;
            linklbl_signup.Location = new Point(12, 41);
            linklbl_signup.Name = "linklbl_signup";
            linklbl_signup.Size = new Size(42, 13);
            linklbl_signup.TabIndex = 48;
            linklbl_signup.TabStop = true;
            linklbl_signup.Text = "logout";
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_back.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ControlText;
            btn_back.Location = new Point(30, 552);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(114, 47);
            btn_back.TabIndex = 46;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.Ivory;
            lbl_username.Location = new Point(12, 9);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(93, 32);
            lbl_username.TabIndex = 45;
            lbl_username.Text = "Player:";
            // 
            // lbl_moves
            // 
            lbl_moves.AutoSize = true;
            lbl_moves.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_moves.ForeColor = Color.Ivory;
            lbl_moves.Location = new Point(12, 122);
            lbl_moves.Name = "lbl_moves";
            lbl_moves.Size = new Size(167, 32);
            lbl_moves.TabIndex = 43;
            lbl_moves.Text = "Moves Left: 5";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_score.ForeColor = Color.Ivory;
            lbl_score.Location = new Point(12, 174);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(105, 32);
            lbl_score.TabIndex = 42;
            lbl_score.Text = "Score: 0";
            // 
            // pic_card17
            // 
            pic_card17.BackColor = Color.Transparent;
            pic_card17.ErrorImage = null;
            pic_card17.Image = Properties.Resources.CardBackMain1;
            pic_card17.InitialImage = Properties.Resources.CardBackMain1;
            pic_card17.Location = new Point(412, 240);
            pic_card17.Name = "pic_card17";
            pic_card17.Size = new Size(105, 140);
            pic_card17.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card17.TabIndex = 41;
            pic_card17.TabStop = false;
            // 
            // pic_card16
            // 
            pic_card16.BackColor = Color.Ivory;
            pic_card16.ErrorImage = null;
            pic_card16.Image = Properties.Resources.CardsBack16;
            pic_card16.InitialImage = Properties.Resources.CardsBack16;
            pic_card16.Location = new Point(886, 471);
            pic_card16.Name = "pic_card16";
            pic_card16.Size = new Size(105, 140);
            pic_card16.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card16.TabIndex = 40;
            pic_card16.TabStop = false;
            pic_card16.Click += pic_card16_Click;
            // 
            // pic_card15
            // 
            pic_card15.BackColor = Color.Ivory;
            pic_card15.ErrorImage = null;
            pic_card15.Image = Properties.Resources.CardsBack15;
            pic_card15.InitialImage = Properties.Resources.CardsBack15;
            pic_card15.Location = new Point(768, 471);
            pic_card15.Name = "pic_card15";
            pic_card15.Size = new Size(105, 140);
            pic_card15.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card15.TabIndex = 39;
            pic_card15.TabStop = false;
            pic_card15.Click += pic_card15_Click;
            // 
            // pic_card14
            // 
            pic_card14.BackColor = Color.Ivory;
            pic_card14.ErrorImage = null;
            pic_card14.Image = Properties.Resources.CardsBack14;
            pic_card14.InitialImage = Properties.Resources.CardsBack14;
            pic_card14.Location = new Point(649, 471);
            pic_card14.Name = "pic_card14";
            pic_card14.Size = new Size(105, 140);
            pic_card14.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card14.TabIndex = 38;
            pic_card14.TabStop = false;
            pic_card14.Click += pic_card14_Click;
            // 
            // pic_card13
            // 
            pic_card13.BackColor = Color.Ivory;
            pic_card13.ErrorImage = null;
            pic_card13.Image = Properties.Resources.CardsBack13;
            pic_card13.InitialImage = Properties.Resources.CardsBack13;
            pic_card13.Location = new Point(530, 471);
            pic_card13.Name = "pic_card13";
            pic_card13.Size = new Size(105, 140);
            pic_card13.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card13.TabIndex = 37;
            pic_card13.TabStop = false;
            pic_card13.Click += pic_card13_Click;
            // 
            // pic_card12
            // 
            pic_card12.BackColor = Color.Ivory;
            pic_card12.ErrorImage = null;
            pic_card12.Image = Properties.Resources.CardsBack12;
            pic_card12.InitialImage = Properties.Resources.CardsBack12;
            pic_card12.Location = new Point(886, 316);
            pic_card12.Name = "pic_card12";
            pic_card12.Size = new Size(105, 140);
            pic_card12.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card12.TabIndex = 36;
            pic_card12.TabStop = false;
            pic_card12.Click += pic_card12_Click;
            // 
            // pic_card11
            // 
            pic_card11.BackColor = Color.Ivory;
            pic_card11.ErrorImage = null;
            pic_card11.Image = Properties.Resources.CardsBack11;
            pic_card11.InitialImage = Properties.Resources.CardsBack11;
            pic_card11.Location = new Point(768, 316);
            pic_card11.Name = "pic_card11";
            pic_card11.Size = new Size(105, 140);
            pic_card11.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card11.TabIndex = 35;
            pic_card11.TabStop = false;
            pic_card11.Click += pic_card11_Click;
            // 
            // pic_card10
            // 
            pic_card10.BackColor = Color.Ivory;
            pic_card10.ErrorImage = null;
            pic_card10.Image = Properties.Resources.CardsBack10;
            pic_card10.InitialImage = Properties.Resources.CardsBack10;
            pic_card10.Location = new Point(649, 316);
            pic_card10.Name = "pic_card10";
            pic_card10.Size = new Size(105, 140);
            pic_card10.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card10.TabIndex = 34;
            pic_card10.TabStop = false;
            pic_card10.Click += pic_card10_Click;
            // 
            // pic_card9
            // 
            pic_card9.BackColor = Color.Ivory;
            pic_card9.ErrorImage = null;
            pic_card9.Image = Properties.Resources.CardsBack9;
            pic_card9.InitialImage = Properties.Resources.CardsBack9;
            pic_card9.Location = new Point(530, 316);
            pic_card9.Name = "pic_card9";
            pic_card9.Size = new Size(105, 140);
            pic_card9.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card9.TabIndex = 33;
            pic_card9.TabStop = false;
            pic_card9.Click += pic_card9_Click;
            // 
            // pic_card8
            // 
            pic_card8.BackColor = Color.Ivory;
            pic_card8.ErrorImage = null;
            pic_card8.Image = Properties.Resources.CardsBack8;
            pic_card8.InitialImage = Properties.Resources.CardsBack8;
            pic_card8.Location = new Point(886, 163);
            pic_card8.Name = "pic_card8";
            pic_card8.Size = new Size(105, 140);
            pic_card8.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card8.TabIndex = 32;
            pic_card8.TabStop = false;
            pic_card8.Click += pic_card8_Click;
            // 
            // pic_card7
            // 
            pic_card7.BackColor = Color.Ivory;
            pic_card7.ErrorImage = null;
            pic_card7.Image = Properties.Resources.CardsBack7;
            pic_card7.InitialImage = Properties.Resources.CardsBack7;
            pic_card7.Location = new Point(768, 163);
            pic_card7.Name = "pic_card7";
            pic_card7.Size = new Size(105, 140);
            pic_card7.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card7.TabIndex = 31;
            pic_card7.TabStop = false;
            pic_card7.Click += pic_card7_Click;
            // 
            // pic_card6
            // 
            pic_card6.BackColor = Color.Ivory;
            pic_card6.ErrorImage = null;
            pic_card6.Image = Properties.Resources.CardsBack6;
            pic_card6.InitialImage = Properties.Resources.CardsBack6;
            pic_card6.Location = new Point(649, 163);
            pic_card6.Name = "pic_card6";
            pic_card6.Size = new Size(105, 140);
            pic_card6.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card6.TabIndex = 30;
            pic_card6.TabStop = false;
            pic_card6.Click += pic_card6_Click;
            // 
            // pic_card5
            // 
            pic_card5.BackColor = Color.Ivory;
            pic_card5.ErrorImage = null;
            pic_card5.Image = Properties.Resources.CardsBack5;
            pic_card5.InitialImage = Properties.Resources.CardsBack5;
            pic_card5.Location = new Point(530, 163);
            pic_card5.Name = "pic_card5";
            pic_card5.Size = new Size(105, 140);
            pic_card5.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card5.TabIndex = 29;
            pic_card5.TabStop = false;
            pic_card5.Click += pic_card5_Click;
            // 
            // pic_card1
            // 
            pic_card1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pic_card1.BackColor = Color.Ivory;
            pic_card1.ErrorImage = null;
            pic_card1.Image = Properties.Resources.CardBack1;
            pic_card1.ImageLocation = "";
            pic_card1.InitialImage = Properties.Resources.CardBack1;
            pic_card1.Location = new Point(530, 12);
            pic_card1.Name = "pic_card1";
            pic_card1.Size = new Size(105, 140);
            pic_card1.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card1.TabIndex = 28;
            pic_card1.TabStop = false;
            pic_card1.Click += pic_card1_Click;
            // 
            // pic_card2
            // 
            pic_card2.BackColor = Color.Ivory;
            pic_card2.ErrorImage = null;
            pic_card2.Image = Properties.Resources.CardsBack2;
            pic_card2.InitialImage = Properties.Resources.CardsBack2;
            pic_card2.Location = new Point(649, 12);
            pic_card2.Name = "pic_card2";
            pic_card2.Size = new Size(105, 140);
            pic_card2.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card2.TabIndex = 27;
            pic_card2.TabStop = false;
            pic_card2.Click += pic_card2_Click;
            // 
            // pic_card3
            // 
            pic_card3.BackColor = Color.Ivory;
            pic_card3.ErrorImage = null;
            pic_card3.Image = Properties.Resources.CardsBack3;
            pic_card3.InitialImage = Properties.Resources.CardsBack3;
            pic_card3.Location = new Point(768, 12);
            pic_card3.Name = "pic_card3";
            pic_card3.Size = new Size(105, 140);
            pic_card3.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card3.TabIndex = 26;
            pic_card3.TabStop = false;
            pic_card3.Click += pic_card3_Click;
            // 
            // pic_card4
            // 
            pic_card4.BackColor = Color.Ivory;
            pic_card4.ErrorImage = null;
            pic_card4.Image = Properties.Resources.CardsBack4;
            pic_card4.InitialImage = Properties.Resources.CardsBack4;
            pic_card4.Location = new Point(886, 12);
            pic_card4.Name = "pic_card4";
            pic_card4.Size = new Size(105, 140);
            pic_card4.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_card4.TabIndex = 25;
            pic_card4.TabStop = false;
            pic_card4.Click += pic_card4_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // AdvancedGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(999, 631);
            Controls.Add(lbl_timer);
            Controls.Add(linklbl_signup);
            Controls.Add(btn_back);
            Controls.Add(lbl_username);
            Controls.Add(lbl_moves);
            Controls.Add(lbl_score);
            Controls.Add(pic_card17);
            Controls.Add(pic_card16);
            Controls.Add(pic_card15);
            Controls.Add(pic_card14);
            Controls.Add(pic_card13);
            Controls.Add(pic_card12);
            Controls.Add(pic_card11);
            Controls.Add(pic_card10);
            Controls.Add(pic_card9);
            Controls.Add(pic_card8);
            Controls.Add(pic_card7);
            Controls.Add(pic_card6);
            Controls.Add(pic_card5);
            Controls.Add(pic_card1);
            Controls.Add(pic_card2);
            Controls.Add(pic_card3);
            Controls.Add(pic_card4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdvancedGame";
            Text = "Advanced Game";
            ((System.ComponentModel.ISupportInitialize)pic_card17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_card4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_timer;
        private LinkLabel linklbl_signup;
        private Button btn_back;
        private Label lbl_username;
        private Label lbl_moves;
        private Label lbl_score;
        private PictureBox pic_card17;
        private PictureBox pic_card16;
        private PictureBox pic_card15;
        private PictureBox pic_card14;
        private PictureBox pic_card13;
        private PictureBox pic_card12;
        private PictureBox pic_card11;
        private PictureBox pic_card10;
        private PictureBox pic_card9;
        private PictureBox pic_card8;
        private PictureBox pic_card7;
        private PictureBox pic_card6;
        private PictureBox pic_card5;
        private PictureBox pic_card1;
        private PictureBox pic_card2;
        private PictureBox pic_card3;
        private PictureBox pic_card4;
        private System.Windows.Forms.Timer timer;
    }
}