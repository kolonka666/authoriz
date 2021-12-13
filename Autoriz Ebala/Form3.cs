using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoriz_Ebala
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String str = @"Data Source=DESKTOP-A98NHE1\SQLEXPRESS;Initial Catalog=clothes_shop;Integrated Security=True";

            string g = Convert.ToString(comboBox1.SelectedItem);
            string d = "";
            switch (g)
            {
                case "Battles":
                    d = "use Ships Select * From Battles ";
                    break;
                case "Classes":
                    d = "use Ships Select * From Classes ";
                    break;
                case "Outcomes":
                    d = "use Ships Select * From Outcomes";
                    break;
                case "Ships":
                    d = "use Ships Select * From Ships";
                    break;

            }
        }
    }
}
