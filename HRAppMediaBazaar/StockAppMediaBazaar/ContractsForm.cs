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
    public partial class ContractsForm : Form
    {
       // SqlConnection connection=new SqlConnection();
        EmployeeManagement employeeManagement = new EmployeeManagement();
        public void DisplayEmployeeInListBox()
        {
            employeeManagement.UpdateEmployeeList();

            lbTermRequest.Items.Clear();
            foreach (string emp in employeeManagement.AllEmployees())
            {

                lbTermRequest.Items.Add(emp);

            }
        }
        public ContractsForm()
        {
            InitializeComponent();
            DisplayEmployeeInListBox();
            lblError.Hide();
            //connection.ViewEmployeeInListBox(lbTermRequest);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            employeeManagement.UpdateEmployeeList();
            lbTermRequest.Items.Clear();

            if (tbRequest.Text == "")
            {
                DisplayEmployeeInListBox();
            }
            else
            {
                foreach (string emp in employeeManagement.SearchEmployeeInListBox(tbRequest.Text))
                {
                    lbTermRequest.Items.Add(emp);
                }
            }
           // connection.SearchEmployeeInListBox(lbTermRequest, tbRequest.Text);
        }

        private void BtnTermRequest_Click(object sender, EventArgs e)
        {
            try
            {  
                    string id = lbTermRequest.SelectedItem.ToString();
                    string idCut = id.Substring(1, 2);

                    employeeManagement.SendTerminationRequest(idCut);
                    employeeManagement.SendTerminationReason(idCut, tbReason.Text);

                    tbReason.Clear();
                    MessageBox.Show("Successfully sent.");
                
               
            }
            catch (Exception exception)
            {
                lblError.Show();
                lblError.Text = "Please select an employee";
            }
           
            
           
        }

        private void TbReason_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbReason.Text))
            {

                errorProvider1.SetError(tbReason, "Please enter your first name.");
            }
            else if (!string.IsNullOrWhiteSpace(tbReason.Text))
            {
                tbReason.ForeColor = Color.WhiteSmoke;
                errorProvider1.Clear();
            }
        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
