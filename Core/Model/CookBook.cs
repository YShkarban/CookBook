using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class CookBook
    {
        public User Owner { get; private set; }
        public List<Recipe> ListOfRecipes { get; private set; }

        public CookBook()
        {
            ListOfRecipes = new List<Recipe>();
        }

        public bool AddRecipe(Recipe recipe)
        {
            try
            {
                if (ListOfRecipes.Contains(recipe))
                {
                    throw new ArgumentException("This recipe already exists on the list");
                }
                ListOfRecipes.Add(recipe);
            }
            catch(Exception e)
            {
                //TODO: Exaception message to log file
                return false;
            }
            return true;
        }

        public bool RemoveRecipe(Recipe recipe)
        {
            try
            {
                if(!ListOfRecipes.Contains(recipe))
                {
                    throw new ArgumentException("Recipe does not exists on the list");
                }
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
