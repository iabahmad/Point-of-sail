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
    public partial class evemp : MetroFramework.Forms.MetroForm
    {
        public evemp()
        {
            InitializeComponent();
        }

        private void evemp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            enterpriseinterface ef = new enterpriseinterface();
            ef.Show();
            this.Hide();
        }
    }
}
