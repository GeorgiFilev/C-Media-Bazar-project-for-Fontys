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
	public partial class AddProducts : Form
	{ 
		ProductManagement pm = new ProductManagement();
		public AddProducts()
		{
			InitializeComponent();
			cmbType.DataSource = Enum.GetValues(typeof(ProductType));
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

			public void DisplayPendingProducts()
		{
			string[] pendingProducts = pm.PendingProducts();
			lbAddedProducts.Items.Clear();
			foreach (string product in pendingProducts)
			{
				lbAddedProducts.Items.Add(product);
			}
		}
	  
		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				ProductType type = (ProductType)cmbType.SelectedItem;
				int quantity = Convert.ToInt32(tbQuantity.Text);
				string name = tbName.Text;
				string model = tbModel.Text;
				string department = cmbDepartments.SelectedItem.ToString();
				pm.AddProductDB(type, name, model, quantity, department);
				tbName.Clear();
				tbModel.Clear();
				tbQuantity.Clear();
				DisplayPendingProducts();
				lbWarning.Hide();
			}
		    catch(Exception ex)
			{
				lbWarning.Text = "Not all fields are filled correctly";
				lbWarning.Show();
			}
		}

		private void AddProducts_Load(object sender, EventArgs e)
		{
			DisplayPendingProducts();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string id = lbAddedProducts.SelectedItem.ToString();
			string idCut = id.Substring(0, 2);
			string[] details = pm.GetPendingProductDetails(idCut);
			lbShowType.Text = details[1];
			lbShowName.Text = details[2];
			lbShowModel.Text = details[3];
			lbShowQuantity.Text = details[4];
			lbShowDepartment.Text = details[5];
		}

		private void btnAddToCurrentStock_Click(object sender, EventArgs e)
		{
			if(lbAddedProducts.SelectedIndex == -1)
			{
				lbWarning2.Text = "Select a product.";
				lbWarning2.Show();
			}
			else
			{
				string line = lbAddedProducts.SelectedItem.ToString();
				string id = line.Substring(0, 2);
				pm.InsertIntoCurrentStock(id);
				DisplayPendingProducts();
				lbWarning2.Hide();
			}
			
		}

		private void TbName_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbName.Text))
			{

				errorProviderName.SetError(tbName, "Please enter product name.");
			}
			if (System.Text.RegularExpressions.Regex.IsMatch(tbName.Text, "[ ^ 0-9]"))
			{
				tbName.ForeColor = Color.Red;
				errorProviderName.SetError(tbName, "Product name should not contain numbers!");
			}
			else if (!string.IsNullOrWhiteSpace(tbName.Text))
			{
				tbName.ForeColor = Color.Black;
				errorProviderName.Clear();
			}
		}

		private void TbModel_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbModel.Text))
			{

				errorProviderModel.SetError(tbModel, "Please enter the model.");
			}
			else if (!string.IsNullOrWhiteSpace(tbModel.Text))
			{
				tbModel.ForeColor = Color.Black;
				errorProviderModel.Clear();
			}
		}

		private void TbQuantity_Validating(object sender, CancelEventArgs e)
		{
			int i;
			if (string.IsNullOrEmpty(tbQuantity.Text))
			{

				errorProviderQuantity.SetError(tbQuantity, "Please enter quantity.");
			}
			else
			{
				tbQuantity.ForeColor = Color.Black;
				errorProviderQuantity.Clear();
			}
			if (!int.TryParse(tbQuantity.Text, out i))
			{
				tbQuantity.ForeColor = Color.Red;
				errorProviderQuantity.SetError(tbQuantity, "Quantity should not contain letters.");
			}
		}
	}
}
