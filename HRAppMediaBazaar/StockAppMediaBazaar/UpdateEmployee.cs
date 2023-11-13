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
    public partial class UpdateEmployee : Form
    {
        SQLConnection connection = new SQLConnection();
        public UpdateEmployee()
        {
            InitializeComponent();
            connection.ViewEmployeeInListBox(lbEmployees);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = lbEmployees.SelectedItem.ToString();
            string idCut = id.Substring(0, 2);
            connection.ShowDetailsUpdate(idCut, tbFname, tbLname, tbAge, tbGender, tbEmail,
                tbNumber,tbBirthPlace , tbBirthday, tbCity, tbZip, tbAddress, tbSecurity, tbNationality, tbHiredDate,
                tbWorkDays,tbShift );
            connection.CloseConnection();
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            connection.SearchEmployeeInListBox(lbEmployees, tbSearch.Text);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string id = lbEmployees.SelectedItem.ToString();
            string idCut = id.Substring(0, 2);
            connection.UpdateEmployeeInformation(idCut,tbFname.Text,tbLname.Text,Convert.ToInt32(tbAge.Text),tbGender.Text,tbEmail.Text,tbNumber.Text,tbBirthPlace.Text,tbBirthday.Text,tbCity.Text, Convert.ToInt32(tbZip.Text),tbAddress.Text, Convert.ToInt32(tbSecurity.Text),tbNationality.Text,tbFTE.Text,tbHiredDate.Text,tbWorkDays.Text,tbShift.Text);

            tbFname.Clear();
            tbLname.Clear();
            tbAge.Clear();
            tbGender.Clear();
            tbEmail.Clear();
            tbNumber.Clear();
            tbBirthPlace.Clear();
            tbBirthday.Clear();
            tbCity.Clear();
            tbZip.Clear();
            tbAddress.Clear();
            tbSecurity.Clear();
            tbNationality.Clear();
            tbHiredDate.Clear();
            tbWorkDays.Clear();
            tbShift.Clear();

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
