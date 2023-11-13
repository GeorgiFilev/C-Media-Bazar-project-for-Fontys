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
    public partial class Login : Form
    {
        SqlLogin login = new SqlLogin();
        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Hide();
            txtbPassword.UseSystemPasswordChar = false;
            iconPictureBox2.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            string userId = txtbUsername.Text;
            string password = txtbPassword.Text;
            bool istrue = login.LoginCheck(userId, password);
            if (istrue == true)
            {
                Form1 sls = new Form1(userId);
                sls.Show();
                this.Hide();
                lblFail.Show();
            }
            else
            {
                lblFail.Visible = Enabled;
                txtbUsername.Clear();
                txtbPassword.Clear();
            }
          
        }

        private void lblFail_Click(object sender, EventArgs e)
        {

        }
    }
}
