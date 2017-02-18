using System;
using Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreUnitTest
{
    [TestClass]
    public class CoreModelTests
    {
        [TestMethod]
        public void ShouldCreateUserAndCookBook()
        {
            //Arrange
            User user = new User("zingler", "123123");
            CookBook CookBook = new CookBook(user);

            //Assert
            Assert.IsNotNull(CookBook.User);
            Assert.IsNotNull(user.CookBook);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullExceptionWhenEmptyUser()
        {
            CookBook cookBook = new CookBook(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullExceptionWhenEmptyCookBook()
        {
            User user = new User("test", "test", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowArgumentNullExceptionWhenSetNullUser()
        {
            //Arrange
            CookBook cookBook = new CookBook(new User("test", "test"));

            //Act
            cookBook.SetUser(null);
        }
        [TestMethod]
        public void ShouldSetUser()
        {
            //Arrange
            //Act
            // Assert
        }
        [TestMethod]
        public void ShouldCreateUser5()
        {
            //Arrange
            //Act
            // Assert
        }
        [TestMethod]
        public void ShouldCreateUser6()
        {
            //Arrange
            //Act
            // Assert
        }
        [TestMethod]
        public void ShouldCreateUser7()
        {
            //Arrange
            //Act
            // Assert
        }

    }
}
