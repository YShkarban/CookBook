using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Core.Model
{
    [Table("CookingTimes")]
    public class CookingTime
    {
        [Key, ForeignKey("Recipe")]
        public int CookingTimeID { get; set; }
        public virtual Recipe Recipe { get; set; }
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

        public static CookingTime operator +(CookingTime c1, CookingTime c2)
        {
            var totalMinutes = c1.Minutes + c2.Minutes;
            var totalHours = c1.Hours + c2.Hours;
            var time =  new CookingTime(totalMinutes, totalHours);
            //time.Recipe = c1.Recipe;
            return time;
        }
      
        public override string ToString()
        {
            if(Hours > 0 && Minutes > 0)
            {
                return Hours + "h " + Minutes + "m";
            }
            else if(Hours == 0 && Minutes > 0)
            {
                return Minutes + "m";
            } 
            else if(Hours > 0 && Minutes == 0)
            {
                return Hours + "h";
            }

            return "";
        }

        public override bool Equals(object other)
        {
            if (other is CookingTime)
            {
                CookingTime otherObj = other as CookingTime;
                if (otherObj.Hours == this.Hours && otherObj.Minutes == this.Minutes)
                    return true;
            }
            return false;
        }

        public static bool operator ==(CookingTime lhs, CookingTime rhs)
        {
            return Equals(lhs, rhs);
        }

        public static bool operator !=(CookingTime lhs, CookingTime rhs)
        {
            return !Equals(lhs, rhs);
        }

    }
}
