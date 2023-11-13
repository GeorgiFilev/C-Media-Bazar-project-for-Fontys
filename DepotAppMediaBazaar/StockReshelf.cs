using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepotAppMediaBazaar
{
    public partial class StockReshelf : Form
    {
        ReshelfRequest rr = new ReshelfRequest();
        public StockReshelf()
        {
            InitializeComponent();
            DisplayShelfRequests();
           
            
        }
        public void DisplayShelfRequests()
        {
            //pm.UpdateCurrentProductsFromDB();
            string[] reshelfRequests = rr.GetStockReshelfRequests();
            lbReshelfRequests.Items.Clear();
            foreach (string request in reshelfRequests)
            {
                lbReshelfRequests.Items.Add(request);
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendStock_Click(object sender, EventArgs e)
        {
            if(lbReshelfRequests.SelectedIndex == -1)
            {
                lbWarning.Text = "First, select a request.";
                lbWarning.Show();
            }
            else
            {
                string id = lbReshelfRequests.SelectedItem.ToString();
                string idCut = id.Substring(1, 2);
                rr.StockReshelf(idCut);
                DisplayShelfRequests();
                lbWarning.Hide();
                MessageBox.Show("Product has been reshelfed.");
            }
           
        }
    }
}
