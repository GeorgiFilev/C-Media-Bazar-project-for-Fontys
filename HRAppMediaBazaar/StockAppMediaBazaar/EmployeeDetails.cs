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
    public partial class EmployeeDetails : Form
    {
        SQLConnection connection = new SQLConnection();
        public EmployeeDetails()
        {
            InitializeComponent();
           
           connection.ViewEmployeeInListBox(lbSearch);
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
            string id = lbSearch.SelectedItem.ToString();
            string idCut = id.Substring(0, 2);
            connection.ShowDetails(idCut,lblid, lblFirstName, lblLastName, lblAge, lblGender,
                lblEmail, lblNumber, lblBirth, lblBirthday, lblCity, lblZip, lblAddress, lblSecurity, lblNationality,lblFte,
                lblHired, lblPrefer);

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

            connection.CloseConnection();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            connection.SearchEmployeeInListBox(lbSearch,tbSearch.Text);
        }
    }
}
