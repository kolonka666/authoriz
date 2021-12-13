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
    public partial class Form2 : Form
    {
        string a = @"Data Source=DESKTOP-A98NHE1\SQLEXPRESS;Initial Catalog=clothes_shop;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = "select * from [Order]";
            using (SqlConnection connection = new SqlConnection(a))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(b, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = "select * from Product";
            using (SqlConnection connection = new SqlConnection(a))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(b, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
