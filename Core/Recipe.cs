using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum Complexity { VeryEasy = 1, Easy, Normal, Hard, VeryHard };

    public class Recipe
    {
        public Complexity complexity = Complexity.Normal;
        public int CookingTime { get; set; }
                
        public Recipe()
        {

        }
    }
}
