using System;
using NUnit.Framework;
using RandomData;

namespace UnitTestsExerciseOne
{
    public class Tests
    {
        private TestThisProject _testThisProject;
        [SetUp]
        public void Setup()
        {
            _testThisProject = new TestThisProject();
        }
        [Test]
        public void IsCostNull()
        {
            var result = _testThisProject.TotalCost(5, 10);
            Assert.That(result,Is.Not.Null);
        }
        [Test]
        public void IsCostADouble()
        {
            var result = _testThisProject.TotalCost(5, 10);
            Assert.That(result,Is.TypeOf<double>());
        }
        [Test]
        public void IsKilometersLessThan100()
        {
            var result = _testThisProject.TotalCost(1000, 99);
            Assert.That(result,Is.EqualTo(446.8));
        }
        [Test]
        public void IsKilometersBetween100And500WithLessThan12Passengers()
        {
            var result = _testThisProject.TotalCost(11, 250);
            Assert.That(result,Is.EqualTo(817.5));
        }
        [Test]
        public void IsKilometersBetween100And500WithMoreThan12Passengers()
        {
            var result = _testThisProject.TotalCost(15, 250);
            Assert.That(result,Is.EqualTo(880.0));
        }
        [Test]
        public void IsKilometersHigherThan500()
        {
            var result = _testThisProject.TotalCost(50, 1000);
            Assert.That(result,Is.EqualTo(2380.0));
        }
    }
}