using DesignCrowd.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DesignCrowd.Test.Services.HolidayTests
{
    [TestFixture]
    public class ChristianPublicHolidayServiceTest
    {
        private ChristianPublicHolidayService _christianPublicHolidayService;

        [SetUp]
        public void SetUp()
        {
            _christianPublicHolidayService = new ChristianPublicHolidayService();
        }

        [Test]
        [TestCase(2021, 12, 27)]
        [TestCase(2022, 12, 26)]
        public void ReturnsChristmasDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _christianPublicHolidayService.Christmas(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 12, 27)]
        [TestCase(2020, 12, 28)]
        public void ReturnsBoxingDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _christianPublicHolidayService.BoxingDay(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 2)]
        [TestCase(2020, 4, 10)]
        public void ReturnsGoodFridayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _christianPublicHolidayService.GoodFriday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 3)]
        [TestCase(2022, 4, 16)]
        public void ReturnsEasterSaturdayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _christianPublicHolidayService.EasterSaturday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 4)]
        [TestCase(2022, 4, 17)]
        public void ReturnsEasterSundayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _christianPublicHolidayService.EasterSunday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 5)]
        [TestCase(2022, 4, 18)]
        public void ReturnsEasterMondayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _christianPublicHolidayService.EasterMonday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsAllChristianHolidays()
        {
            const int year = 2021;

            var expected = new List<DateTime>
            {
                new DateTime(year, 12, 27),
                new DateTime(year, 12, 27),
                new DateTime(year, 4, 2),
                new DateTime(year, 4, 3),
                new DateTime(year, 4, 4),
                new DateTime(year, 4, 5)
            };

            var result = _christianPublicHolidayService.GetAll(year);

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(DateTime));
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
