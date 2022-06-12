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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entlogin el = new entlogin();
            el.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            emplogin el = new emplogin();
            el.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            outlogin ol = new outlogin();
            ol.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            custlogin cl = new custlogin();
            cl.Show();
            this.Hide();
        }
    }
}
