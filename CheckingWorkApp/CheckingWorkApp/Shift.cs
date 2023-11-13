using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingWorkApp
{
    public enum STATUS
    {
        Upcoming,
        Open,
        Closed
    }
    class Shift
    {
        public int ID
        {
            get;
            private set;
        }
        public string Day
        {
            get;
            private set;
        }
        public string Shif
        {
            get;
            private set;
        }

        public int Week
        {
            get;
            private set;
        }
        public STATUS Status
        {
            get;
            set;
        }
        public DateTime Time
        {
            get;
            set;
        }
        public void SetTime()
        {
            Time = DateTime.Now;
        }
        public Shift(int id, string day, string shift, int week, STATUS status)
        {
            ID = id;
            Day = day;
            Shif = shift;
            Week = week;
            Status = status;
            
        }
        public Shift(int id,string day,string shift, int week,STATUS status,DateTime time)
        {
            ID = id;
            Day = day;
            Shif = shift;
            Week = week;
            Status = status;
            Time = time;
        }
        public string ToString()
        {
            return $"{this.Day} {this.Shif} {this.Week} : {this.Status.ToString()}";
        }
    }
}
