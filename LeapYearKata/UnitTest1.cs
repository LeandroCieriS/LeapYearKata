using LeapYearKata;
using NUnit.Framework;

namespace LeapYearCheckerShould
{
    public class Tests
    {
        [Test]
        [TestCase(400)]
        [TestCase(800)]
        [TestCase(1200)]
        public void Check_year_divisible_by_400_as_leap_year(int inputYear)
        {

            var result = LeapYearChecker.IsLeapYear(inputYear);

            Assert.True(result);
        }

        [Test]
        [TestCase(100)]
        [TestCase(200)]
        [TestCase(300)]
        public void Check_year_divisible_by_100_but_not_by_400_as_normal_year(int inputYear)
        {

            var result = LeapYearChecker.IsLeapYear(inputYear);

            Assert.False(result);
        }

        [Test]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(16)]
        public void Check_year_divisible_by_4_but_not_by_100_as_leap_year(int inputYear)
        {

            var result = LeapYearChecker.IsLeapYear(inputYear);

            Assert.True(result);
        }

        [Test]
        [TestCase(3)]
        [TestCase(1955)]
        [TestCase(2021)]
        public void Check_years_not_divisible_by_4_as_normal_years(int inputYear)
        {

            var result = LeapYearChecker.IsLeapYear(inputYear);

            Assert.False(result);
        }
    }
}