using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _03.Iterator.Tests
{
    [TestClass]
    public class ListIteratortTest
    {
        private ListIteretor listIteretor;

        [TestInitialize]
        public void Init()
        {
            this.listIteretor = new ListIteretor();
        }

        [TestMethod]
        public void ConstructorShouldInitializeCollectionWithGivenNonEmptyCollection()
        {
            List<string> expected = new List<string>() { "Psho","Stamant" };
            this.listIteretor = new ListIteretor(expected);
            CollectionAssert.AreEqual(expected, this.listIteretor.Collection, "Collections are not equal");
        }

        [TestMethod]
        public void ConstructorShouldInitializeCollectionWithGivenEmptyCollection()
        {
            List<string> expected = new List<string>();
            this.listIteretor = new ListIteretor(expected);
            Assert.AreEqual(0, this.listIteretor.Collection.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorShouldTrhowWithNullCollection()
        {
            List<string> expected = null;
            this.listIteretor = new ListIteretor(expected);
        }

        //MoveTests
        [TestMethod]
        public void OneMoveWithTwoElementsShouldReturnTrue()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            bool hasMoved = this.listIteretor.Move();
            Assert.IsTrue(hasMoved);
        }

        [TestMethod]
        public void TwoMoveWithTwoElementsShouldReturnFalse()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            this.listIteretor.Move();
            bool hasMoved = this.listIteretor.Move();
            Assert.IsFalse(hasMoved);
        }

        [TestMethod]
        public void OneMoveShouldMoveInternelIndexByOne()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            int beforeMoveindex = this.listIteretor.CurrentIndex;
            this.listIteretor.Move();
            int afterMoveindex = this.listIteretor.CurrentIndex;
            Assert.AreEqual(0, beforeMoveindex);
            Assert.AreEqual(1, afterMoveindex,"Move does not move the internal Index");
        }

        [TestMethod]
        public void TwoMoveShouldMoveInternelIndexByOne()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            int beforeMoveindex = this.listIteretor.CurrentIndex;
            this.listIteretor.Move();
            this.listIteretor.Move();
            int afterMoveindex = this.listIteretor.CurrentIndex;
            Assert.AreEqual(0, beforeMoveindex);
            Assert.AreEqual(1, afterMoveindex, "Move does not move the internal Index");
        }

        //HasNextTest
        [TestMethod]
        public void HasNextWithNoMoveOnCollectionWithTwoElementsShouldReturnTrue()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            bool hasNext = this.listIteretor.HasNext();
            Assert.IsTrue(hasNext);
        }

        [TestMethod]
        public void HasNextWithOneMoveOnCollectionWithTwoElementsShouldReturnFalse()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            this.listIteretor.Move();
            bool hasNext = this.listIteretor.HasNext();
            Assert.IsFalse(hasNext);
        }

        //PrintTests
        [TestMethod]
        public void PrintWithNoMoveShouldreturn0thElement()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            string actual = this.listIteretor.Print();
            Assert.AreEqual(expected[0], actual);
        }

        [TestMethod]
        public void PrintWithOneMoveShouldreturn1stElement()
        {
            List<string> expected = new List<string>() { "Psho", "Stamant" };
            this.listIteretor = new ListIteretor(expected);
            this.listIteretor.Move();
            string actual = this.listIteretor.Print();
            Assert.AreEqual(expected[1], actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PrintEmptyCollectionShouldThrow()
        {
            List<string> expected = new List<string>();
            this.listIteretor = new ListIteretor(expected);
            this.listIteretor.Print();
        }
    }
}
