using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum Complexity { VeryEasy = 1, Easy, Normal, Hard, VeryHard };

    //TODO: Create test for this class
    public class Recipe: IRecipe
    {
        public string title { get; set; }
        public Complexity complexity { get; set; }
        public int rating { get; set; }
        public string type { get; set; }
        public int yield { get; set; }
        public string nutrition { get; set; }

        public string recipeLanguage { get; set; }

        public CookingTime cookingTime { get; set; }
        public CookingTime preparationTime { get; set; }
        public CookingTime totalTime { get; set; }

        public List<string> ingredientsList { get; set; }
        public string description { get; set; }

        public List<string> comment { get; set; }
        public string source { get; set; }
        public string videoUrl { get; set; }

        public Recipe()
        {
            complexity = Complexity.Normal;
            cookingTime = new CookingTime();
            preparationTime = new CookingTime();
            totalTime = cookingTime + preparationTime;
        }


        
    }
}
