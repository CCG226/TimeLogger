using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TimeLogger
{
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class TimeSheet
    {
        private (Day day, int hour)[] weeklyTimeSheet;

        public TimeSheet()
        {
            weeklyTimeSheet = new (Day day, int hour)[7]
                {
                    (Day.Monday, 0),
                    (Day.Tuesday, 0),
                    (Day.Wednesday, 0),
                    (Day.Thursday, 0),
                    (Day.Friday, 0),
                    (Day.Saturday, 0),
                    (Day.Sunday, 0)

                };
        }
        public void SubmitHours(Day day, int time)
        {
            if (!ValidDay(day))
            {
                throw new ArgumentOutOfRangeException("Invalid Day Value Caused By Enum Value " + day);
            }
            if(!ValidTime(time))
            {
                throw new ArgumentOutOfRangeException("Invalid Hour Time. Hour Range In A Day Is 0 - 24 Hours. You Entered: " + time);
            }
            for (int i = 0; i < weeklyTimeSheet.Length; i++)
            {
                if (weeklyTimeSheet[i].day == day)
                {
                    weeklyTimeSheet[i] = (weeklyTimeSheet[i].day, time);
                }
            }
        }
        public int GetHoursWorkedOn(Day day)
        {
            if (!ValidDay(day))
            {
                throw new ArgumentOutOfRangeException("Invalid Day Value Caused By Enum Value " + day);
            }
            for (int i = 0; i < weeklyTimeSheet.Length; i++)
            {
                if (weeklyTimeSheet[i].day == day)
                {
                   return weeklyTimeSheet[i].hour;
                }
            }

            return -1;
        }
        private bool ValidTime(int time)
        {
            if (time < 0 || time > 24)
            {
                return false;
            }
            return true;
        }
        private bool ValidDay(Day day)
        {
            if (Enum.IsDefined(typeof(Day), day))
            {
                return true;
            }
            return false;
        }
    }
}
