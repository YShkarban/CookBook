using System;
using System.Collections.Generic;
using Core.Model;
using Model;

namespace Core
{
    //TODO: Create classes for non primitive types and change type from string to created classes
    internal interface IRecipe
    {
        string title { get; set; }
        Complexity complexity { get; set; }
      
        Rating rating { get; set; }

        MealType mealType { get; set; } //breakfast, desserts, lunch
       
        DishType dishType { get; set; } //salads, soup
       
        CookingStyle cookingStyle { get; set; } //vegan, vegeterian, bbq, snacks, diabetic

        uint yield { get; set; }
       
        /*
        CookingTime cookingTime { get; set; }
        CookingTime preparationTime { get; set; }
        CookingTime totalTime { get; set; } // cookingTime + preparationTime
        */

        //TODO: Create class Ingridient
        List<string> ingredientsList { get; set; }
        //TODO: Create classes description
        string description { get; set; }

        //TODO: Change type to URL, URI or UriBuilder
        string source { get; set; }
        string videoUrl { get; set; }

        DateTime lastModified { get; }
    }
}