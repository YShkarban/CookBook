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
            if (obj is Recipe)
            {
                Recipe other = obj as Recipe;

                if (this.title != other.title)
                    return false;
                if (this.complexity != other.complexity)
                    return false;
                if (this.cookingStyle != other.cookingStyle)
                    return false;
                if (this.dishType != other.dishType)
                    return false;
                if (this.ingredientsList.Count != other.ingredientsList.Count)
	                return false;
                if (this.mealType != other.mealType)
                    return false;
                if (this.preparationTime != other.preparationTime)
                    return false;
                if (this.rating != other.rating)
                    return false;
                if (this.source != other.source)
                    return false;
                if (this.totalTime != other.totalTime)
                   return false;
                if (this.videoUrl != other.videoUrl)
                    return false;
                if (this.yield != other.yield)
                    return false;
                if (this.cookingTime != other.cookingTime)
                    return false;
                return true;
            }
            return false;
        }
    }
}
