using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace CoreUnitTest
{
    [TestClass]
    public class RecipeBuilderTest
    {
        Recipe defaultRecipe;

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

            //act
            result = builder.GetResult();

            //assert
            Assert.AreEqual(defaultRecipe.title, result.title);
            Assert.AreEqual(defaultRecipe.complexity, result.complexity);
            Assert.AreEqual(defaultRecipe.cookingStyle,  result.cookingStyle);
            Assert.AreEqual(defaultRecipe.cookingTime,  result.cookingTime);
            Assert.AreEqual(defaultRecipe.description, result.description);
            Assert.AreEqual(defaultRecipe.dishType, result.dishType);
            Assert.AreEqual(defaultRecipe.ingredientsList.Count, result.ingredientsList.Count);
            Assert.AreEqual(defaultRecipe.mealType, result.mealType);
            Assert.AreEqual(defaultRecipe.preparationTime, result.preparationTime);
            Assert.AreEqual(defaultRecipe.rating, result.rating);
            Assert.AreEqual(defaultRecipe.source, result.source);
            Assert.AreEqual(defaultRecipe.totalTime, result.totalTime);
            Assert.AreEqual(defaultRecipe.videoUrl, result.videoUrl);
            Assert.AreEqual(defaultRecipe.yield, result.yield);
        }
    }
}
