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
    public partial class Contracts : Form
    {
        SQLConnection connection=new SQLConnection();
        public Contracts()
        {
            InitializeComponent();

            connection.ViewEmployeeInListBox(lbTermRequest);

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
            connection.SearchEmployeeInListBox(lbTermRequest, tbRequest.Text);
        }

        private void BtnTermRequest_Click(object sender, EventArgs e)
        {
            string id = lbTermRequest.SelectedItem.ToString();
            string idCut = id.Substring(0, 2);
            connection.SendTerminationRequest(idCut);
            connection.SendTerminationReason(idCut, tbReason.Text);
            MessageBox.Show("Successfully sent.");
        }

        private void TbReason_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
