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
    public partial class ShiftFormCreate : Form
    {
        EmployeeManagement empManagement = new EmployeeManagement();
        ShiftManagement shiftManagement = new ShiftManagement();
        string idCut;
        public ShiftFormCreate()
        {
            InitializeComponent();
 
            empManagement.UpdateEmployeeList();
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            lblCurrentWeek.Text = myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW).ToString();
            mtbWeek.Text = lblCurrentWeek.Text;
            cmbDay.DataSource = Enum.GetValues(typeof(Weekdays));
            cmbShift.DataSource = Enum.GetValues(typeof(ShiftType));
            cmbShift2.DataSource = Enum.GetValues(typeof(ShiftType));
            DisplayShiftsPerDay(mtbWeek.Text);
            lblError.Hide();
            lblDeleteError.Hide();
            lblUpdateError.Hide();
            

            

            foreach (string emp in empManagement.AllEmployees())
            {
                lbEmployees.Items.Add(emp);
            }
            

        }
        /*
         shiftManagement.UpdateShiftList();
            
            
            lbShifts.Items.Clear();
            lbShifts.Items.Add($" ID            Name                     Day              Shift             Job");

            foreach (string emp in shiftManagement.AllShifts(week))
            {
                //lbShifts.Items.Add($"---------------------------------------------------------------------------------------------");
                lbShifts.Items.Add($"_____________________________________________________________________________________________");

                lbShifts.Items.Add(emp);
                


            }
        */
        public void PopulateListBox(string week, string day, ListBox listbox)
        {
            listbox.Items.Clear();
            listbox.Items.Add($" MORNING ");
            listbox.Items.Add($"_____________________________________________");
            listbox.Items.Add($"           ");
            foreach (string info in shiftManagement.GetEmployeeInfoFromShifts(week, day, "Morning"))
            {
                listbox.Items.Add(info);
            }
            listbox.Items.Add($"           ");
            listbox.Items.Add($" AFTERNOON ");
            listbox.Items.Add($"_____________________________________________");
            listbox.Items.Add($"           ");
            foreach (string info in shiftManagement.GetEmployeeInfoFromShifts(week, day, "Afternoon"))
            {
                listbox.Items.Add(info);
            }
            listbox.Items.Add($"           ");
            listbox.Items.Add($" NIGHT ");
            listbox.Items.Add($"_____________________________________________");
            listbox.Items.Add($"           ");
            foreach (string info in shiftManagement.GetEmployeeInfoFromShifts(week, day, "Night"))
            {
                listbox.Items.Add(info);
            }
        }
        public void DisplayShiftsPerDay(string week)
        {
            shiftManagement.UpdateShiftList();
            PopulateListBox(week, "Monday", lbMonday);
            PopulateListBox(week, "Tuesday", lbTuesday);
            PopulateListBox(week, "Wednesday", lbWednesday);
            PopulateListBox(week, "Thursday", lbThursday);
            PopulateListBox(week, "Friday", lbFriday);
            PopulateListBox(week, "Saturday", lbSaturday);
            PopulateListBox(week, "Sunday", lbSunday);


        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {

            try
            {
                    string id = lbEmployees.SelectedItem.ToString();
                    string idCut = id.Substring(1, 3);

                    if(shiftManagement.AddShift(Convert.ToInt32(idCut), lblFName.Text, lblLName.Text, dateTimePicker1.Value.DayOfWeek.ToString(), cmbShift.SelectedItem.ToString(), lblKur.Text, lblRole.Text))
                     MessageBox.Show("Successfully added the shift.");
                    else
                    {
                    MessageBox.Show("Cannot assign 2 shifts for 1 day to a person.");
                    }

            }
            catch (Exception)
            {
                lblError.Show();
                lblError.Text = "Please select an employee.";
                
            }       
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shift_Load(object sender, EventArgs e)
        {

        }
        public void DisplayEmployeeRole(string id)
        {           
            List<string> details = new List<string>();
            details = empManagement.EmployeeDetails(id).ToList();
            foreach (string d in details)
            {
                lblFName.Text = details[1];
                lblLName.Text = details[2];
                lblRole.Text = details[22];
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            empManagement.UpdateEmployeeList();
            lbEmployees.Items.Clear();


            if (tbSearch.Text == "")
            {
                foreach (string emp in empManagement.AllEmployees())
                {

                    lbEmployees.Items.Add(emp);

                }
            }
            else
            {
                foreach (string employee in empManagement.SearchEmployeeInListBox(tbSearch.Text))
                {

                    lbEmployees.Items.Add(employee);
                }
            }
        }

        private void LbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = lbEmployees.SelectedItem.ToString();
                string idCut = id.Substring(1, 2);
                DisplayEmployeeRole(idCut);
            }
            catch (Exception)
            {
                lblError.Show();
                lblError.Text = "Please select an employee";
            }

                 
           
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
           // connection.DeleteAllShifts();
           // connection.ViewShiftsInListBox(lbShifts);
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CultureInfo myCI = new CultureInfo("en-US");
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
            lblKur.Text = myCal.GetWeekOfYear(dateTimePicker1.Value, myCWR, myFirstDOW).ToString();

          
        }

        private void BtnKur_Click(object sender, EventArgs e)
        {
            shiftManagement.AutoAssigner(Convert.ToInt32(textBox1.Text));
            DisplayShiftsPerDay(mtbWeek.Text);
        }


        private void mtbWeek_TextChanged(object sender, EventArgs e)
        {
            if (mtbWeek.Text != "")
            {

                DisplayShiftsPerDay(mtbWeek.Text);

            }
            else
            {
                DisplayShiftsPerDay(lblCurrentWeek.Text);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                shiftManagement.DeleteShift(Convert.ToInt32(idCut));

                DisplayShiftsPerDay(mtbWeek.Text);
            }
            catch (Exception)
            {
                lblDeleteError.Show();
                lblDeleteError.Text = "Please select a shift.";
            }
        }

        private void lbMonday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMonday.SelectedIndex != -1)
            {
                string id = lbMonday.SelectedItem.ToString();
                idCut = id.Substring(1, 5);
                lbTuesday.SelectedIndex = -1;
                lbWednesday.SelectedIndex = -1;
                lbThursday.SelectedIndex = -1;
                lbFriday.SelectedIndex = -1;
                lbSaturday.SelectedIndex = -1;
                lbSunday.SelectedIndex = -1;
            }
            

        }

        private void lbTuesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTuesday.SelectedIndex != -1)
            {
                string id = lbTuesday.SelectedItem.ToString();
                idCut = id.Substring(1, 5);
                lbMonday.SelectedIndex = -1;

                lbWednesday.SelectedIndex = -1;
                lbThursday.SelectedIndex = -1;
                lbFriday.SelectedIndex = -1;
                lbSaturday.SelectedIndex = -1;
                lbSunday.SelectedIndex = -1;
            }
            
        }

        private void lbWednesday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWednesday.SelectedIndex != -1)
            {
                string id = lbWednesday.SelectedItem.ToString();
                idCut = id.Substring(1, 5);
                lbMonday.SelectedIndex = -1;
                lbTuesday.SelectedIndex = -1;

                lbThursday.SelectedIndex = -1;
                lbFriday.SelectedIndex = -1;
                lbSaturday.SelectedIndex = -1;
                lbSunday.SelectedIndex = -1;
            }
            
        }
        private void lbThursday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbThursday.SelectedIndex != -1)
            {
                string id = lbThursday.SelectedItem.ToString();
                idCut = id.Substring(1, 5);
                lbMonday.SelectedIndex = -1;
                lbTuesday.SelectedIndex = -1;
                lbWednesday.SelectedIndex = -1;

                lbFriday.SelectedIndex = -1;
                lbSaturday.SelectedIndex = -1;
                lbSunday.SelectedIndex = -1;
            }
            
        }
        private void lbFriday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFriday.SelectedIndex != -1)
            {
                string id = lbFriday.SelectedItem.ToString();
                idCut = id.Substring(1, 5);
                lbMonday.SelectedIndex = -1;
                lbTuesday.SelectedIndex = -1;
                lbWednesday.SelectedIndex = -1;
                lbThursday.SelectedIndex = -1;

                lbSaturday.SelectedIndex = -1;
                lbSunday.SelectedIndex = -1;
            }
           
        }

        private void lbSaturday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSaturday.SelectedIndex != -1)
            {
                string id = lbSaturday.SelectedItem.ToString();
                idCut = id.Substring(1, 5);
                lbMonday.SelectedIndex = -1;
                lbTuesday.SelectedIndex = -1;
                lbWednesday.SelectedIndex = -1;
                lbThursday.SelectedIndex = -1;
                lbFriday.SelectedIndex = -1;

                lbSunday.SelectedIndex = -1;
            }
            
        }

        private void lbSunday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSunday.SelectedIndex != -1)
            {
                string id = lbSunday.SelectedItem.ToString();
                idCut = id.Substring(1, 5);
                lbMonday.SelectedIndex = -1;
                lbTuesday.SelectedIndex = -1;
                lbWednesday.SelectedIndex = -1;
                lbThursday.SelectedIndex = -1;
                lbFriday.SelectedIndex = -1;
                lbSaturday.SelectedIndex = -1;
            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string day = cmbDay.SelectedItem.ToString();
                string shift = cmbShift2.SelectedItem.ToString();


                shiftManagement.UpdateShift(Convert.ToInt32(idCut), day, shift);
                DisplayShiftsPerDay(mtbWeek.Text);
                MessageBox.Show("Updated successfully");
            }
            catch (Exception)
            {
                lblUpdateError.Show();
                lblUpdateError.Text = "Please select a shift";
            }

        }
    }
}
