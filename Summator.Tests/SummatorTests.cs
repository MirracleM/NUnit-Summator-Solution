using NUnit.Framework;

namespace Summator
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            long actual  = Summator.Sum(new int[] { 5, 7 });
            int expected = 12;
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });
            Assert.That(actual == 5);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });
            Assert.That(actual == -16);
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });
            Assert.That(actual == 0);
        }
        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(8000000000, actual);
        }
        [Test]
        public void Test_Average_TwoPositiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;
            Assert.That(expected == actual);
        }

        //My tests
        [Test]
        public void Test_Sum_TwoOddNumbers()
        {
            long actual = Summator.Sum(new int[] { 3, 5 });
            Assert.That(actual == 8);
        }

        [Test]
        public void Test_Sum_TwoEvenNumbers()
        {
            long actual = Summator.Sum(new int[] { 66, 88 });
            Assert.That(actual == 154);
        }

        [Test]
        public void Test_Average_ThreeOddNumbers()
        {
            int actual = Summator.Average(new int[] { 45, 55, 65 });
            int expected = 55;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Average_FiveEvenNumbers()
        {
            int actual = Summator.Average(new int[] { 20, 30, 40, 50, 60 });
            int expected = 40;
            Assert.That(expected == actual);
        }
        //
        //[Test]
        //public void Test_Average_OddAndEvenNumbers()
        //{
            //int actual = Summator.Average(new int[] { 5, 6 });
            //double expected = 5.5;
            //Assert.That(expected == actual);
        //}
    }
}