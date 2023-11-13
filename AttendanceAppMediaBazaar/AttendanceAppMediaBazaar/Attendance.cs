using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceAppMediaBazaar
{
    public partial class Form1 : Form
    {
        //1.  select a shift
        //2.  enter employee password in text box
        //2.5 check if password is correct
        //3.  click start and get current datetime
        //4.  shift moves to the list box on the right
        //5.  select the shift from lbEndShift
        //6.  click stop and get current datetime
        //7.  subtract datetime - datetime
        //8.  store the result in the database

        //bonusche 
        // searcha i vzimaneto na shiftove ot database go ima v moqta aplikaciq 
        public Form1()
        {
            InitializeComponent();
            //hidden by default
            tbPassword.Hide();
            lblPassword.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LbShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when you select a shift , show the text box and label
            tbPassword.Show();
            lblPassword.Show();
        }
    }
}
