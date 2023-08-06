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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameMenu new_main = new GameMenu();
            new_main.Show();
        }
    }
}
