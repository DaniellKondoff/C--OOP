using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedList.Tests
{
    [TestClass]
    public class CustomLinkedListTest
    {
        [TestMethod]
        public void AddOneElementShouldContainsOneElement()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);

            //Assert
            Assert.AreEqual(1, collection.Count);
        }

        [TestMethod]
        public void AddTwoElementShouldContainsTwoElement()
        {

            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);

            //Assert
            Assert.AreEqual(2, collection.Count);
        }

        [TestMethod]
        public void RemoveAtCurrentIndexShouldRemoveOneElement()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            collection.RemoveAt(1);

            //Assert
            Assert.AreEqual(1,collection.Count);
        }

        [TestMethod]
        public void RemoveAtCurrentIndexShouldReturnElementOnThahPosition()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            collection.RemoveAt(1);

            //Assert
            Assert.AreEqual(5, collection[0]);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtWithBiggerIndexShouldReturnException()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            collection.RemoveAt(3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtNegativeIndexShouldReturnException()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            collection.RemoveAt(-1);
        }

        //RemoveTests

        [TestMethod]
        public void TestRemoveElementShouldRemoveOneElement()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            collection.Remove(5);

            //Assert
            Assert.AreEqual(1, collection.Count);
        }


        [TestMethod]
        public void TestRemoveCurrentElementShouldReturnThatElement()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            collection.Remove(5);

            //Assert
            Assert.AreEqual(6, collection[0]);
        }

        [TestMethod]
        public void TestRemoveNonExistingElementShouldReturnNegativeOne()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            int result=collection.Remove(7);

            //Assert
            Assert.AreEqual(-1, result);
        }

        //IndexOfTests
        [TestMethod]
        public void TestIndexOfExistingElementShouldReturnIndexOfEelement()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            int result=collection.IndexOf(5);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestIndexOfNonExistingElementShouldReturnNegativeOne()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            int result = collection.IndexOf(7);

            //Assert
            Assert.AreEqual(-1, result);
        }

        //ContainsTests
        [TestMethod]
        public void TestContainsExistingElementShouldReturnTrue()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            bool doesContains = collection.Contains(5);

            //Assert
            Assert.IsTrue(doesContains);
        }

        [TestMethod]
        public void TestContainsNonExistingElementShouldReturnFalse()
        {
            //Arrange
            DynamicList<int> collection = new DynamicList<int>();

            //Act
            collection.Add(5);
            collection.Add(6);
            bool doesContains = collection.Contains(7);

            //Assert
            Assert.IsFalse(doesContains);
        }
    }
}
