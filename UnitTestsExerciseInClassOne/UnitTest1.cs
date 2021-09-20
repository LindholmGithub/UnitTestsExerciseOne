using GradeData;
using NUnit.Framework;

namespace UnitTestsExerciseInClassOne
{
    public class Tests
    {
        private Class1 _testThisProject;
        [SetUp]
        public void Setup()
        {
            _testThisProject = new Class1();
        }

        [Test]
        public void TestGradeMinusThree()
        {
            var expectedResult = -3;
            var input = 1;
            Assert.That(expectedResult, Is.EqualTo(_testThisProject.ToGrade(input)));
        }
        [Test]
        public void TestGradeZero()
        {
            var expectedResult = 0;
            var input = 40;
            Assert.That(expectedResult, Is.EqualTo(_testThisProject.ToGrade(input)));
        }
        [Test]
        public void TestGradeTwo()
        {
            var expectedResult = 2;
            var input = 55;
            Assert.That(expectedResult, Is.EqualTo(_testThisProject.ToGrade(input)));
        }
        [Test]
        public void TestGradeFour()
        {
            var expectedResult = 4;
            var input = 69;
            Assert.That(expectedResult, Is.EqualTo(_testThisProject.ToGrade(input)));
        }
        [Test]
        public void TestGradeSeven()
        {
            var expectedResult = 7;
            var input = 82;
            Assert.That(expectedResult, Is.EqualTo(_testThisProject.ToGrade(input)));
        }
        [Test]
        public void TestGradeTen()
        {
            var expectedResult = 10;
            var input = 92;
            Assert.That(expectedResult, Is.EqualTo(_testThisProject.ToGrade(input)));
        }
        [Test]
        public void TestGradeTwelve()
        {
            var expectedResult = 12;
            var input = 98;
            Assert.That(expectedResult, Is.EqualTo(_testThisProject.ToGrade(input)));
        }
    }
}