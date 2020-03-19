using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizOrd
{

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_MouseMove(object sender, MouseEventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(209, 134, 134);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(209, 171, 134);
        }

        private void downButton_MouseMove(object sender, MouseEventArgs e)
        {
            downButton.BackColor = Color.FromArgb(209, 134, 134);
        }

        private void downButton_MouseLeave(object sender, EventArgs e)
        {
            downButton.BackColor = Color.FromArgb(209, 171, 134);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPizButton_Click(object sender, EventArgs e)
        {
            if (comboBoxSelP.Text == "Грибная")
            {
                //this.Hide();
                MushrForm mu = new MushrForm();
                mu.Show();
            }

            if (comboBoxSelP.Text == "Сырная")
            {
                //this.Hide();
                CheeseForm ch = new CheeseForm();
                ch.Show();
            }

            if (comboBoxSelP.Text == "Сананасами")
            {
                //this.Hide();
                AnanasaForm an = new AnanasaForm();
                an.Show();
            }


            if (comboBoxSelP.Text == "Спивком")
            {
                //this.Hide();
                BeerForm bef = new BeerForm();
                bef.Show();
            }

            //pictureBoxPiz.ImageLocation = "C:/Users/Алексей/source/repos/PizzaOrder/PizzaOrder/Pictures/" + comboBoxSelP.Text + ".png";
        }

        private void pictureBoxPiz_Click(object sender, EventArgs e)
        {
            if (comboBoxSelP.Text == "Грибная")
            {
                //this.Hide();
                MushrForm mu = new MushrForm();
                mu.Show();
            }

            if (comboBoxSelP.Text == "Сырная")
            {
                //this.Hide();
                CheeseForm ch = new CheeseForm();
                ch.Show();
            }

            if (comboBoxSelP.Text == "Сананасами")
            {
                //this.Hide();
                AnanasaForm an = new AnanasaForm();
                an.Show();
            }


            if (comboBoxSelP.Text == "Спивком")
            {
                //this.Hide();
                BeerForm bef = new BeerForm();
                bef.Show();
            }

        }

        private void downButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adressTextBox.Text = "ул.Любая, д.11, подъезд в доме, кв. съёмная";//подсказка
            adressTextBox.ForeColor = Color.Gray;
        }

        private void adressTextBox_Click(object sender, EventArgs e)
        {
            adressTextBox.Text = null;
            adressTextBox.ForeColor = Color.Black;
        }

        // Реализация соединения с базой скл


        public string conString = @"Data Source=DESKTOP-1RK0ITO\SQLEXPRESS;Initial Catalog=justDB;Integrated Security=True";

        private void orderPizButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                if (comboBoxSelP.Text == "Сырная")
                {
                    string vegat = "Сырная";
                    string q = "insert into orderTab(adress, [order]) values('" + adressTextBox.Text.ToString() + "','" + vegat.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("connection made successfuly");
                }

            }
        }

        private void showPizButton_MouseMove(object sender, MouseEventArgs e)
        {
            showPizButton.BackColor = Color.FromArgb(209, 134, 134);
        }

        private void showPizButton_MouseLeave(object sender, EventArgs e)
        {
            showPizButton.BackColor = Color.FromArgb(134, 209, 171);
        }

        private void orderPizButton_MouseMove(object sender, MouseEventArgs e)
        {
            orderPizButton.BackColor = Color.FromArgb(209, 134, 134);
        }

        private void orderPizButton_MouseLeave(object sender, EventArgs e)
        {
            orderPizButton.BackColor = Color.FromArgb(134, 209, 171);
        }

      
    }
}
