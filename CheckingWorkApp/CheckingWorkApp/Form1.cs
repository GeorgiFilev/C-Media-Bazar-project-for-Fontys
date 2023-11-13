using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckingWorkApp
{
    public partial class Form1 : Form
    {
        SqlManager mngr = new SqlManager();
        SqlFunction function;
        public Form1()
        {
            InitializeComponent();
            function = new SqlFunction();
            UpdatePeople();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void lbPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbPeople.SelectedItem != null)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = txtbPass.Text.ToString();
                int index = lbPeople.SelectedIndex;
                if (function.CheckPassword(function.GetPeople()[index].GetID(), pass) == true)
                {
                    panel2.Visible = true;
                    panel1.Visible = false;
                    lblStart.Visible = true;
                    lblTime.Visible = true;
                    txtbPass.Text = "";
                    UpdateGUI(function.GetPeople()[index].GetID());
                }
                else
                {
                    MessageBox.Show("Wrong password");
                    txtbPass.Text = "";
                    txtbPass.Focus();
                }
            }
            catch(ExecutionEngineException em)
            {
                MessageBox.Show("problem with the selection");
            }
            
        }
        public void UpdatePeople()
        {
            lbPeople.Items.Clear();
            function.PopulateAllPeople();
            List<Person> people = function.GetPeople();
            foreach (Person p in people)
            {
                lbPeople.Items.Add(p.ToString());
            }
        }
        public void UpdateGUI(int idPeron)
        {
            lstvShifts.Items.Clear();
            function.PopulateShifts(idPeron);
            if(function.GetShifts()==null)
            {
                MessageBox.Show("You have no assigned shifts");
            }
            else
            {
                foreach(Shift s in function.GetShifts())
                {
                    ListViewItem item = new ListViewItem(s.Day);
                    item.SubItems.Add(s.Shif);
                    item.SubItems.Add(s.Week.ToString());
                    item.SubItems.Add(s.Status.ToString());
                    lstvShifts.Items.Add(item);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void lstvShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvShifts.SelectedItems.Count == 1)
            {
                lblStart.Visible = true;
                lblTime.Visible = true;
                int index = lstvShifts.SelectedItems[0].Index;
                if (function.GetShifts()[index].Status == STATUS.Upcoming)
                {
                    btnStart.Enabled = true;
                    btnEnd.Enabled = false;
                    lblStart.Text = "";
                    lblTime.Text = "";
                }
                else if (function.GetShifts()[index].Status == STATUS.Open)
                {
                    btnStart.Enabled = false;
                    btnEnd.Enabled = true;
                    lblStart.Text = "Shift started at:  " + function.GetShifts()[index].Time.ToLongTimeString();
                    lblTime.Text = "";
                    //lblStart.Text = "Shift started at:  " + function.GetShifts()[index].Time.ToLongTimeString();
                }
                else if (function.GetShifts()[index].Status == STATUS.Closed)
                {
                    btnStart.Enabled = false;
                    btnEnd.Enabled = false;
                    lblStart.Text = "Shift started at: " + function.GetShifts()[index].Time.ToLongTimeString();
                    lblTime.Text =" Work time: "+ function.GetWorkTimeDuration(function.GetShifts()[index].ID) + " hours";
                    //lblStart.Text = "Shift started at:  " + function.GetShifts()[index].Time.ToLongTimeString();
                }
              
            }
            else
            {
                lblStart.Visible = false;
                lblTime.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lstvShifts.SelectedItems.Count == 1)
            {
                
                int index = lstvShifts.SelectedItems[0].Index;
                function.StartShift(function.GetShifts()[index].ID);
                btnStart.Enabled = false;
                btnEnd.Enabled = true;
                UpdateGUI(function.GetShifts()[index].ID);
                function.GetShifts()[index].SetTime();
                function.UpdateStartOfShift(function.GetShifts()[index].ID, function.GetShifts()[index].Time);
                lblStart.Text = "Shift started at:  " + function.GetShifts()[index].Time.ToLongTimeString();
                
            }
           
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (lstvShifts.SelectedItems.Count == 1)
            {
                int index = lstvShifts.SelectedItems[0].Index;
                function.EndShift(function.GetShifts()[index].ID);
                btnStart.Enabled = false;
                btnEnd.Enabled = false;
                UpdateGUI(function.GetShifts()[index].ID);
                DateTime time = DateTime.Now;
                TimeSpan duration = time - function.GetShifts()[index].Time;
                DateTime t = Convert.ToDateTime(duration.ToString());
                function.UpdateWorktime(function.GetShifts()[index].ID, t);
                lblTime.Text = t.ToLongTimeString() +" hours worked";
                
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnEnd.Enabled = false;
            panel1.Visible = false;
            panel2.Visible = false;
            lblStart.Visible = false;
            lblTime.Visible = false;

            lstvShifts.Items.Clear();
            function = new SqlFunction();
            UpdatePeople();
        }
    }
}
