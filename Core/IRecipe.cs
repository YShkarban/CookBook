using System.Collections.Generic;

namespace Core
{
    //TODO: Create classes for non primitive types and change type from string to created classes
    public interface IRecipe
    {
        string title { get; set; }
        ComplexityEnum complexity { get; set; }
      
        RatingEnum rating { get; set; }

        MealTypeEnum mealtype { get; set; } //breakfast, desserts, lunch
       
        DishType dishtype { get; set; } //salads, soup
       
        CookingStyle cookingstyle { get; set; } //vegan, vegeterian, bbq, snacks, diabetic

        uint yield { get; set; }
        
        CookingTime cookingTime { get; set; }
        CookingTime preparationTime { get; set; }
        CookingTime totalTime { get; set; } // cookingTime + preparationTime

        //TODO: Create class Ingridient
        List<string> ingredientsList { get; set; }
        //TODO: Create classes description
        string description { get; set; }

        //TODO: Change type to URL, URI or UriBuilder
        string source { get; set; }
        string videoUrl { get; set; }
    }
}