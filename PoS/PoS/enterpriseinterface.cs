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
    public partial class enterpriseinterface : MetroFramework.Forms.MetroForm
    {
    
        public enterpriseinterface()
        {
            InitializeComponent();
        }

        private void enterpriseinterface_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eado ea = new eado();
            ea.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eaey ey = new eaey();
            ey.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evo ev = new evo();
            ev.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            evemp eve = new evemp();
            eve.Show();
            this.Hide();
        }
    }
}
