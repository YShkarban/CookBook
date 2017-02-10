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
    }
}
