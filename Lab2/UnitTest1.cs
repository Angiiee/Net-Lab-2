using Circle;
using Circle.entity;
using Circle.logic;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private List<CircleItem> items;

        [SetUp]
        public void Setup()
        {
            items = new List<CircleItem>
            {
                new CircleItem(new Point(2, 3), 5),
                new CircleItem(new Point(2, 3), 6),
                new CircleItem(new Point(2, 3), 9),
                new CircleItem(new Point(3, 3), 3),
                new CircleItem(new Point(2, 3), 2),
                new CircleItem(new Point(10, 3), 9)
            };
        }

        [Test]
        public void TestFindkCirclesMaxSquare()
        {
            Assert.AreEqual(2, CircleLogic.FindCirclesMaxSquare(items).Count);
        }

        [Test]
        public void TestFindCirclesMaxPerimeter()
        {
            Assert.AreEqual(2, CircleLogic.FindCirclesMaxPerimeter(items).Count);
        }

        [Test]
        public void TestCheckCirclesOnOneLine()
        {
            Assert.AreEqual(1, CircleLogic.CheckCirclesOnOneLine(items).Count);
            items.Add(new CircleItem(new Point(4, 7), 3));
            Assert.AreEqual(2, CircleLogic.CheckCirclesOnOneLine(items).Count);
        }
    }
}