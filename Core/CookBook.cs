using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CookBook
    {
        public List<Recipe> ListOfRecipes { get; private set; }

        public CookBook()
        {
            ListOfRecipes = new List<Recipe>();
        }
    }
}
