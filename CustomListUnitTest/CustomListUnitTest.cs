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
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;

            //Act
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(3);
            myList2.Add(4);
            myList2.Add(5);
            myList2.Add(6);
            expectedList.Add(1);
            expectedList.Add(2);
            expectedList.Add(3);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(6);
            expected = expectedList.ToString();
            actual = (myList1 + myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void CheckOverloadPlusString()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myList2 = new CustomList<string>();
            CustomList<string> expectedList = new CustomList<string>();
            string expected;
            string actual;

            //Act
            myList1.Add("string");
            myList1.Add("string2");
            myList2.Add("string3");
            myList2.Add("string4");
            expectedList.Add("string");
            expectedList.Add("string2");
            expectedList.Add("string3");
            expectedList.Add("string4");
            expected = expectedList.ToString();
            actual = (myList1 + myList2).ToString();

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
            CustomList<int> expectedList = new CustomList<int>();
            string expected;
            string actual;

            //Act
            myList1.Add(1);
            myList1.Add(2);
            myList2.Add(4);
            myList2.Add(5);
            myList3.Add(7);
            myList3.Add(8);
            expectedList.Add(1);
            expectedList.Add(2);
            expectedList.Add(4);
            expectedList.Add(5);
            expectedList.Add(7);
            expectedList.Add(8);
            expected = expectedList.ToString();
            actual = (myList1 + myList2 + myList3).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadPlusStringListOfDifferentLenght()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myList2 = new CustomList<string>();
            CustomList<string> expectedList = new CustomList<string>();
            string expected;
            string actual;

            //Act
            myList1.Add("string");
            myList2.Add("string1");
            myList2.Add("string2");
            expectedList.Add("string");
            expectedList.Add("string1");
            expectedList.Add("string2");
            expected = expectedList.ToString();

            actual = (myList1 + myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadPlusListAndEmptyList()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myList2 = new CustomList<string>();
            CustomList<string> expectedList = new CustomList<string>();
            string expected;
            string actual;

            //Act
            myList1.Add("string");
            expectedList.Add("string");
            expected = expectedList.ToString();

            actual = (myList1 + myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckOverloadMinus()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            string expected = "1";
            string actual;

            //Act
            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(3);
            myList2.Add(2);
            myList2.Add(3);
            myList2.Add(4);

            actual = (myList1 - myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusNoValuesSubtracted()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            string expected = "123";
            string actual;

            //Act
            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(3);

            actual = (myList1 - myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusStrings()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myList2 = new CustomList<string>();
            string expected = "catbird";
            string actual;

            //Act
            myList1.Add("cat");
            myList1.Add("dog");
            myList1.Add("bird");
            myList2.Add("dog");

            actual = (myList1 - myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusDuplicates()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myList2 = new CustomList<string>();
            string expected = "catdog";
            string actual;

            //Act
            myList1.Add("cat");
            myList1.Add("dog");
            myList1.Add("dog");
            myList2.Add("dog");

            actual = (myList1 - myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusDuplicatesInts()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            string expected = "12";
            string actual;

            //Act
            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(2);
            myList2.Add(2);

            actual = (myList1 - myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusEmptyStartingList()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myList2 = new CustomList<string>();
            string expected = "";
            string actual;

            //Act
            myList2.Add("dog");

            actual = (myList1 - myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusEmptyStartingListInts()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            string expected = "";
            string actual;

            //Act
            myList2.Add(1);

            actual = (myList1 - myList2).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusThreeValues()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myList2 = new CustomList<string>();
            CustomList<string> myList3 = new CustomList<string>();
            string expected = "cat";
            string actual;

            //Act
            myList1.Add("cat");
            myList1.Add("dog");
            myList1.Add("bird");
            myList2.Add("dog");
            myList3.Add("bird");

            actual = (myList1 - myList2 - myList3).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckOverloadMinusThreeValuesInts()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myList2 = new CustomList<int>();
            CustomList<int> myList3 = new CustomList<int>();
            string expected = "1";
            string actual;

            //Act
            myList1.Add(1);
            myList1.Add(2);
            myList1.Add(3);
            myList2.Add(2);
            myList3.Add(3);

            actual = (myList1 - myList2 - myList3).ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /*
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
