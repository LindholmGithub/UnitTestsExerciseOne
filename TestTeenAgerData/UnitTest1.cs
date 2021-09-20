using System;
using NUnit.Framework;
using TeenagerData;

namespace TestTeenagerData
{
    public class Tests
    {
        private TeenAgerData _teenData;
        [SetUp]
        public void Setup()
        {
            _teenData = new TeenAgerData();
        }

        [Test]
        public void IsTeenager()
        {
            DateTime input = new DateTime(2006,10,10);
            Assert.IsTrue(_teenData.IsTeenager(input));
        }
        [Test]
        public void IsNotTeenagerUnder13()
        {
            DateTime input = new DateTime(2020,10,10);
            Assert.IsFalse(_teenData.IsTeenager(input));
        }
        [Test]
        public void IsNotTeenagerOver19()
        {
            DateTime input = new DateTime(1993,10,10);
            Assert.IsFalse(_teenData.IsTeenager(input));
        }
    }
}