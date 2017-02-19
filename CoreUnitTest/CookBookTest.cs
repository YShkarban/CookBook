using System;
using System.CodeDom;
using Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core
{
    [TestClass]
    public class CookBookTest
    {
        private Recipe _recipe1;
        private Recipe _recipe2;
        private User _user;

        [TestInitialize()]
        public void CreateDefault()
        {
            //Arrange 
            RecipeBuilder builder = new RecipeBuilder("DefaultRecipe", new User("test", "test"));

            _recipe1 = builder.GetResult();

            builder.SetTitle("CustomRecipe");
            _recipe2 = builder.GetResult();

            _user = new User("test", "test");
            _user.Recipes.Add(_recipe1);
            _user.Recipes.Add(_recipe2);

            //Assert
        }

        [TestMethod]
        public void ShouldAddRecipe()
        {
            //Arrange 
            var recipesCount = _user.Recipes.Count;
            RecipeBuilder builder = new RecipeBuilder("Sandwitch", new User("test", "test"));

            //Act
            var _recipe3 = builder.GetResult();
            var result = _user.AddRecipe(_recipe3);

            //Assert
            Assert.AreEqual(recipesCount+1, _user.Recipes.Count);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotAddRecipe()
        {
            //Arrange 
            var recipesCount = _user.Recipes.Count;

            //Act
            var result = _user.AddRecipe(_recipe1);

            //Assert
            Assert.AreEqual(recipesCount, _user.Recipes.Count);
            Assert.IsFalse(result);
        }



        [TestMethod]
        public void ShouldRemoveRecipe()
        {
            //Arrange 
            var recipesCount = _user.Recipes.Count;

            //Act
            var result = _user.RemoveRecipe(_recipe2);

            //Assert
            Assert.AreEqual(recipesCount -1, _user.Recipes.Count);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotRemoveRecipe()
        {
            //Arrange 
            var recipesCount = _user.Recipes.Count;
            RecipeBuilder builder = new RecipeBuilder("Sandwitch", new User("test", "test"));

            //Act
            var _recipe3 = builder.GetResult();
            var result = _user.RemoveRecipe(_recipe3);

            //Assert
            Assert.AreEqual(recipesCount, _user.Recipes.Count);
            Assert.IsFalse(result);
            
        }
    }
}
