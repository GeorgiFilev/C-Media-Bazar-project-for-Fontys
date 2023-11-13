using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StockAppMediaBazaar
{
    public partial class EmployeeDetailsForm : Form
    {
        private EmployeeManagement employeeManagement=new EmployeeManagement(); 
        public void DisplayEmployeeInListBox()
        {
            employeeManagement.UpdateEmployeeList();

            lbEmployees.Items.Clear();
            foreach (string emp in employeeManagement.AllEmployees())
            {

                lbEmployees.Items.Add(emp);

            }
        }
        public void DisplayEmployeeDetails(string id)
        {
            /* connection.ShowDetails(idCut,lblid, lblFirstName, lblLastName, lblAge, lblGender,
                lblEmail, lblNumber, lblBirth, lblBirthday, lblCity, lblZip, lblAddress, lblSecurity, lblNationality,lblFte,
                lblHired, lblPrefer);*/
            List<string> details = new List<string>();
                details = employeeManagement.EmployeeDetails(id).ToList();
            foreach (string d in details )
            {
               lblid.Text = details[0];
               lblFirstName.Text = details[1];
               lblLastName.Text = details[2];
               lblAge.Text = details[3];
               lblGender.Text = details[4];
               lblEmail.Text = details[5];
               lblNumber.Text = details[6];
               lblBirth.Text = details[7];
               lblBirthday.Text = details[8];
               lblCity.Text = details[9];
               lblZip.Text = details[10];
               lblAddress.Text = details[11];
               lblSecurity.Text = details[12];
               lblNationality.Text = details[13];
               lblFte.Text = details[14];
               lblHired.Text = details[15];
               lblPrefer.Text = details[16];
               lblShift.Text = details[17];
               lblRole.Text = details[22];


            }
        }
        public EmployeeDetailsForm()
        {
            InitializeComponent();
            DisplayEmployeeInListBox();

            //  connection.ViewEmployeeInListBox(lbSearch);
           lblid.Hide();
           lblFirstName.Hide();
           lblLastName.Hide();
           lblAge.Hide();
           lblGender.Hide();
           lblEmail.Hide();
           lblNumber.Hide();
           lblBirth.Hide();
           lblBirthday.Hide();
           lblCity.Hide();
           lblZip.Hide();
           lblAddress.Hide();
           lblSecurity.Hide();
           lblNationality.Hide();
           lblFte.Hide();
           lblHired.Hide();
           lblPrefer.Hide();
           lblShift.Hide();
           lblRole.Hide();

            lblError.Hide();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            

        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            
        }

        private void LbAge_Click(object sender, EventArgs e)
        {

        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = lbEmployees.SelectedItem.ToString();
                string idCut = id.Substring(1, 3);

                DisplayEmployeeDetails(idCut);

                lblid.Show();
                lblFirstName.Show();
                lblLastName.Show();
                lblAge.Show();
                lblGender.Show();
                lblEmail.Show();
                lblNumber.Show();
                lblBirth.Show();
                lblBirthday.Show();
                lblCity.Show();
                lblZip.Show();
                lblAddress.Show();
                lblSecurity.Show();
                lblNationality.Show();
                lblFte.Show();
                lblHired.Show();
                lblPrefer.Show();
                lblShift.Show();
                lblRole.Show();

            }
            catch (Exception)
            {

                lblError.Show();
                lblError.Text = "Please select an employee";
            }
            
            //connection.CloseConnection();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           employeeManagement.UpdateEmployeeList();
           lbEmployees.Items.Clear();
           if (tbSearch.Text == "")
           {
               DisplayEmployeeInListBox();
           }
           else
           {
               foreach (string emp in employeeManagement.SearchEmployeeInListBox(tbSearch.Text))
               {
                   lbEmployees.Items.Add(emp);
               }
           }
            // connection.SearchEmployeeInListBox(lbSearch,tbSearch.Text);
        }
    }
}
