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
    public partial class UpdateProducts : Form
    {
        ProductManagement pm = new ProductManagement();
        public UpdateProducts()
        {
            InitializeComponent();
            FillComboBox();
        }
        public void DisplayCurrentProducts()
        {
            string[] pendingProducts = pm.CurrentProducts();
            lblCurrentProducts.Items.Clear();
            foreach (string product in pendingProducts)
            {
                lblCurrentProducts.Items.Add(product);
            }
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

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            DisplayCurrentProducts();
        }

        private void lblCurrentProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = lblCurrentProducts.SelectedItem.ToString();
            string idCut = id.Substring(0, 2);
            string[] details = pm.GetCurrentProductDetails(idCut);
            tbType.Text = details[1];
            tbName.Text = details[2];
            tbModel.Text = details[3];
            tbQuantity.Text = details[4];
            tbDepartment.Text = details[5];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {      
            if(lblCurrentProducts.SelectedIndex == -1)
            {
                lbWarning.Text = "Select a product first.";
                lbWarning.Show();
            }
            else
            {
                string id = lblCurrentProducts.SelectedItem.ToString();
                string idCut = id.Substring(0, 2);
                string type = tbType.Text;
                string model = tbModel.Text;
                string name = tbName.Text;
                int quantity = Convert.ToInt32(tbQuantity.Text);
                string department = tbDepartment.Text;
                pm.UpdateProducts(idCut, type, model, name, quantity, department);
                DisplayCurrentProducts();
                MessageBox.Show("Selected product has been updated.");
                lbWarning.Hide();
            }
        }

        private void cmbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            string department = cmbDepartments.SelectedItem.ToString().Trim();
            Product[] productDetails = pm.GetCurrentProductsPerDepartment(department);
            lblCurrentProducts.Items.Clear();
            foreach (Product product in productDetails)
            {
                lblCurrentProducts.Items.Add(product.ID.ToString() + " " + product.name + " " + product.model);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayCurrentProducts();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                errorProviderName.SetError(tbName, "Please enter product name.");
                btnUpdate.Enabled = false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(tbName.Text, "[ ^ 0-9]"))
            {
                tbName.ForeColor = Color.Red;
                errorProviderName.SetError(tbName, "Product name should not contain numbers!");
                btnUpdate.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.ForeColor = Color.White;
                errorProviderName.Clear();
                btnUpdate.Enabled = true;
            }
        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbModel.Text))
            {
                errorProviderModel.SetError(tbModel, "Please enter the model.");
                btnUpdate.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(tbModel.Text))
            {
                tbModel.ForeColor = Color.White;
                errorProviderModel.Clear();
                btnUpdate.Enabled = true;
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (string.IsNullOrEmpty(tbQuantity.Text))
            {
                btnUpdate.Enabled = false;
                errorProviderQuantity.SetError(tbQuantity, "Please enter quantity.");
            }
            else
            {
                tbQuantity.ForeColor = Color.White;
                errorProviderQuantity.Clear();
                btnUpdate.Enabled = true;
            }
            if (!int.TryParse(tbQuantity.Text, out i))
            {
                tbQuantity.ForeColor = Color.Red;
                errorProviderQuantity.SetError(tbQuantity, "Quantity should not contain letters.");
                btnUpdate.Enabled = false;
            }
        }

        private void tbDepartment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDepartment.Text))
            {
                errorProviderModel.SetError(tbDepartment, "Please enter the department.");
                btnUpdate.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(tbDepartment.Text))
            {
                tbDepartment.ForeColor = Color.White;
                errorProviderModel.Clear();
                btnUpdate.Enabled = true;
            }
        }
    }
}
