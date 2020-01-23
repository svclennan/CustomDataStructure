using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListStringUnitTest
    {
        [TestMethod]
        public void CheckAdd()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expectedResult = "Hello";

            //Act
            myList.Add("Hello");

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void CheckAdd2()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expectedResult = "World";

            //Act
            myList.Add("Hello");
            myList.Add("World");

            //Assert
            Assert.AreEqual(expectedResult, myList[1]);
        }
        [TestMethod]
        public void CheckToString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>() { "Hello", "World", "!"};
            string expectedResult = "HelloWorld!";

            //Act
            myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
    }
}
