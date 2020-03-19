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

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void closeButton_MouseMove(object sender, MouseEventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(239, 208, 176);
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(239, 176, 176);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonKnopka_Click(object sender, EventArgs e)
        {
            pictureBoxPiz.ImageLocation = "C:/Users/Алексей/source/repos/PizzaOrder/PizzaOrder/Pictures/" + comboBoxSelP.Text + ".png";
        }
        
        private void buttonKnopka_Click_1(object sender, EventArgs e)
        {
            pictureBoxPiz.ImageLocation = "C:/Users/Алексей/source/repos/PizzaOrder/PizzaOrder/Pictures/" + comboBoxSelP.Text + ".png";
        }
       
        private void pictureBoxPiz_Click(object sender, EventArgs e)
        {

            if (comboBoxSelP.Text == "Грибная")
            {
                this.Hide();
                PictureForm1 ff = new PictureForm1();
                ff.Show();
            }

            if (comboBoxSelP.Text == "Сырная")
            {
                this.Hide();
                PictureFormChe cg = new PictureFormChe();
                cg.Show();
            }

            if (comboBoxSelP.Text == "Сананасами")
            {
                this.Hide();
                FormWithAnanasa aa = new FormWithAnanasa();
                aa.Show();
            }

            
            if (comboBoxSelP.Text == "ПодПивко")
            {
                this.Hide();
                pizBeer bbf = new pizBeer();
                bbf.Show();
            }
            


          
            
        }




        public string conString = @"Data Source=DESKTOP-1RK0ITO\SQLEXPRESS;Initial Catalog=justDB;Integrated Security=True";

    

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

        private void OrderPizButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);

            con.Open();

            if (con.State == ConnectionState.Open)
            {
                if (comboBoxSelP.Text == "Сырная")
                {
                    string vegat = "Сырная";
                    string q = "insert into orderTab(adress, [order]) values('" + AdressTextBox.Text.ToString() + "','" + vegat.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("connection made successfuly");
                }

                if (comboBoxSelP.Text == "Мясная")
                {
                    string vegat = "Мясная";
                    string q = "insert into orderTab(adress, [order]) values('" + AdressTextBox.Text.ToString() + "','" + vegat.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("connection made successfuly");
                }

                if (comboBoxSelP.Text == "ПодПивко")
                {
                    string vegat = "ПодПивко";
                    string q = "insert into orderTab(adress, [order]) values('" + AdressTextBox.Text.ToString() + "','" + vegat.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("connection made successfuly");
                }
                if (comboBoxSelP.Text == "Грибная")
                {
                    string vegat = "Грибная";
                    string q = "insert into orderTab(adress, [order]) values('" + AdressTextBox.Text.ToString() + "','" + vegat.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("connection made successfuly");
                }

                if (comboBoxSelP.Text == "Сананасами")
                {
                    string vegat = "Сананасами";
                    string q = "insert into orderTab(adress, [order]) values('" + AdressTextBox.Text.ToString() + "','" + vegat.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("connection made successfuly");
                }
                if (comboBoxSelP.Text == "Без алкогольная")
                {
                    string vegat = "Без алкогольная";
                    string q = "insert into orderTab(adress, [order]) values('" + AdressTextBox.Text.ToString() + "','" + vegat.ToString() + "')";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("connection made successfuly");
                }

            } // select type of pizza;
        }

   
    }
}
