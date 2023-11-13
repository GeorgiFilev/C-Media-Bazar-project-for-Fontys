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
    public partial class ContractsForm : Form
    {
        EmployeeManager empMan= new EmployeeManager();

        public void ViewEmpRequestInLb() 
        {
            empMan.UpdateEmployeeList();
            lbEmployment.Items.Clear();
            foreach (string s in empMan.ViewEmploymentRequest())
            {
                lbEmployment.Items.Add(s);
            }
        }
        public void ViewTermRequestInLb()
        {
            empMan.UpdateEmployeeList();
            lbContracts.Items.Clear();
            foreach (string s in empMan.ViewTerminationRequest())
            {
                lbContracts.Items.Add(s);
            }
        }
        public ContractsForm()
        {
            InitializeComponent();
            ViewEmpRequestInLb();
            ViewTermRequestInLb();
        }
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (lbEmployment.SelectedIndex > -1)
            {
                string id = lbEmployment.SelectedItem.ToString();
                string idCut = id.Substring(0, 2);
                empMan.ApproveEmploymentRequest(idCut);
                ViewEmpRequestInLb();
            }
            else
            {
                MessageBox.Show("Please select an employee ");
            }

        }
        private void btnConfirmFire_Click(object sender, EventArgs e)
        {
            if (lbContracts.SelectedIndex > -1)
            {
                string id = lbContracts.SelectedItem.ToString();
                string idCut = id.Substring(0, 2);
                empMan.TerminateEmployee(idCut);
                ViewTermRequestInLb();
            }
            else
            {
                MessageBox.Show("Please select an employee ");
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbContracts.SelectedIndex != -1)
            {
                string id = lbContracts.SelectedItem.ToString();
                string idCut = id.Substring(0, 2);
                tbReason.Text = "";
                tbReason.Text = empMan.ViewTerminationReason(idCut);
            }
            
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            if (lbEmployment.SelectedIndex > -1)
            {
                string id = lbEmployment.SelectedItem.ToString();
                string idCut = id.Substring(0, 2);
                empMan.DenyEmploymentRequest(idCut);
                ViewEmpRequestInLb();
            }
            else
            {
                MessageBox.Show("Please select an employee ");
            }
           
        }

        private void btnDenyTermination_Click(object sender, EventArgs e)
        {
            if (lbContracts.SelectedIndex > -1)
            {
                string id = lbContracts.SelectedItem.ToString();
                string idCut = id.Substring(0, 2);
                empMan.DenyTerminationRequest(idCut);
                ViewTermRequestInLb();
            }
            else
            {
                MessageBox.Show("Please select an employee ");
            }

        }

        private void Contracts_Load(object sender, EventArgs e)
        {

        }
    }
}
