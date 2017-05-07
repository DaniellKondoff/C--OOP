using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01.Database.Tests
{
    [TestClass]
    public class TestDb
    {
        Database db;

        [TestInitialize]
        public void TestInitialize()
        {
            this.db = new Database(new int[] { 1, 2, 3, 4 });
        }


        [TestMethod]
        public void TestDbCapacity()
        {
            Assert.AreEqual(16, db.Capacity, "Db capacity is not 16");
        }

        [TestMethod]
        public void TestAddOneEelement()
        {
            db.Add(10);
            Assert.AreEqual(1, db.Count);
        }

        [TestMethod]
        public void TestAddSeveralElements()
        {
            db.Add(10);
            db.Add(7);
            db.Add(20);
            Assert.AreEqual(3, db.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddMoreElementsThanCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                db.Add(i);
            }
        }

        [TestMethod]
        public void TestRemoveOneEelement()
        {
            db.Add(10);
            db.Remove();
            Assert.AreEqual(0, db.Count);
        }

        [TestMethod]
        public void TestConstructorValidParameters()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            db = new Database(numbers);
            CollectionAssert.AreEqual(numbers, db.Elements);
        }
    }
}
