using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace StockAppMediaBazaar
{
    public partial class ShiftsOverview : Form
    {
        ShiftManagement shiftManagement = new ShiftManagement();
        public ShiftsOverview()
        {
            InitializeComponent();
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            lblCurrentWeek.Text = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW).ToString();
            DisplayShiftInListBox(Convert.ToInt32(lblCurrentWeek.Text));
            cmbDay.DataSource = Enum.GetValues(typeof(Weekdays));
            cmbShift.DataSource = Enum.GetValues(typeof(ShiftType));
            lblDeleteError.Hide();
            lblUpdateError.Hide();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplayShiftInListBox(int week)
        {

            shiftManagement.UpdateShiftList();
            
            
            lbShifts.Items.Clear();
            lbShifts.Items.Add($" ID            Name                     Day              Shift             Job");

            foreach (string emp in shiftManagement.AllShifts(week))
            {
                //lbShifts.Items.Add($"---------------------------------------------------------------------------------------------");
                lbShifts.Items.Add($"_____________________________________________________________________________________________");

                lbShifts.Items.Add(emp);
                


            }
        }

        private void ShiftsOverview_Load(object sender, EventArgs e)
        {

        }

        private void TbWeek_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void MtbWeek_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void MtbWeek_TextChanged(object sender, EventArgs e)
        {
            if (mtbWeek.Text != "")
            {

                DisplayShiftInListBox(Convert.ToInt32(mtbWeek.Text));
                lblCurrent.Text = "Current shifts" + " : " + "Week" + mtbWeek.Text;
            }
            else
            {
                DisplayShiftInListBox(Convert.ToInt32(lblCurrentWeek.Text));
                lblCurrent.Text = "Current shifts" + " : " + "Week" + lblCurrentWeek.Text;

            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = lbShifts.SelectedItem.ToString();
                string idCut = id.Substring(1, 5);
                shiftManagement.DeleteShift(Convert.ToInt32(idCut));

                DisplayShiftInListBox(Convert.ToInt32(mtbWeek.Text));
            }
            catch (Exception)
            {
                lblDeleteError.Show();
                lblDeleteError.Text = "Please select a shift.";
            }
            
            

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = lbShifts.SelectedItem.ToString();
                string idCut = id.Substring(1, 5);

                string day = cmbDay.SelectedItem.ToString();
                string shift = cmbShift.SelectedItem.ToString();


                shiftManagement.UpdateShift(Convert.ToInt32(idCut), day, shift);
                MessageBox.Show("Updated successfully");
            }
            catch (Exception)
            {
                lblUpdateError.Show();
                lblUpdateError.Text = "Please select a shift";
            }

            
           
        }

        private void LbShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                lblDeleteError.Text = "Please select a shift";
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
