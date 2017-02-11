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

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Recipe)
            {
                Recipe other = obj as Recipe;

                if (title != other.title
                    || complexity != other.complexity
                    || cookingStyle != other.cookingStyle
                    || dishType != other.dishType
                    || mealType != other.mealType
                    || preparationTime != other.preparationTime
                    || rating != other.rating
                    || source != other.source
                    || totalTime != other.totalTime
                    || videoUrl != other.videoUrl
                    || yield != other.yield
                    || cookingTime != other.cookingTime
                    || description != other.description)
                {
                    return false;
                }

                //compare ingridient list
                if (ingredientsList.Count == other.ingredientsList.Count)
                {
                    if (ingredientsList.Count == 0 && other.ingredientsList.Count == 0)
                    {
                        return true;
                    }

                    //check each value 
                    for (var i = 0; i < ingredientsList.Count; i++)
                    {
                        if (ingredientsList.ElementAt(i) != other.ingredientsList.ElementAt(i))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
