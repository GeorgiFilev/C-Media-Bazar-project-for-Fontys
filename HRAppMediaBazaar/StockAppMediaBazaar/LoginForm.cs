using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace StockAppMediaBazaar
{
    public partial class LoginForm : Form
    {
        Login login = new Login();
        public LoginForm()
        {
            InitializeComponent();
            lblFail.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           string userId = tbxUsername.Text;
           string password = tbxPassword.Text;

           
          
            if (login.ValidateCredentials(userId,password))
            {
               HR hr=new HR();
               hr.Show();
               this.Hide();
            }
           else
           {
                lblFail.Show();
                tbxUsername.Clear();
                tbxPassword.Clear();
           }
              
           
        }
       

        private void TbxPassword_TextChanged(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '$';
        }

        private void TbxPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void IconPictureBox1_Click(object sender, EventArgs e)
        {
            iconPictureBox1.Hide();
            tbxPassword.UseSystemPasswordChar = false;
            iconPictureBox2.Show();

        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            iconPictureBox2.Hide();
            tbxPassword.UseSystemPasswordChar = true;
            iconPictureBox1.Show();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void TbxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}
