using System;
using Core;
using Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Core.UnitTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void ShouldCreateUser()
        {
            //Arrange
            User user;
            
            //Act
            user = new User();

            //Assert
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void ShouldIngridientListInitialize()
        {
            //Arrange
            User user;
            
            //Act
            user = new User();

            //Assert
            Assert.IsNotNull(user.CookBookInstance);
        }
    }
}
