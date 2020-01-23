using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListUnitTest
    {
        [TestMethod]
        public void CheckAdd()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            myList.Add(5);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckAdd2Values()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckAddString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected = "Hello";
            string actual;

            //Act
            myList.Add("Hello");
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckAddCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckAddCapacityFor5Values()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 8;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);
            myList.Add(30);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckAddValuesAfterMaxCapacity()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 25;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);
            myList.Add(30);
            actual = myList[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckAddCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //APPROVED TO HERE
        /*
        [TestMethod]
        public void CheckCapacityWhenEmpty()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 0;
            int actualResult;

            //Act
            actualResult = myList.Capacity;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void CheckRemove()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int secondValue = 10;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Remove(5);

            //Assert
            Assert.AreEqual(secondValue, myList[0]);
        }
        [TestMethod]
        public void CheckRemoveSecondValueCheckFirstValue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 5;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Remove(1);

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void CheckRemoveSecondValueCheckNewSecondValue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expectedResult = 15;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Remove(1);

            //Assert
            Assert.AreEqual(expectedResult, myList[1]);
        }
        [TestMethod]
        public void CheckOverloadPlus()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> myList2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ExpectedResult = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> ActualResult;

            //Act
            ActualResult = myList1 + myList2;

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [TestMethod]
        public void CheckOverloadMinus()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> myList2 = new CustomList<int>() { 2, 3, 4 };
            CustomList<int> ExpectedResult = new CustomList<int>() { 1 };
            CustomList<int> ActualResult;

            //Act
            ActualResult = myList1 - myList2;

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [TestMethod]
        public void CheckZip()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> myList2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> ExpectedResult = new CustomList<int>() { 1, 4, 2, 5, 3, 6 };
            CustomList<int> ActualResult;

            //Act
            ActualResult = myList1.Zip(myList2);

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [TestMethod]
        public void CheckToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>() { 1, 2, 3, 4 };
            string ExpectedResult = "1234";
            string ActualResult;

            //Act
            ActualResult = myList.ToString();

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [TestMethod]
        public void CheckToStringString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>() { "Hello", "World", "!" };
            string expectedResult = "HelloWorld!";

            //Act
            myList.ToString();

            //Assert
            Assert.AreEqual(expectedResult, myList[0]);
        }
        [TestMethod]
        public void CheckEmptyToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            string ExpectedResult = "";
            string ActualResult;

            //Act
            ActualResult = myList.ToString();

            //Assert
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CheckIndexOutOfBounds()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int index = 3;

            //Act
            int value = myList[index];
        }
        */
    }
}
