using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockAppMediaBazaar
{
    public partial class HR : Form
    {

        public HR()
        {
           InitializeComponent();
           HideSubMenu();

        }

        private void HideSubMenu()
        {
            panelSubEmp.Visible = false;
            panelSubShift.Visible = false;
            panelSubContract.Visible = false;

        }

        private void ShowSubMenu(Panel submenu)
        {
            if (panelSubEmp.Visible == false)
            {

                panelSubEmp.Visible = true;
            }
            else
            {
                panelSubEmp.Visible = false;
            }
        }

        private void ShowSubMenuShift(Panel submenu)
        {
            if (panelSubShift.Visible == false)
            {

                panelSubShift.Visible = true;
            }
            else
            {
                panelSubShift.Visible = false;
            }
        }

        private void ShowSubMenuContract(Panel submenu)
        {
            if (panelSubContract.Visible == false)
            {

                panelSubContract.Visible = true;
            }
            else
            {
                panelSubContract.Visible = false;
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            ShowSubMenuShift(panelSubShift);
           
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form closeForm = null;
        private void OpenNewForm(Form childForm)
        {
                if (closeForm!=null)

                closeForm.Close();
                closeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel2.Controls.Add(childForm);
                panel2.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            
        }
        private void IconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void IconButton4_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelSubEmp);
            
        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            ShowSubMenuContract(panelSubContract);
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            DateTime time=DateTime.Now;

            this.label2.Text = date.ToLongDateString();
            this.labelTime.Text = time.ToLongTimeString();
        }

        private void HR_Load(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void LblUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenNewForm(new HireEmployeeForm());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenNewForm(new EmployeeDetailsForm());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ContractsForm());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ShiftFormCreate());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenNewForm(new UpdateEmployeeForm());
        }

        private void HR_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnSignOut_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
           login.Show();
            this.Hide();
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            OpenNewForm(new UpdateEmployeeForm());
        }

        private void BtnOverview_Click(object sender, EventArgs e)
        {
            OpenNewForm(new ShiftsOverview());
        }

        private void PanelMenuBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
