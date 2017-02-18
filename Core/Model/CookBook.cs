using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Core.Model
{
    [Table("CookBooks")]
    public class CookBook
    {
        [Key, ForeignKey("User")]
        public int CookBookID { get; set; }

        [Required]
        public virtual User User { get; set; }
        public ICollection<Recipe> Recipes { get; private set; }

        public CookBook(User user)
        {
            if (user == null)
                throw new ArgumentNullException();
            this.User = user;
            user.SetCookBook(this);
            Recipes = new List<Recipe>();
        }

        public void SetUser(User user)
        {
            if(user == null)
                throw new ArgumentNullException();
            this.User = user;
            this.User.SetCookBook(this);
        }
        
        public bool AddRecipe(Recipe recipe)
        {
            try
            {
                if (Recipes.Contains(recipe))
                {
                    throw new ArgumentException("This recipe already exists on the list");
                }
                Recipes.Add(recipe);
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
                if(!Recipes.Contains(recipe))
                {
                    throw new ArgumentException("Recipe does not exists on the list");
                }
                Recipes.Remove(recipe);
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
