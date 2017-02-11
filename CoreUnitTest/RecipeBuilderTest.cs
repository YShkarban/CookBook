using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace CoreUnitTest
{
    [TestClass]
    public class RecipeBuilderTest
    {
        Recipe defaultRecipe;
        Recipe expectedResult;

        [TestInitialize()]
        public void CreateDefault()
        {
            defaultRecipe = new Recipe();

            defaultRecipe.complexity = Complexity.NotAssigned;
            defaultRecipe.rating = Rating.NotAssigned;
            defaultRecipe.yield = 1;
            defaultRecipe.cookingTime = defaultRecipe.preparationTime =
                defaultRecipe.totalTime = new CookingTime();

            defaultRecipe.ingredientsList = new System.Collections.Generic.List<string>();
            defaultRecipe.description = "";
        }

        [TestMethod]
        public void ShouldSetDefaultsValues()
        {
            //Arrange
            defaultRecipe.title = "Sandwitch with salmon";
            IRecipeBuilder builder = new RecipeBuilder("Sandwitch with salmon");
            Recipe result;
            //defaultRecipe.rating = Rating.Delicious;
            
            //act
            //builder.SetRating(Rating.Delicious);
            result = builder.GetResult();


            //assert
            Assert.AreEqual(defaultRecipe, result);
        }
    }
}
