using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    //TODO: Create test for this class
    public class Recipe: IRecipe
    {
        public string title { get; set; }
        public Complexity complexity { get; set; }
        public Rating rating { get; set; }
        public MealType mealType { get; set; }
        public DishType dishType { get; set; }
        public CookingStyle cookingStyle { get; set; }

        public uint yield { get; set; }

        public CookingTime cookingTime { get; set; }
        public CookingTime preparationTime { get; set; }
        public CookingTime totalTime { get; set; }

        public List<string> ingredientsList { get; set; }
        public string description { get; set; }

        public string source { get; set; }
        public string videoUrl { get; set; }

        public Recipe()
        {
        }
    }
}
