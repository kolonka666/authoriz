using Microsoft.Win32;
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

namespace Autoriz_Ebala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = @"Data Source=DESKTOP-A98NHE1\SQLEXPRESS;Initial Catalog=clothes_shop;Integrated Security=True";
            {
                SqlConnection connection = new SqlConnection(a);
                connection.Open();
                DataSet ds = new DataSet();
                string come = ("Select * from [Authorization] where Login='" + textBox1.Text + "' and Password='" + textBox2.Text + "'");
                SqlDataAdapter b = new SqlDataAdapter(come, connection);
                b.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0 && textBox1.Text == "adm")
                {
                    MessageBox.Show("Здравствуйте, системный администратор!");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else if (ds.Tables[0].Rows.Count > 0 && textBox1.Text == "boss")
                {
                    MessageBox.Show("Здравствуйте, директор!");
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Дебич!");
                }

            }
        }
    }
}
