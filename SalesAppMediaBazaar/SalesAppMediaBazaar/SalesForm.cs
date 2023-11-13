using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SalesAppMediaBazaar
{
    partial class SalesForm : Form
    {
        SqlManager conn = new SqlManager();
        SqlRequestSend request = new SqlRequestSend();
        
        ItemManager manager ;
        public SalesForm()
        {
           
            InitializeComponent();
            listViewTypes.Items.Clear();
            
            manager = this.conn.GetItems();
            this.conn.GetTypes();
            foreach (string type in manager.GetTypes())
            {
                listViewTypes.Items.Add(type);
            }

        }

        private void iconBtnClose_Click(object sender, EventArgs e)
        {
            listViewTypes.Items.Clear();
            this.Close();

        }


        private void btnComputer_Click(object sender, EventArgs e)
        {
            lstbSales.Items.Clear();
            foreach (string s in manager.SelectType("COMPUTER"))
            {
                lstbSales.Items.Add(s);
            }
         

        }

        private void btnSmartphone_Click(object sender, EventArgs e)
        {
            lstbSales.Items.Clear();
            foreach (string s in manager.SelectType("SMARTPHONE"))
            {
                lstbSales.Items.Add(s);
            }
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            lstbSales.Items.Clear();
            foreach (string s in manager.SelectType("TV"))
            {
                lstbSales.Items.Add(s);
            }
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            lstbSales.Items.Clear();
            foreach (string s in manager.SelectType("AUDIO"))
            {
                lstbSales.Items.Add(s);
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            lstbSales.Items.Clear();
            foreach (string s in manager.SelectType("PHOTO"))
            {
                lstbSales.Items.Add(s);
            }
        }

        private void btnHousehold_Click(object sender, EventArgs e)
        {
            lstbSales.Items.Clear();
            foreach (string s in manager.SelectType("HOUSEHOLD"))
            {
                lstbSales.Items.Add(s);
            }
        }

        private void btnPeripherial_Click(object sender, EventArgs e)
        {
            lstbSales.Items.Clear();
            foreach (string s in manager.SelectType("PERIPHERAL"))
            {
                lstbSales.Items.Add(s);
            }
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {


            if (txtbStock.Text == "" || txtbStock.Text == null)
            {
                MessageBox.Show("Please imput some quantity");
            }
            else
            {
                try
                {
                    string id = lstbSales.SelectedItem.ToString();
                    try
                    {
                        int quantity = Convert.ToInt32(txtbStock.Text);
                        if (quantity <= 0)
                        {
                            quantity = 0;
                        }
                        string idCut = id.Substring(1, 2);
                        DialogResult sure = MessageBox.Show($"Are you sure you want to send a request for the amount of {quantity} items?", "Verify your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (sure == DialogResult.Yes)
                        {
                            request.SendRequest(Convert.ToInt32(idCut), quantity);
                        }
                        else if (sure == DialogResult.No)
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid imput for quantity");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Select an item from the listbox please !");
                }
                finally
                {
                    txtbStock.Text = "";
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTypes.SelectedItems.Count > 0)
            {
                string text = listViewTypes.SelectedItems[0].Text;
                lstbSales.Items.Clear();
                foreach (string s in manager.SelectType(text))
                {
                    lstbSales.Items.Add(s);
                }

            }
        }
    }
}
