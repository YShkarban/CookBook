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

        bool AddRecipe(Recipe recipe)
        {
            try
            {
                //TODO: Throw exception if this recipe exists
                ListOfRecipes.Add(recipe);
            }
            catch(Exception e)
            {
                //TODO: Exaception message to log file
                return false;
            }
            return true;
        }
        bool RemoveRecipe(Recipe recipe)
        {
            try
            {
                //TODO: Check if Recipe is on the list
                ListOfRecipes.Remove(recipe);
            }
            catch (Exception e)
            {
                //TODO: Exaception message to log file
                return false;
            }
            return true;
        }

    }
}
