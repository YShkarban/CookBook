using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace CoreUnitTest
{
    [TestClass]
    public class RecipeBuilderTest
    {
        Recipe defaultRecipe;
        Recipe expectedResult;
        Recipe result;
        IRecipeBuilder builder;

        [TestInitialize()]
        public void CreateDefault()
        {
            //Arrange 
            defaultRecipe = new Recipe();
            defaultRecipe.title = "Sandwitch with salmon";
            defaultRecipe.complexity = Complexity.NotAssigned;
            defaultRecipe.rating = Rating.NotAssigned;
            defaultRecipe.yield = 1;
            defaultRecipe.cookingTime = defaultRecipe.preparationTime =
                defaultRecipe.totalTime = new CookingTime();

            defaultRecipe.ingredientsList = new System.Collections.Generic.List<string>();
            defaultRecipe.description = "";

            expectedResult = defaultRecipe;
            builder = new RecipeBuilder("Sandwitch with salmon");
        }

        [TestMethod]
        public void ShouldSetDefaultsValues()
        {           
            //act
            result = builder.GetResult();

            //assert
            Assert.AreEqual(defaultRecipe, result);
        }

        [TestMethod]
        public void ShouldSetComplexity()
        {
            //Arrange            
            expectedResult.complexity = Complexity.Easy;
           
            //act
            builder.SetComplexity(Complexity.Easy);
            result = builder.GetResult();
            
            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldSetRating()
        {
            //Arrange            
            expectedResult.rating = Rating.Delicious;

            //act
            builder.SetRating(Rating.Delicious);
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldSetCookingStyle()
        {
            //Arrange            
            expectedResult.cookingStyle = CookingStyle.Meat;

            //act
            builder.SetCookingStyle(CookingStyle.Meat);
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldSetMealType()
        {
            //Arrange            
            expectedResult.mealType = MealType.Breakfast;

            //act
            builder.SetMealType(MealType.Breakfast);
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldCookingTypeThrowException()
        {
            //act
            builder.SetCookingTime(null);
        }

        [TestMethod]
        public void ShouldSetCookingTime()
        {
            //Arrange            
            expectedResult.totalTime =  expectedResult.cookingTime = new CookingTime(5);

            //act
            //hack
            builder.GetResult().preparationTime = null;
            builder.SetCookingTime(new CookingTime(5));
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult.totalTime, result.totalTime);
            Assert.AreEqual(expectedResult.cookingTime, result.cookingTime);

            //becaouse of above hack
            Assert.AreEqual(null, result.preparationTime);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldPreparationTypeThrowException()
        {
            //act
            builder.SetPreparationTime(null);
        }

        [TestMethod]
        public void ShouldSetPreparationTime()
        {
            //Arrange            
            expectedResult.totalTime = expectedResult.preparationTime = new CookingTime(5);

            //act
            //hack
            builder.GetResult().cookingTime = null;
            builder.SetPreparationTime(new CookingTime(5));
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult.totalTime, result.totalTime);
            Assert.AreEqual(expectedResult.preparationTime, result.preparationTime);

            //becaouse of above hack
            Assert.AreEqual(null, result.cookingTime);
        }

        [TestMethod]
        public void ShouldSetDishType()
        {
            //Arrange            
            expectedResult.dishType = DishType.FastFood;

            //act
            builder.SetDishType(DishType.FastFood);
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldDescriptionThrowException()
        {
            //act
            builder.SetDescription(null);
        }

        [TestMethod]
        public void ShouldSetEmptyDescription()
        {
            //Arrange            
            expectedResult.description = "";

            //act
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldSetCustomDescription()
        {
            //Arrange            
            expectedResult.description = "Test";

            //act
            builder.SetDescription("Test");
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldIngridientListThrowException()
        {
            //act
            builder.SetIngridientList(null);
        }

        [TestMethod]
        public void ShouldSetCustomIngridientList()
        {
            //TODO: In builder create methods that add and removes ingridients to the ingridient list and than test it
            //Arrange
            expectedResult.ingredientsList.Add("ingridient1");

            //act
            builder.GetResult().ingredientsList.Add("ingridient1");
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldSetTitleThrowException()
        {
            //act
            builder.SetTitle(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldSetEmptyTitleThrowException()
        {
            //act
            builder.SetTitle("");
        }

        [TestMethod]
        public void ShouldSetCustomTitle()
        {
            //act
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldSetVideoUrlThrowException()
        {
            //act
            builder.SetVideoUrl(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldSetEmptyVideoUrlThrowException()
        {
            //act
            builder.SetVideoUrl("");
        }

        [TestMethod]
        public void ShouldSetCustomVideoUrl()
        {
            //Arrange            
            expectedResult.videoUrl = "Test";

            //act
            builder.SetVideoUrl("Test");
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldSetSourceThrowException()
        {
            //act
            builder.SetSource(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldSetEmptySourceThrowException()
        {
            //act
            builder.SetSource("");
        }

        [TestMethod]
        public void ShouldSetCustomSource()
        {
            //Arrange            
            expectedResult.source = "Test";

            //act
            builder.SetSource("Test");
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldSetYield()
        {
            //act
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod]
        public void ShouldCreateCustomRecipe()
        {
            //Arrange
            expectedResult.title = "Steak"; 
            expectedResult.complexity = Complexity.Hard;
            expectedResult.cookingStyle = CookingStyle.Meat;
            expectedResult.cookingTime = new CookingTime(10);
            expectedResult.preparationTime = new CookingTime(10);
            expectedResult.totalTime = expectedResult.cookingTime + expectedResult.preparationTime;
            expectedResult.description = "Delicious beef steak with papper sause";
            expectedResult.dishType = DishType.FastFood;
            expectedResult.ingredientsList = new List<string>();
            expectedResult.ingredientsList.Add("Steak");
            expectedResult.ingredientsList.Add("Garlic");
            expectedResult.rating = Rating.Delicious;
            expectedResult.yield = 1;

            //act
            builder.SetTitle("Pepper Steak");
            builder.SetTitle("Steak");
            builder.SetComplexity(Complexity.Hard);
            builder.SetCookingStyle(CookingStyle.Meat);
            builder.SetPreparationTime(new CookingTime(10));
            builder.SetCookingTime(new CookingTime(10));
            builder.SetDescription("Delicious beef steak with papper sause");
            builder.SetDishType(DishType.FastFood);
            List<string> ingridients = new List<string>();
            ingridients.Add("Steak");
            ingridients.Add("Garlic");
            builder.SetIngridientList(ingridients);
            builder.SetRating(Rating.Delicious);
            builder.SetYield(1);
            result = builder.GetResult();

            //assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldNotInitializeListThrowException()
        {
            //act
            builder.AddIngridient(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldEmptyListThrowException()
        {
            //act
            builder.AddIngridient("");
        }

        [TestMethod]
        public void ShouldInitializeIngridientList()
        {
            //Act
            builder.AddIngridient("ingridient");

            //Assert
            Assert.IsNotNull(builder.GetResult().ingredientsList);
        }

        [TestMethod]
        public void ShouldAddIngridient()
        {
            //Act
            builder.AddIngridient("ingridient");
            var count = builder.GetResult().ingredientsList.Count;

            //Assert
            Assert.AreEqual(1, count);
            Assert.IsTrue(builder.GetResult().ingredientsList.Contains("ingridient"));
        }

        [TestMethod]
        public void ShouldNotBeEqualIFIsNotRecipe()
        {
            //Arrange
            User user = new User();

            //act
            result = builder.GetResult();

            //assert
            Assert.IsFalse(result.Equals(user));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldNotInitializeRemoveIngridientThrowException()
        {
            //act
            builder.RemoveIngridient(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldRemoveEmptyListThrowException()
        {
            //act
            builder.RemoveIngridient("");
        }

        [TestMethod]
        public void ShouldReturnInitializeList()
        {
            //Act

            //hack
            builder.GetResult().ingredientsList = null;
            builder.RemoveIngridient("123");

            //Assert
            Assert.IsNull(builder.GetResult().ingredientsList);
        }

        [TestMethod]
        public void ShouldRemoveIngridient()
        {
            //Arrange
            builder.AddIngridient("ingridient");

            //Act
            builder.RemoveIngridient("ingridient");
            var count = builder.GetResult().ingredientsList.Count;

            //Assert
            Assert.AreEqual(0, count);
            //Assert.IsNotNull(builder.GetResult().ingredientsList.Contains(""));
        }

        [TestMethod]
        public void ShouldIngridientListNotEqual()
        {
           //Arrange
            expectedResult.ingredientsList.Add("meat");

            //act
            result = builder.GetResult();
            builder.AddIngridient("garlic");

            //assert
            Assert.AreNotEqual(expectedResult, result);
        }

        [TestMethod]
        public void ShouldAddIngridientToNotIntitializedList()
        {
            //Arrange
            builder.GetResult().ingredientsList = null;

            //act
            builder.AddIngridient("garlic");

            //assert
            Assert.IsNotNull(builder.GetResult().ingredientsList);
            Assert.AreEqual(builder.GetResult().ingredientsList.Count, 1);
        }

        [TestMethod]
        public void ShouldNotAddExistingIngridient()
        {
            //Arrange

            //act
            builder.AddIngridient("garlic");
            builder.AddIngridient("garlic");

            //assert
            Assert.AreEqual(builder.GetResult().ingredientsList.Count, 1);
            Assert.IsTrue(builder.GetResult().ingredientsList.Contains("garlic"));
        }
    }
}
