using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoS
{
    public partial class entlogin : MetroFramework.Forms.MetroForm
    {
        public entlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not allowed to enterprise kindly reach us as 0313-7552313");
        }

        private void entlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
