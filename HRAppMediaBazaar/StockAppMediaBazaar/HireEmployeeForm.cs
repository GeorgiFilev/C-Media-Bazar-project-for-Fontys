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
    public partial class HireEmployeeForm : Form
    {

        EmployeeManagement employeeManagement = new EmployeeManagement();
        public HireEmployeeForm()
        {
            InitializeComponent();
            FillListBox();
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cmbShift.DataSource = Enum.GetValues(typeof(ShiftType));
            cmbWorkDays.DataSource = Enum.GetValues(typeof(Weekdays));            
            Array gender=Enum.GetValues(typeof(Gender));
            lblError.Hide();
            lblDep.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            //try
            //{
                string fName = tbFname.Text;
                string lName = tbLname.Text;
                int age = Convert.ToInt32(tbAge.Text);
                Gender gender = (Gender)cbGender.SelectedItem;
                string email = tbEmail.Text;
                string phone = mtbNumber.Text;
                string birthPlace = tbBirthplace.Text;
                string birthday = mtbBirthday.Text;
                string city = tbCity.Text;
                string zipCode =mtbZip.Text;
                string address = tbxAddress.Text;
                string securityNumber = mtbSecurity.Text;
                string nationality = tbxNationality.Text;
                double Fte = Convert.ToDouble(tbFte.Text);
                string hiredDate = mtbHired.Text;
                ShiftType shift = (ShiftType)cmbShift.SelectedItem;
                Weekdays preferredWorkDays = (Weekdays)cmbWorkDays.SelectedItem;
                string compRole= "";             
               foreach(object department in lbDepartments.SelectedItems)
               {
                    compRole += department.ToString() + (lblDep.Text == "" ? "" : ",");
               }
                

                employeeManagement.AddEmployeeToDb(fName, lName, age, gender, email, phone, birthPlace, birthday, city, zipCode, address, securityNumber, nationality, Fte, hiredDate, preferredWorkDays, shift, compRole);

                tbFname.Clear();
                tbLname.Clear();
                tbAge.Clear();
                tbEmail.Clear();
                mtbNumber.Clear();
                tbBirthplace.Clear();
                mtbBirthday.Clear();
                tbCity.Clear();
                mtbZip.Clear();
                tbxAddress.Clear();
                mtbSecurity.Clear();
                tbxNationality.Clear();
                tbFte.Clear();
                mtbHired.Clear();
           // }
           // catch (Exception exception)
            //{
              //  lblError.Show();
              //  lblError.Text = "Make sure all fields are filled in correctly";
            //}
                
        }
        public void FillListBox()
        {
            employeeManagement.UpdateDepartmentsList();
            lbDepartments.Items.Clear();
            foreach (string s in employeeManagement.GetDepartments())
            {
                lbDepartments.Items.Add(s);
            }
        }

        private void HireEmployee_Load(object sender, EventArgs e)
        {
           
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbBirthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbSecurity_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbFte_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbFte.Text, "[ ^ 0-9]"))
            {
                tbFte.ForeColor = Color.Red;
                errorProviderFTE.SetError(tbFte, "Please enter a valid FTE.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbFte.Text, "[ ^ 0-9]"))
            {
                tbFte.ForeColor = Color.WhiteSmoke;
                errorProviderFTE.Clear();
            }
            if (!int.TryParse(tbFte.Text, out i))
            {
                tbFte.ForeColor = Color.Red;
                errorProviderFTE.SetError(tbFte, "Please enter a valid FTE.");
            }
        }

        private void TbLname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLname.Text))
            {

                errorProviderLName.SetError(tbLname, "Please enter your last name.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbLname.Text, "[ ^ 0-9]"))
            {
                tbLname.ForeColor = Color.Red;
                errorProviderLName.SetError(tbLname, "Last name should not contain numbers!");
            }
            else if (!string.IsNullOrWhiteSpace(tbLname.Text))
            {
                tbLname.ForeColor = Color.WhiteSmoke;
                errorProviderLName.Clear();
            }
        }

        private void TbWorkDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbFname_Validating(object sender, CancelEventArgs e)
        {
            
            
        }
        private void TbFname_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFname.Text))
            {

                errorProviderFName.SetError(tbFname, "Please enter your first name.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbFname.Text, "[ ^ 0-9]"))
            {
                tbFname.ForeColor = Color.Red;
                errorProviderFName.SetError(tbFname, "First name should not contain numbers!");
            }
            else if (!string.IsNullOrWhiteSpace(tbFname.Text))
            {
                tbFname.ForeColor = Color.WhiteSmoke;
                errorProviderFName.Clear();
            }
        }

        private void TbLname_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TbFte_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
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

        private void TbEmail_Validating(object sender, CancelEventArgs e)
        {
          
        }
        private void TbAge_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TbCity_Validating(object sender, CancelEventArgs e)
        {
            
           
        }

        private void TbxNationality_Validating(object sender, CancelEventArgs e)
        {
            
            
        }

        private void TbBirthplace_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void TbxAddress_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void MtbHired_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void MtbNumber_Validating(object sender, CancelEventArgs e)
        {
            
        }
        private void MtbZip_Validating(object sender, CancelEventArgs e)
        {
           
        }
        private void MtbBirthday_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void MtbSecurity_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TbCity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCity.Text))
            {

                errorProviderCity.SetError(tbCity, "Please enter your city.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCity.Text, "[ ^ 0-9]"))
            {
                tbCity.ForeColor = Color.Red;
                errorProviderCity.SetError(tbCity, "City should not contain numbers!");
            }
            else if (!string.IsNullOrWhiteSpace(tbCity.Text))
            {
                tbCity.ForeColor = Color.WhiteSmoke;
                errorProviderCity.Clear();

            }
        }

        private void TbxAddress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxAddress.Text))
            {
                errorProviderAddress.SetError(tbxAddress, "Please enter your address");
            }
            else if (!string.IsNullOrWhiteSpace(tbxAddress.Text))
            {
                errorProviderAddress.Clear();
            }
        }

        private void MtbSecurity_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtbSecurity_TextChanged(object sender, EventArgs e)
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

        private void MtbBirthday_TextChanged(object sender, EventArgs e)
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

        private void MtbZip_TextChanged(object sender, EventArgs e)
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

        private void MtbNumber_TextChanged(object sender, EventArgs e)
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

        private void TbxNationality_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNationality.Text))
            {

                errorProviderNat.SetError(tbxNationality, "Please enter your nationality.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbxNationality.Text, "[ ^ 0-9]"))
            {
                tbxNationality.ForeColor = Color.Red;
                errorProviderNat.SetError(tbxNationality, "Nationality should not contain numbers!");
            }
            else if (!string.IsNullOrWhiteSpace(tbxNationality.Text))
            {
                tbxNationality.ForeColor = Color.WhiteSmoke;
                errorProviderNat.Clear();
            }
        }

        private void MtbHired_TextChanged(object sender, EventArgs e)
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

        private void TbBirthplace_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBirthplace.Text))
            {

                errorProviderBplace.SetError(tbBirthplace, "Please enter your birthplace.");
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbBirthplace.Text, "[ ^ 0-9]"))
            {
                tbCity.ForeColor = Color.Red;
                errorProviderBplace.SetError(tbBirthplace, "Birthplace should not contain numbers!");
            }
            else if (!string.IsNullOrWhiteSpace(tbBirthplace.Text))
            {
                tbBirthplace.ForeColor = Color.WhiteSmoke;
                errorProviderCity.Clear();
            }
        }

        private void TbAge_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (string.IsNullOrEmpty(tbAge.Text))
            {

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
    }
}
