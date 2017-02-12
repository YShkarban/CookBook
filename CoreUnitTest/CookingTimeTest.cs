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

        [TestMethod]
        public void ShouldTotalTimeEqualsZeroWhenAddition()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime();
            CookingTime preparationTime = new CookingTime();
            CookingTime totalTime;

            //act
            totalTime = cookingTime + preparationTime;

            //Assert            
            Assert.AreEqual(0, totalTime.Minutes);
            Assert.AreEqual(0, totalTime.Hours);
        }

        [TestMethod]
        public void ShouldIncrementHourWhenAddition()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(50);
            CookingTime preparationTime = new CookingTime(50);
            CookingTime totalTime;

            //act
            totalTime = cookingTime + preparationTime;

            //Assert            
            Assert.AreEqual(40, totalTime.Minutes);
            Assert.AreEqual(1, totalTime.Hours);
        }

        [TestMethod]
        public void ShouldIncrementHourWhenAdditionV2()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(40);
            CookingTime preparationTime = new CookingTime(20);
            CookingTime totalTime;

            //act
            totalTime = cookingTime + preparationTime;

            //Assert            
            Assert.AreEqual(0, totalTime.Minutes);
            Assert.AreEqual(1, totalTime.Hours);
        }

        [TestMethod]
        public void ShouldIncrementHourWhenAdditionV3()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(70);
            CookingTime preparationTime = new CookingTime(90);
            CookingTime totalTime;

            //act
            totalTime = cookingTime + preparationTime;

            //Assert            
            Assert.AreEqual(40, totalTime.Minutes);
            Assert.AreEqual(2, totalTime.Hours);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowArgumentException()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(50);
            CookingTime preparationTime = new CookingTime(50,-2);
            CookingTime totalTime;

            //act
            totalTime = cookingTime + preparationTime;
        }

        [TestMethod]
        public void ShouldReturnStringHoursAndMinutes()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(2, 2);

            //Assert            
            Assert.AreEqual("2h 2m", cookingTime.ToString());
           
        }

        [TestMethod]
        public void ShouldReturnStringHours()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(0, 2);

            //Assert            
            Assert.AreEqual("2h", cookingTime.ToString());

        }

        [TestMethod]
        public void ShouldReturnStringMinutes()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(2);

            //Assert            
            Assert.AreEqual("2m", cookingTime.ToString());

        }

        [TestMethod]
        public void ShouldReturnEmptyString()
        {
            //Arrange
            CookingTime cookingTime = new CookingTime(0);

            //Assert            
            Assert.AreEqual("", cookingTime.ToString());
        }


        [TestMethod]
        public void ShouldNotBeEqual()
        {
            //Arrange
            CookingTime cookingTime1 = new CookingTime(0);
            CookingTime cookingTime2 = new CookingTime(5);

            //Assert            
            Assert.AreNotEqual(cookingTime1, cookingTime2);
        }
    }
}
