using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PoS
{
    public partial class emplogin : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-75IR95H\\SQLEXPRESS;Initial Catalog=PointofSale;Integrated Security=True");
        public emplogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

        private void emplogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from lgi where id = '" + textBox1.Text + "' and pass = '" + textBox2.Text + "'", con);
            int a = (int)cmd.ExecuteScalar();
            if (a > 0)
            {
                employeeinterface ef = new employeeinterface();
                ef.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid ceredentials...");
                con.Close();
            }
        
        }
    }
}
