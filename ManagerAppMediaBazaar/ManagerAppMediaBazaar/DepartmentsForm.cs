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
    public partial class DepartmentsForm : Form
    {
        AccountManagement accMgm = new AccountManagement();
        public void DisplayDepartmentsInListBox()
        {
            accMgm.UpdateDepartmentsList();
            lbAvailable.Items.Clear();
            lbDeleted.Items.Clear();
            foreach (string d in accMgm.GetDepartments())
            {
                lbAvailable.Items.Add(d);
            }
            foreach (string d in accMgm.GetDeletedDepartments())
            {
                lbDeleted.Items.Add(d);
            }
        }
        public DepartmentsForm()
        {
            InitializeComponent();
            DisplayDepartmentsInListBox();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAvailable.SelectedIndex != -1)
            {
                lbDeleted.SelectedIndex = -1;
                tbName.Text = lbAvailable.SelectedItem.ToString();
            }
        }

        private void lbDeleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDeleted.SelectedIndex != -1)
            {
                lbAvailable.SelectedIndex = -1;
                tbName.Text = lbDeleted.SelectedItem.ToString();
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (lbAvailable.Items.Contains(tbName.Text) || lbDeleted.Items.Contains(tbName.Text))
            {
                MessageBox.Show("Department already exists!");
            }
            else
            {
                if (cbAvailable.Checked)
                {
                    accMgm.AddDepartment(tbName.Text, 1);
                }
                else
                {
                    accMgm.AddDepartment(tbName.Text, 0);
                }
                DisplayDepartmentsInListBox();
                tbName.Text = "";
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string department = "";
            if (lbAvailable.SelectedIndex != -1)
            {
               department = lbAvailable.SelectedItem.ToString();
            }
            if (lbDeleted.SelectedIndex != -1)
            {
                department = lbDeleted.SelectedItem.ToString();
            }
            if (cbAvailable.Checked)
            {
                accMgm.UpdateDepartment(tbName.Text, department, 1);
            }
            else
            {
                accMgm.UpdateDepartment(tbName.Text, department, 0);
            }
            DisplayDepartmentsInListBox();
            tbName.Text = "";
            
            
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {

                errorProviderName.SetError(tbName, "Name can not be empty!");
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
            }
            if (!tbName.Text.Contains("Sales") && !tbName.Text.Contains("HR") && !tbName.Text.Contains("Manager") && !tbName.Text.Contains("Depot"))
            {
                tbName.ForeColor = Color.Red;
                errorProviderName.SetError(tbName, "Name must contain 'Sales', 'HR', 'Manager' or 'Depot'!");
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                tbName.ForeColor = Color.WhiteSmoke;
                errorProviderName.Clear();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }
    }
}
