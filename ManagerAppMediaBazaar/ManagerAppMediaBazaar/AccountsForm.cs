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
    public partial class AccountsForm : Form
    {
        EmployeeManager empMgr = new EmployeeManager();
        AccountManagement accMgm = new AccountManagement();
        public void DisplayEmployeesInListBox()
        {
            empMgr.UpdateEmployeeList();
            lbNoAcc.Items.Clear();
            lbAcc.Items.Clear();
            foreach (string acc in empMgr.GetNoAccounts())
            {
                lbNoAcc.Items.Add(acc);
            }
            foreach (string acc in empMgr.GetAccounts())
            {
                lbAcc.Items.Add(acc);
            }
        }
        public void FillComboBox()
        {
            accMgm.UpdateDepartmentsList();
            cmbDepartment.Items.Clear();
            foreach (string s in accMgm.GetDepartments())
            {
                cmbDepartment.Items.Add(s);
            }
        }
        public AccountsForm()
        {
            InitializeComponent();
            DisplayEmployeesInListBox();
            FillComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            empMgr.UpdateEmployeeList();
            lbNoAcc.Items.Clear();
            if (tbSearchNoAcc.Text == "")
            {
                DisplayEmployeesInListBox();
            }
            else
            {
                foreach (string emp in empMgr.SearchNoAccounts(tbSearchNoAcc.Text))
                {

                    lbNoAcc.Items.Add(emp);

                }
            }
           
        }
        private void tbSearchAcc_TextChanged(object sender, EventArgs e)
        {
            empMgr.UpdateEmployeeList();
            lbAcc.Items.Clear();
            if (tbSearchAcc.Text == "")
            {
                DisplayEmployeesInListBox();
            }
            else
            {
                foreach (string emp in empMgr.SearchAccounts(tbSearchAcc.Text))
                {

                    lbAcc.Items.Add(emp);

                }
            }
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {

        }

        private void lbNoAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNoAcc.SelectedIndex != -1)
            {
                lbAcc.SelectedIndex = -1;
                string id = lbNoAcc.SelectedItem.ToString();
                int idCut = Convert.ToInt32(id.Substring(0, 2));
                lblAddUpdate.Text = "Add Account";
                btnAddUpdate.Text = "Add";
                tbEmail.Text = empMgr.GetAccountInfo(idCut)[0];
                tbPassword1.Text = "";
                tbPassword2.Text = "";
                cmbDepartment.Text = empMgr.GetAccountInfo(idCut)[2];
            }
   
        }

        private void lbAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAcc.SelectedIndex != -1)
            {
                lbNoAcc.SelectedIndex = -1;
                string id = lbAcc.SelectedItem.ToString();
                int idCut = Convert.ToInt32(id.Substring(0, 2));
                lblAddUpdate.Text = "Update Account";
                btnAddUpdate.Text = "Update";
                tbEmail.Text = empMgr.GetAccountInfo(idCut)[0];
                tbPassword1.Text = empMgr.GetAccountInfo(idCut)[1];
                tbPassword2.Text = empMgr.GetAccountInfo(idCut)[1];
                cmbDepartment.Text = empMgr.GetAccountInfo(idCut)[2];
            }
            
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string email = tbEmail.Text;
                string password = tbPassword1.Text;
                string password2 = tbPassword2.Text;
                string role = cmbDepartment.Text;
                int idCut;
                if (lbNoAcc.SelectedIndex > -1)
                {
                    string id = lbNoAcc.SelectedItem.ToString();
                    idCut = Convert.ToInt32(id.Substring(0, 2));
                }
                else if (lbAcc.SelectedIndex > -1)
                {
                    string id = lbAcc.SelectedItem.ToString();
                    idCut = Convert.ToInt32(id.Substring(0, 2));
                }
                else
                {
                    MessageBox.Show("Please select an employee!");
                    idCut = 0;
                }
                if (password == password2 && password.Length > 1 )
                {
                    accMgm.UpdateAccount(idCut, email, password, role);
                    MessageBox.Show("Account successfully updated!");
                    email = "";
                    password = "";
                    password2 = "";
                    role = "";
                    lbAcc.SelectedIndex = -1;
                    lbNoAcc.SelectedIndex = -1;
                    DisplayEmployeesInListBox();
                    FillComboBox();
                }
                else
                    MessageBox.Show("Password can not be empty!");
            }
            catch(Exception exc) {
                MessageBox.Show("Make sure all fields are filled in correctly!");
            }
            

           
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void revealPass_MouseHover(object sender, EventArgs e)
        {
            tbPassword1.UseSystemPasswordChar = false;
            revealPass.IconColor = Color.FromArgb(237, 0, 140);
        }

        private void revealPass_MouseLeave(object sender, EventArgs e)
        {
            tbPassword1.UseSystemPasswordChar = true;
            revealPass.IconColor = Color.White;
        }

        

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {

                errorProviderMail.SetError(tbEmail, "Please enter your email.");
                btnAddUpdate.Enabled = false;
            }
            if (!tbEmail.Text.Contains("@"))
            {
                tbEmail.ForeColor = Color.Red;
                errorProviderMail.SetError(tbEmail, "Please enter a valid email!");
                btnAddUpdate.Enabled = false;
            }
            else
            {
                tbEmail.ForeColor = Color.WhiteSmoke;
                errorProviderMail.Clear();
                btnAddUpdate.Enabled = true;
            }
        }

        private void tbPassword1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword1.Text))
            {

                errorProviderPassword1.SetError(tbPassword1, "Please enter a password!");
                btnAddUpdate.Enabled = false;
            }
            else if (tbPassword1.Text != tbPassword2.Text)
            {
                tbPassword1.ForeColor = Color.Red;
                errorProviderPassword1.SetError(tbPassword1, "Passwords do not match!");
                btnAddUpdate.Enabled = false;
            }
            else
            {
                tbPassword1.ForeColor = Color.WhiteSmoke;
                tbPassword2.ForeColor = Color.WhiteSmoke;
                errorProviderPassword1.Clear();
                errorProviderPassword2.Clear();
                btnAddUpdate.Enabled = true;
            }

        }

        private void tbPassword2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword2.Text))
            {

                errorProviderPassword2.SetError(tbPassword2, "Please enter a password!");
                btnAddUpdate.Enabled = false;
            }
            else if (tbPassword1.Text != tbPassword2.Text)
            {
                tbPassword2.ForeColor = Color.Red;
                errorProviderPassword2.SetError(tbPassword2, "Passwords do not match!");
                btnAddUpdate.Enabled = false;
            }
            else
            {
                tbPassword1.ForeColor = Color.WhiteSmoke;
                tbPassword2.ForeColor = Color.WhiteSmoke;
                errorProviderPassword1.Clear();
                errorProviderPassword2.Clear();
                btnAddUpdate.Enabled = true;
            }
        }

        private void cmbDepartment_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(cmbDepartment.Text))
            {

                errorProviderRole.SetError(cmbDepartment, "Company role can not be empty!");
                btnAddUpdate.Enabled = false;
            }
            else
            {
                errorProviderRole.Clear();
                btnAddUpdate.Enabled = true;
            }
        }
    }
}
