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

namespace ManagerAppMediaBazaar
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
            string email = tbxUsername.Text;
            string password = tbxPassword.Text;
            if (login.ValidateCredentials(email,password)) //if there are no rows input is wrong - clear textboxes and display msg
            {
                Home ho = new Home(email);
                ho.Show();
                this.Hide();
            }
            else
            {
                lblFail.Show();
                tbxPassword.Clear();
                tbxUsername.Clear();
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            iconPictureBox3.Hide();
            tbxPassword.UseSystemPasswordChar = false;
            iconPictureBox4.Show();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            iconPictureBox4.Hide();
            tbxPassword.UseSystemPasswordChar = true;
            iconPictureBox3.Show();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
