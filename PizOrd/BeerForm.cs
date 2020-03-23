using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizOrd
{
    public partial class BeerForm : Form
    {
        public BeerForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 g = new Form1();
            g.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 g = new Form1();
            g.Show();
        }

        private void ShowComposition_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label17.Visible = true;
            label9.Visible = true;
            label19.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 g = new Form1();
            g.Show();
        }
    }
}
