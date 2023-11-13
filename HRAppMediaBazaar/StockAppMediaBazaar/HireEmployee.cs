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
    public partial class HireEmployee : Form
    {
        public HireEmployee()
        {
            InitializeComponent();
            cbGender.DataSource = Enum.GetValues(typeof(Gender));
            cmbShift.DataSource = Enum.GetValues(typeof(ShiftEnums));
            Array gender=Enum.GetValues(typeof(Gender));
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            
            string fName = tbFname.Text;
            string lName = tbLname.Text;
            int age = Convert.ToInt32(tbAge.Text);
            Gender gender=(Gender) cbGender.SelectedItem ;
            string email = tbEmail.Text;
            string phone = tbNumber.Text;
            string birthPlace = tbBirthplace.Text;
            string birthday = tbBirthday.Text;
            string city = tbCity.Text;
            int zipCode = Convert.ToInt32(tbZip.Text);
            string address = tbxAddress.Text;
            int securityNumber = Convert.ToInt32(tbSecurity.Text);
            string nationality = tbxNationality.Text;
            string Fte = tbFte.Text;
            string hiredDate = tbHired.Text;
            ShiftEnums shift = (ShiftEnums)cmbShift.SelectedItem;
            string preferredWorkDays = tbWorkDays.Text; ;

            SQLConnection connection = new SQLConnection();
            connection.EmployeeQuery(
                fName, lName, age, gender.ToString(), email, phone, birthPlace, birthday, city, zipCode, address, securityNumber, nationality, Fte, hiredDate,preferredWorkDays, shift.ToString());

            tbFname.Clear();
            tbLname.Clear();
            tbAge.Clear();
            tbEmail.Clear();
            tbNumber.Clear();
            tbBirthplace.Clear();
            tbBirthday.Clear();
            tbCity.Clear();
            tbZip.Clear();
            tbxAddress.Clear();
            tbSecurity.Clear();
            tbxNationality.Clear();
            tbFte.Clear();
            tbHired.Clear();
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

        }

        private void TbLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbWorkDays_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
