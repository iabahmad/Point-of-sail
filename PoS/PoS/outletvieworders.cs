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
    public partial class outletvieworders : MetroFramework.Forms.MetroForm
    {
        public outletvieworders()
        {
            InitializeComponent();
        }

        private void outletvieworders_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            outletinterface otv = new outletinterface();
            otv.Show();
            this.Hide();
        }
    }
}
