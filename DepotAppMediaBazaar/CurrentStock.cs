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
    
    public partial class CurrentStock : Form
    {
        
        ProductManagement pm = new ProductManagement();
        public CurrentStock()
        {
            InitializeComponent();
            FillComboBox();
        }
        public void FillComboBox()
        {
            pm.UpdateDepartmentsList();
            cmbDepartments.Items.Clear();
            foreach (string s in pm.GetDepartments())
            {
                cmbDepartments.Items.Add(s);
            }
        }
        public void DisplayCurrentProducts()
        {
            pm.UpdateCurrentProductsFromDB();
            string[] currentProducts = pm.CurrentProducts();
            listBox1.Items.Clear();
            foreach (string product in currentProducts)
            {
                listBox1.Items.Add(product);
            }
        }

        private void BtnGoBack_MouseEnter(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CurrentStock_Activated(object sender, EventArgs e)
        {
            
        }

        private void CurrentStock_Load(object sender, EventArgs e)
        {
            DisplayCurrentProducts();       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listBox1.SelectedItem.ToString();
            string idCut = id.Substring(0, 2);
            string[] details = pm.GetCurrentProductDetails(idCut);
            lbShowType.Text = details[1];
            lbShowName.Text = details[2];
            lbShowModel.Text = details[3];
            lbShowQuantity.Text = details[4];
            lbShowDepartment.Text = details[5];

        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string department = cmbDepartments.SelectedItem.ToString().Trim();
            Product[] productDetails = pm.GetCurrentProductsPerDepartment(department);
            listBox1.Items.Clear();
            foreach (Product product in productDetails)
            {
                listBox1.Items.Add(product.ID.ToString() + " " + product.name + " " + product.model);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            rbtnAvailable.Checked = false;
            rbtnUnavailable.Checked = false;
            DisplayCurrentProducts();
           
        }

        private void rbtnAvailable_CheckedChanged(object sender, EventArgs e)
        {
            Product[] availableProducts = pm.GetAvailableProducts();
            listBox1.Items.Clear();
            foreach (Product product in availableProducts)
            {
                listBox1.Items.Add(product.ID.ToString() + " " + product.name + " " + product.model);
            }
        }

        private void rbtnUnavailable_CheckedChanged(object sender, EventArgs e)
        {
            Product[] unavailableProducts = pm.GetUnavailableProducts();
            listBox1.Items.Clear();
            foreach (Product product in unavailableProducts)
            {
                listBox1.Items.Add(product.ID.ToString() + " " + product.name + " " + product.model);
            }
        }
    }
}
