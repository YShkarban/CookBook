using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CookingTime
    {
        public int Minutes { get; private set; }
        public int Hours { get; private set; }

        public CookingTime()
        {
            setTime(0, 0);
        }

        public CookingTime(int minutes, int hours = 0)
        {
            setTime(minutes, hours);
        }
        
        private void setTime(int minutes, int hours)
        {
            if (minutes < 0 || hours < 0)
            {
                throw new ArgumentException();
            }

            while(minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            Minutes = minutes;
            Hours = hours;
        }

        //TODO: write tests for this method
        public static CookingTime operator +(CookingTime c1, CookingTime c2)
        {
            var totalMinutes = c1.Minutes + c2.Minutes;
            var totalHours = c1.Hours + c2.Hours;
            return new CookingTime(totalMinutes, totalHours);
        }
    }
}
