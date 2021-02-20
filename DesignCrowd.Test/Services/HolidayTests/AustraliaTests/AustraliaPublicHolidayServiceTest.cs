using DesignCrowd.Services;
using DesignCrowd.Services.Australia;
using DesignCrowd.Services.Australia.Factories;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DesignCrowd.Test.Services.HolidayTests.AustraliaTests
{
    [TestFixture]
   public class AustraliaPublicHolidayServiceTest
    {
        private AustraliaPublicHolidayService _australiaPublicHolidayService;

        [SetUp]
        public void SetUp()
        {
            _australiaPublicHolidayService = new AustraliaPublicHolidayService(new ChristianPublicHolidayService(), new NswPublicHolidayCreator());
        }

        [Test]
        [TestCase(2017, 1, 2)]
        [TestCase(2022, 1, 3)]
        public void ReturnsNewYearDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.NewYear(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 10, 4)]
        [TestCase(2022, 10, 3)]
        public void ReturnsLabourDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.LabourDay(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 1, 26)]
        [TestCase(2022, 1, 26)]
        public void ReturnsAustraliaDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.AustraliaDay(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 6, 14)]
        [TestCase(2022, 6, 13)]
        public void ReturnsQueensBirthdayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.QueensBirthday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 26)]
        [TestCase(2022, 4, 25)]
        public void ReturnsAnzacDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.AnzacDay(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 12, 27)]
        [TestCase(2022, 12, 26)]
        public void ReturnsChristmasDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.Christmas(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 12, 27)]
        [TestCase(2020, 12, 28)]
        public void ReturnsBoxingDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.BoxingDay(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 2)]
        [TestCase(2020, 4, 10)]
        public void ReturnsGoodFridayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.GoodFriday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 3)]
        [TestCase(2022, 4, 16)]
        public void ReturnsEasterSaturdayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.EasterSaturday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 4)]
        [TestCase(2022, 4, 17)]
        public void ReturnsEasterSundayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.EasterSunday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 4, 5)]
        [TestCase(2022, 4, 18)]
        public void ReturnsEasterMondayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _australiaPublicHolidayService.EasterMonday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsAllPublicHolidays()
        {
            const int year = 2021;

            var expected = new List<DateTime>
            {
                new DateTime(year, 10, 4),
                new DateTime(year, 6, 14),
                new DateTime(year, 12, 27),
                new DateTime(year, 12, 27),
                new DateTime(year, 4, 2),
                new DateTime(year, 4, 3),
                new DateTime(year, 4, 4),
                new DateTime(year, 4, 5),
                new DateTime(year, 1, 1),
                new DateTime(year, 1, 26),
                new DateTime(year, 4, 26)
            };

            var result = _australiaPublicHolidayService.GetAll(year);

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(DateTime));
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
