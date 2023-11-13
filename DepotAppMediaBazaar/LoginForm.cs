using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DepotAppMediaBazaar
{
    public partial class LoginForm : Form
    {
        Login login = new Login();
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void IconButtonLogIn_Click(object sender, EventArgs e)
        {
            

            string userId = tbxUsername.Text;
            string password = tbxPassword.Text;


            if (login.ValidateCredentials(userId, password))
            {
                Form1 f1 = new Form1(userId);
                f1.Show();
                this.Hide();
            }
            else
            {
                lbFail.Show();
                tbxPassword.Clear();
                tbxUsername.Clear();
            }
          
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lbFail.Hide();
            iconPictureBoxEye.BringToFront();
        }

        private void TbxUsername_Click(object sender, EventArgs e)
        {
            tbxUsername.Clear();
        }

        private void TbxPassword_Click(object sender, EventArgs e)
        {
            tbxPassword.Clear();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBoxEye_Click(object sender, EventArgs e)
        {
            iconPictureBoxEye.Hide();
            tbxPassword.UseSystemPasswordChar = false;
            iconPictureBoxEyeCross.Show();
        }

        private void iconPictureBoxEyeCross_Click(object sender, EventArgs e)
        {
            iconPictureBoxEye.Show();
            tbxPassword.UseSystemPasswordChar = true;
            iconPictureBoxEyeCross.Hide();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButtonLogIn.PerformClick();
            }
        }
    }
}
