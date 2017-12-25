using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyList.Tests
{
    public static class MyListFactory
    {
        public static IMyList CreateWithFiveCapacity()
        {
            return new MyList(5);
        }
    }


    [TestClass]
    public class Add
    {
        [TestMethod]
        public void Should_add()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();

            // Act
            list.Add(10);
            list.Add(20);

            // Assert
            Assert.AreEqual(list[0], 10);
        }

        [TestMethod]
        public void Should_change_count()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();

            // Act
            list.Add(10);
            list.Add(20);

            // Assert
            Assert.AreEqual(list.Length, 2);
        }

        [TestMethod]
        public void Should_be_flexible()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();

            // Act
            for (int val = 1; val <= 20; val++)
            {
                list.Add(val);
            }

            // Assert
            Assert.AreEqual(list.Length, 20);
        }
    }


    [TestClass]
    public class Index
    {
        [TestMethod]
        public void Should_get()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);

            // Act
            var val = list[0];

            // Assert         
            Assert.AreEqual(val, 10);
        }

        [TestMethod]
        public void Should_set()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);

            // Act
            list[0] = 20;

            // Assert
            Assert.AreEqual(list[0], 20);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(2)]
        [DataRow(10)]
        public void Should_throw_argument_exception_if_invalid_index(int index)
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act -> Assert
            Assert.ThrowsException<ArgumentException>(() => list[index]);
        }
    }


    [TestClass]
    public class Insert
    {
        [TestMethod]
        public void Should_insert()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act
            list.Insert(0, 0);
            list.Insert(1, 30);
            list.Insert(3, 40);

            // Assert
            Assert.AreEqual(list[1], 30);
        }

        [TestMethod]
        public void Should_change_count()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act
            list.Insert(0, 0);
            list.Insert(1, 30);
            list.Insert(3, 40);

            // Assert
            Assert.AreEqual(list.Length, 5);
        }

        [TestMethod]
        public void Should_be_flexible()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);

            // Act
            for (int val = 1; val < 20; val++)
            {
                list.Insert(0, val);
            }

            // Assert
            Assert.AreEqual(list.Length, 20);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(2)]
        [DataRow(10)]
        public void Should_throw_argument_exception_if_invalid_index(int index)
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act -> Assert
            Assert.ThrowsException<ArgumentException>(() => list.Insert(index, 30));
        }
    }


    [TestClass]
    public class RemoveAt
    {
        [TestMethod]
        public void Should_remove()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act
            list.RemoveAt(0);

            // Assert
            Assert.AreEqual(list[0], 20);
        }

        [TestMethod]
        public void Should_change_count()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act
            list.RemoveAt(0);

            // Assert
            Assert.AreEqual(list.Length, 1);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(2)]
        [DataRow(10)]
        public void Should_throw_argument_exception_if_invalid_index(int index)
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act -> Assert
            Assert.ThrowsException<ArgumentException>(() => list.RemoveAt(index));
        }
    }


    [TestClass]
    public class Contains
    {
        [TestMethod]
        public void Should_return_true_if_contains()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act
            var contains = list.Contains(10);

            // Assert
            Assert.AreEqual(contains, true);
        }

        [TestMethod]
        public void Should_return_false_if_not_contains()
        {
            // Arrange
            var list = MyListFactory.CreateWithFiveCapacity();
            list.Add(10);
            list.Add(20);

            // Act
            var contains = list.Contains(-10);

            // Assert
            Assert.AreEqual(contains, false);
        }
    }
}
