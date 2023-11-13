using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepotAppMediaBazaar
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LabelTime_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateTime time = DateTime.Now;

            this.labelTime2.Text = date.ToLongDateString();
            this.labelDate.Text = time.ToLongTimeString();
        }

        private void Home_LocationChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
