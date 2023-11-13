using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAppMediaBazaar
{
    public partial class Form1 : Form
    {
        SqlManager conn = new SqlManager();
        public Form1(string email)
        {
            InitializeComponent();
            lblUser.Text = conn.GetName(email);
        }
        private Form salesForm = null;
        private void OpenSalesForm(Form childForm)
        {
            if (salesForm != null)
                salesForm.Close();
            salesForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelScreen.Controls.Add(childForm);
            panelScreen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void panelScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            OpenSalesForm(new SalesForm());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateTime time = DateTime.Now;

            this.lblDate.Text = date.ToLongDateString();
            this.lblTime.Text = time.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
