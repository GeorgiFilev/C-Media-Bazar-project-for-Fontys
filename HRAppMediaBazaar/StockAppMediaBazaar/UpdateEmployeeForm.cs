using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockAppMediaBazaar
{
    public partial class UpdateEmployeeForm : Form
    {
       EmployeeManagement empManagement = new EmployeeManagement();
        public UpdateEmployeeForm()
        {
            InitializeComponent();
            empManagement.UpdateEmployeeList();
            cmbWorkDays.DataSource = Enum.GetValues(typeof(Weekdays));
            cmbShift.DataSource = Enum.GetValues(typeof(ShiftType));          
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));
            FillListBox();
            lbEmployees.Items.Clear();
            lblError.Hide();
            lblListError.Hide();
            lblDep.Hide();
            foreach (string emp in empManagement.AllEmployees())
            {

                lbEmployees.Items.Add(emp);

            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FillListBox()
        {
            empManagement.UpdateDepartmentsList();
            lbDepartments.Items.Clear();
            foreach (string s in empManagement.GetDepartments())
            {
                lbDepartments.Items.Add(s);
            }
        }

        private void LbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = lbEmployees.SelectedItem.ToString();
                string idCut = id.Substring(1, 3);

                DisplayEmployeeDetails(idCut);
            }
            catch (Exception)
            {

                lblListError.Show();
                lblListError.Text = "Please select an employee";
            }
            
        }
        public void DisplayEmployeeDetails(string id)
        {
            List<string> details = new List<string>();
            details = empManagement.EmployeeDetails(id).ToList();
            foreach (string d in details)
            {
                
                tbFname.Text = details[1];
                tbLname.Text = details[2];
                tbAge.Text = details[3];
                cmbGender.Text = details[4];
                tbEmail.Text = details[5];
                mtbNumber.Text = details[6];
                tbBirthPlace.Text = details[7];
                mtbBirthday.Text = details[8];
                tbCity.Text = details[9];
                mtbZip.Text = details[10];
                tbAddress.Text = details[11];
                mtbSecurity.Text = details[12];
                tbNationality.Text = details[13];
                tbFTE.Text = details[14];
                mtbHired.Text = details[15];
                cmbWorkDays.Text = details[16];
                cmbShift.Text = details[17];
                lbDepartments.Text = details[22];


            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            empManagement.UpdateEmployeeList();
            lbEmployees.Items.Clear();
           

            if (tbSearch.Text == "")
            {
                foreach (string emp in empManagement.AllEmployees())
                {

                    lbEmployees.Items.Add(emp);

                }
            }
            else
            {
                foreach (string employee in empManagement.SearchEmployeeInListBox(tbSearch.Text))
                {
                    
                    lbEmployees.Items.Add(employee);
                }
            }
           
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
            try
            {
                string id = lbEmployees.SelectedItem.ToString();
                string idCut = id.Substring(1, 3);
                lblDep.Text = "";
                foreach (object department in lbDepartments.SelectedItems)
                {
                    //lblDep.Text = string.Join(",", department.ToString());
                     //lblDep.Text += string.Join(",", department.ToString());
                     lblDep.Text +=(lblDep.Text == "" ? "" : ",") + department.ToString();
                }
                empManagement.UpdateEmployeeInfo(idCut, tbFname.Text, tbLname.Text, Convert.ToInt32(tbAge.Text),
                    cmbGender.SelectedItem.ToString(), tbEmail.Text, mtbNumber.Text, tbBirthPlace.Text, mtbBirthday.Text, tbCity.Text,
                    mtbZip.Text, tbAddress.Text, mtbSecurity.Text, tbNationality.Text,
                    Convert.ToDouble(tbFTE.Text), mtbHired.Text, cmbWorkDays.SelectedItem.ToString(), cmbShift.SelectedItem.ToString(),
                    lblDep.Text);
                tbFname.Clear();
                tbLname.Clear();
                tbAge.Clear();
                tbEmail.Clear();
                mtbNumber.Clear();
                tbBirthPlace.Clear();
                mtbBirthday.Clear();
                tbCity.Clear();
                mtbZip.Clear();
                tbAddress.Clear();
                mtbSecurity.Clear();
                tbNationality.Clear();
                mtbHired.Clear();
            }
            catch (Exception exception)
            {
                lblError.Show();
                lblError.Text = "Make sure all fields are with correct values!";
            }
            
           
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void TbFname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFname.Text))
            {
                tbFname.ForeColor = Color.Red;
                errorProviderFName.SetError(tbFname, "Please enter your first name.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbFname.Text, "[ ^ 0-9]"))
            {
                tbFname.ForeColor = Color.Red;
                errorProviderFName.SetError(tbFname, "First name should not contain numbers!");
            }
            else
            {
                tbFname.ForeColor = Color.WhiteSmoke;
                errorProviderFName.Clear();
            }
        }

        private void TbLname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLname.Text))
            {
                tbLname.ForeColor = Color.Red;
                tbLname.Text = "Missing";
                errorProviderLName.SetError(tbLname, "Please enter your last name.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbLname.Text, "[ ^ 0-9]"))
            {
                tbLname.ForeColor = Color.Red;
                errorProviderLName.SetError(tbLname, "Last name should not contain numbers!");
            }
            else
            {
                tbLname.ForeColor = Color.WhiteSmoke;
                errorProviderLName.Clear();
            }
        }

        private void TbAge_Validating(object sender, CancelEventArgs e)
        {
            int i;
            if (string.IsNullOrEmpty(tbAge.Text))
            {
                tbAge.ForeColor = Color.Red;
                
                errorProviderAge.SetError(tbAge, "Please enter your age.");
            }
            else
            {
                tbAge.ForeColor = Color.WhiteSmoke;
                errorProviderAge.Clear();
            }
            if (!int.TryParse(tbAge.Text, out i))
            {
                tbAge.ForeColor = Color.Red;
                errorProviderAge.SetError(tbAge, "Age should not contain letters.");
            }
        }

        private void TbCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCity.Text))
            {
                errorProviderCity.SetError(tbCity, "Please enter your age.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCity.Text, "[ ^ 0-9]"))
            {
                tbCity.ForeColor = Color.Red;
                errorProviderCity.SetError(tbCity, "City should not contain numbers!");
            }
            else
            {
                tbCity.ForeColor = Color.WhiteSmoke;
                errorProviderCity.Clear();
            }
        }

        private void TbNationality_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationality.Text))
            {
               
                errorProviderNat.SetError(tbNationality, "Please enter your age.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbNationality.Text, "[ ^ 0-9]"))
            {
                tbNationality.ForeColor = Color.Red;
                errorProviderNat.SetError(tbNationality, "Nationality should not contain numbers!");
            }
            else
            {
                tbNationality.ForeColor = Color.WhiteSmoke;
                errorProviderNat.Clear();
            }
        }

        private void TbBirthPlace_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbBirthPlace.Text))
            {
                
                errorProviderBplace.SetError(tbBirthPlace, "Please enter your age.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbBirthPlace.Text, "[ ^ 0-9]"))
            {
                tbCity.ForeColor = Color.Red;
                errorProviderBplace.SetError(tbBirthPlace, "Birthplace should not contain numbers!");
            }
            else
            {
                tbBirthPlace.ForeColor = Color.WhiteSmoke;
                errorProviderCity.Clear();
            }
        }

        private void TbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
               
                errorProviderMail.SetError(tbEmail, "Please enter your email.");
            }
            if (!tbEmail.Text.Contains("@"))
            {
                tbEmail.ForeColor = Color.Red;
                errorProviderMail.SetError(tbEmail, "Please enter a valid email!");
            }
            else
            {
                tbEmail.ForeColor = Color.WhiteSmoke;
                errorProviderMail.Clear();
            }
        }

        private void TbFTE_Validating(object sender, CancelEventArgs e)
        {
            int i;
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbFTE.Text, "[ ^ 0-9]"))
            {
                tbFTE.ForeColor = Color.Red;
                errorProviderFTE.SetError(tbFTE, "Please enter a valid FTE.");
            }
            if(System.Text.RegularExpressions.Regex.IsMatch(tbFTE.Text, "[ ^ 0-9]"))
            {
                tbFTE.ForeColor = Color.WhiteSmoke;
                errorProviderFTE.Clear();
            }
            if (!int.TryParse(tbFTE.Text,out i ))
            {
                tbFTE.ForeColor = Color.Red;
                errorProviderFTE.SetError(tbFTE, "Please enter a valid FTE.");
            }
        }
        private void MtbHired_Validating(object sender, CancelEventArgs e)
        {

            if (!mtbHired.MaskCompleted)
            {
                errorProviderHired.SetError(mtbHired, "Please enter a hired date.");
            }
            else if (mtbHired.MaskCompleted)
            {
                errorProviderHired.Clear();
            }
        }
        private void MtbSecurity_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbSecurity.MaskCompleted)
            {
                errorProviderSecurity.SetError(mtbSecurity, "Please enter a valid security number.");
            }
            else if (mtbSecurity.MaskCompleted)
            {
                errorProviderSecurity.Clear();
            }
        }

        private void MtbZip_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbZip.MaskCompleted)
            {
                errorProviderZip.SetError(mtbZip, "Please enter a valid zip");
            }
            else if (mtbZip.MaskCompleted)
            {
                errorProviderZip.Clear();
            }
        }

        private void MtbBirthday_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbBirthday.MaskCompleted)
            {
                errorProviderBirthday.SetError(mtbBirthday, "Please enter a valid birthday");
            }
            else if (mtbBirthday.MaskCompleted)
            {
                errorProviderBirthday.Clear();
            }
        }

        private void MtbNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!mtbNumber.MaskCompleted)
            {
                errorProviderNumber.SetError(mtbNumber, "Please enter a phone number.");
            }
            else if (mtbNumber.MaskCompleted)
            {
                errorProviderNumber.Clear();
            }
        }
    }
}
