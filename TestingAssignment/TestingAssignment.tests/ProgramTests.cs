using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment.tests
{
    [TestFixture]
    public class ProgramTests
    {
        public CalculatePremium P = new CalculatePremium();

        [Test]
        public void Test1()
        {
            double expected = 5.0;
            double actual = P.CalcPremium(24, "female");
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test2()
        {
            double expected = 1.75;
            double actual = P.CalcPremium(54, "female");
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test3()
        {
            double expected = 0.0;
            double actual = P.CalcPremium(12, "female");
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test4()
        {
            double expected = 0.0;
            double actual = P.CalcPremium(30, "AlphaMale");
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test5()
        {
            double expected = 6.0;
            double actual = P.CalcPremium(28, "male");
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test6()
        {
            double expected = 5.0;
            double actual = P.CalcPremium(39, "male");
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test7()
        {
            double expected = 0;
            double actual = P.CalcPremium(17, "male");
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test8()
        {
            double expected = 2.5;
            double actual = P.CalcPremium(55, "male");
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
