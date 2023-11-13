using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerAppMediaBazaar
{
    public partial class Home : Form
    {
        private Form closeForm = null;
        EmployeeManager empMan = new EmployeeManager();

        public void CustomTab(Form childForm)
        {
            if (closeForm != null)
            {
                closeForm.Close();
            }
            
                closeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelFill.Controls.Add(childForm);
                panelFill.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                
            
        }
        public Home(string email)
        {
            InitializeComponent();
            lblUser.Text = empMan.GetName(email);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateTime time = DateTime.Now;

            this.labelDate.Text = date.ToLongDateString();
            this.labelTime.Text = time.ToLongTimeString();
        }

        

        private void btnCompanyGrowth_Click(object sender, EventArgs e)
        {
            CustomTab(new AccountsForm());
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            CustomTab(new ContractsForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            CustomTab(new DepartmentsForm());
        }
    }
}
