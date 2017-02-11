using System.Collections.Generic;

namespace Core
{
    //TODO: Create classes for non primitive types and change type from string to created classes
    public interface IRecipe
    {
        string title { get; set; }
        Complexity complexity { get; set; }
        //TODO: Create rating class
        int rating { get; set; }
        //TODO: Create type class
        string type { get; set; } //vegeterian, normal or whatever
        int yield { get; set; }
        //TODO: Create nutrition class
        string nutrition { get; set; }

        //TODO: Create language class  with default value = "en"
        string recipeLanguage { get; set; }

        CookingTime cookingTime { get; set; }
        CookingTime preparationTime { get; set; }
        CookingTime totalTime { get; set; } // cookingTime + preparationTime

        //TODO: Create class Ingridient
        List<string> ingredientsList { get; set; }
        //TODO: Create classes description
        string description { get; set; }

        //TODO: Create class comment
        List<string> comment { get; set; }
        //TODO: Change type to URL, URI or UriBuilder
        string source { get; set; }
        string videoUrl { get; set; }
    }
}