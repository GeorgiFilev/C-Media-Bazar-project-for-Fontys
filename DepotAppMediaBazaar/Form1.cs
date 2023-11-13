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
    public partial class Form1 : Form
    {
        ProductManagement pm = new ProductManagement();
        public Form1(string email)
        {
            InitializeComponent();
            lblUser.Text = pm.GetName(email);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form closeForm = null;
        private void CloseForm(Form childForm)
        {
            if (closeForm != null)
            {
                closeForm.Close();
            }
            closeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
       private void IconButton4_Click(object sender, EventArgs e)
        {
            CloseForm(new CurrentStock());
            
        }

        private void LblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            CloseForm(new StockReshelf());
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            panel5.Controls.Clear();
            Home myForm = new Home();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel5.Controls.Add(myForm);
            myForm.BringToFront();
            myForm.Show();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            CloseForm(new AddProducts()); 
        }

        private void IconButtonHome_Click(object sender, EventArgs e)
        {
            CloseForm(new Home());
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void iconButtonSignOut_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButtonUpdateProduct_Click(object sender, EventArgs e)
        {
            CloseForm(new UpdateProducts());
        }
    }
}
