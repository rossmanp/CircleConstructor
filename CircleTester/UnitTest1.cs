using System;
using NUnit.Framework;
using GC_Lab9_CircleCalcs;

namespace CircleTester
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestArea()
        {
            //arrange
            double expected = 25 * Math.PI;
            Circle test = new Circle(5);
            //assess
            //act
            Assert.AreEqual(expected, test.GetArea(), 0.01, "whoops!");
        }
    }
}
