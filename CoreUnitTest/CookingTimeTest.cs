using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;

namespace CoreUnitTest
{
    [TestClass]
    public class CookingTimeTest
    {
        [TestMethod]
        public void ShouldTimeSetToDefault()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime();

            //Assert            
            Assert.AreEqual(0, cookingTime.Minutes);
            Assert.AreEqual(0, cookingTime.Hours);
        }

        [TestMethod]
        public void ShouldSetMinutes()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(10);

            //Assert            
            Assert.AreEqual(10, cookingTime.Minutes);
            Assert.AreEqual(0, cookingTime.Hours);
        }

        [TestMethod]
        public void ShouldSetMinutesAndHour()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(5, 1);

            //Assert            
            Assert.AreEqual(5, cookingTime.Minutes);
            Assert.AreEqual(1, cookingTime.Hours);
        }

        [TestMethod]
        public void ShouldIncrementHour()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(65);

            //Assert            
            Assert.AreEqual(5, cookingTime.Minutes);
            Assert.AreEqual(1, cookingTime.Hours);
        }

        [TestMethod]
        public void ShouldDoubleIncrementHour()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(125, 0);

            //Assert            
            Assert.AreEqual(5, cookingTime.Minutes);
            Assert.AreEqual(2, cookingTime.Hours);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowIllegalArgumentException()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(125, -2);
        }
    }
}
