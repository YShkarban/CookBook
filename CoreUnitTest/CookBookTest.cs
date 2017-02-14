using System;
using System.CodeDom;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core
{
    [TestClass]
    public class CookBookTest
    {
        private Recipe _recipe1;
        private Recipe _recipe2;
        private CookBook _cookBook;

        [TestInitialize()]
        public void CreateDefault()
        {
            //Arrange 
            RecipeBuilder builder = new RecipeBuilder("DefaultRecipe");

            _recipe1 = builder.GetResult();

            builder.SetTitle("CustomRecipe");
            _recipe2 = builder.GetResult();

            _cookBook = new CookBook();
            _cookBook.ListOfRecipes.Add(_recipe1);
            _cookBook.ListOfRecipes.Add(_recipe2);

            //Assert
        }

        [TestMethod]
        public void ShouldAddRecipe()
        {
            //Arrange 
            var recipesCount = _cookBook.ListOfRecipes.Count;
            RecipeBuilder builder = new RecipeBuilder("Sandwitch");

            //Act
            var _recipe3 = builder.GetResult();
            var result = _cookBook.AddRecipe(_recipe3);

            //Assert
            Assert.AreEqual(recipesCount+1, _cookBook.ListOfRecipes.Count);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotAddRecipe()
        {
            //Arrange 
            var recipesCount = _cookBook.ListOfRecipes.Count;

            //Act
            var result = _cookBook.AddRecipe(_recipe1);

            //Assert
            Assert.AreEqual(recipesCount, _cookBook.ListOfRecipes.Count);
            Assert.IsFalse(result);
        }



        [TestMethod]
        public void ShouldRemoveRecipe()
        {
            //Arrange 
            var recipesCount = _cookBook.ListOfRecipes.Count;

            //Act
            var result = _cookBook.RemoveRecipe(_recipe2);

            //Assert
            Assert.AreEqual(recipesCount -1, _cookBook.ListOfRecipes.Count);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldNotRemoveRecipe()
        {
            //Arrange 
            var recipesCount = _cookBook.ListOfRecipes.Count;
            RecipeBuilder builder = new RecipeBuilder("Sandwitch");

            //Act
            var _recipe3 = builder.GetResult();
            var result = _cookBook.RemoveRecipe(_recipe3);

            //Assert
            Assert.AreEqual(recipesCount, _cookBook.ListOfRecipes.Count);
            Assert.IsFalse(result);
            
        }
    }
}
