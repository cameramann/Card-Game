namespace MemoryGame.Forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            lbl_header = new Label();
            lbl_header2 = new Label();
            txt_header = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            btn_back = new Button();
            SuspendLayout();
            // 
            // lbl_header
            // 
            lbl_header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_header.AutoSize = true;
            lbl_header.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_header.ForeColor = Color.Ivory;
            lbl_header.Location = new Point(229, 9);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(333, 56);
            lbl_header.TabIndex = 0;
            lbl_header.Text = "Get Started with \"Memory Cards\"\r\n\r\n";
            // 
            // lbl_header2
            // 
            lbl_header2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_header2.AutoSize = true;
            lbl_header2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_header2.ForeColor = Color.LightGreen;
            lbl_header2.Location = new Point(12, 65);
            lbl_header2.Name = "lbl_header2";
            lbl_header2.Size = new Size(406, 50);
            lbl_header2.TabIndex = 1;
            lbl_header2.Text = "In this section you can read about how to play\r\n\"Memory Cards\" and start playing!\r\n";
            // 
            // txt_header
            // 
            txt_header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txt_header.BackColor = Color.FromArgb(64, 64, 64);
            txt_header.BorderStyle = BorderStyle.None;
            txt_header.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txt_header.ForeColor = Color.Ivory;
            txt_header.ImeMode = ImeMode.Off;
            txt_header.Location = new Point(12, 158);
            txt_header.Multiline = true;
            txt_header.Name = "txt_header";
            txt_header.ReadOnly = true;
            txt_header.Size = new Size(373, 427);
            txt_header.TabIndex = 2;
            txt_header.TabStop = false;
            txt_header.Text = resources.GetString("txt_header.Text");
            txt_header.WordWrap = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(12, 137);
            label1.Name = "label1";
            label1.Size = new Size(780, 2);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(391, 148);
            label2.Name = "label2";
            label2.Size = new Size(2, 440);
            label2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Ivory;
            textBox1.ImeMode = ImeMode.Off;
            textBox1.Location = new Point(415, 158);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(373, 187);
            textBox1.TabIndex = 5;
            textBox1.TabStop = false;
            textBox1.Text = resources.GetString("textBox1.Text");
            textBox1.WordWrap = false;
            // 
            // btn_back
            // 
            btn_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_back.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.ForeColor = SystemColors.ControlText;
            btn_back.Location = new Point(660, 522);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(114, 47);
            btn_back.TabIndex = 47;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 597);
            Controls.Add(btn_back);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_header);
            Controls.Add(lbl_header2);
            Controls.Add(lbl_header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "About";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_header;
        private Label lbl_header2;
        private TextBox txt_header;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btn_back;
    }
}