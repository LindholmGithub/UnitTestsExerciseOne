using NUnit.Framework;
using RandomDataTwo;

namespace UnitTestsExerciseTwo
{
    public class Tests
    {
        private TestThisProjectTwo _testThisProjectTwo;

        [SetUp]
        public void Setup()
        {
            _testThisProjectTwo = new TestThisProjectTwo();
        }

        [Test]
        public void DoesArrayContainNumber20OrHigher()
        {
            double[] rain = { 5, 10, 15, 20, 25};
            int expectedResult = 4;
            Assert.AreEqual(_testThisProjectTwo.ContainsCloudburst(rain), expectedResult);
        }
        [Test]
        public void DoesArrayNotContainNumber20OrHigher()
        {
            double[] rain = { 5, 10, 15, 16, 17};
            int expectedResult = -1;
            Assert.AreEqual(_testThisProjectTwo.ContainsCloudburst(rain), expectedResult);
        }
    }
}