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
        public ComplexityEnum complexity { get; set; }
        public RatingEnum rating { get; set; }
        public MealTypeEnum mealtype { get; set; }
        public DishType dishtype { get; set; }
        public CookingStyle cookingstyle { get; set; }

        public uint yield { get; set; }
     
        public string recipeLanguage { get; set; }

        public CookingTime cookingTime { get; set; }
        public CookingTime preparationTime { get; set; }
        public CookingTime totalTime { get; set; }

        public List<string> ingredientsList { get; set; }
        public string description { get; set; }

        public string source { get; set; }
        public string videoUrl { get; set; }

        public Recipe()
        {
            complexity = ComplexityEnum.Normal;
            cookingTime = new CookingTime();
            preparationTime = new CookingTime();
            totalTime = cookingTime + preparationTime;
        }


        
    }
}
