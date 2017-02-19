using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; private set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public ICollection<Recipe> Recipes { get; private set; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            Recipes = new List<Recipe>();
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
            catch (Exception e)
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
                if (!Recipes.Contains(recipe))
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
