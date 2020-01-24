using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        
        [TestMethod]
        public void CheckRemove()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Remove(5);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckRemoveCount()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Remove(5);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckRemoveSecondValueGetFirstValue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Remove(10);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckRemoveSecondValueCheckNewSecondValue()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 15;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Remove(10);
            actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckCapacityAfterRemovingFifthItem()
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
            myList.Remove(25);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckRemoveItemNotInList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(25);
            myList.Remove(50);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckRemoveItemFromMultiples()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int actual;

            //Act
            myList.Add(5);
            myList.Add(25);
            myList.Add(25);
            myList.Add(25);
            myList.Add(25);
            myList.Remove(25);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            string expected = "1234";
            string actual;

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckToStringString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string expected = "HelloWorld!";
            string actual;

            //Act
            myList.Add("Hello");
            myList.Add("World");
            myList.Add("!");
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckEmptyToString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            string expected = "";
            string actual;

            //Act
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckOverloadPlus()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> myList2 = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actual;

            //Act
            actual = myList1 + myList2;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadPlusThreeLists()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> actual;

            //Act
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(4);
            myList2.Add(5);
            myList3.Add(7);
            myList3.Add(8);
            expected.Add(1);
            expected.Add(2);
            expected.Add(4);
            expected.Add(5);
            expected.Add(7);
            expected.Add(8);
            actual = myList1 + myList2 + myList3;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        /*
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
