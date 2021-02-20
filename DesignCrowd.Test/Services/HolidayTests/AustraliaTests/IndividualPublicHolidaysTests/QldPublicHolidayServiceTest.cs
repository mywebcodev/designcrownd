using DesignCrowd.Services.Australia;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DesignCrowd.Test.Services.HolidayTests.AustraliaTests.IndividualPublicHolidaysTests
{
    [TestFixture]
    public class QldPublicHolidayServiceTest
    {
        private QldPublicHolidayService _qldPublicHolidayService;

        [SetUp]
        public void SetUp()
        {
            _qldPublicHolidayService = new QldPublicHolidayService();
        }

        [Test]
        [TestCase(2010, 6, 14)]
        [TestCase(2012, 10, 1)]
        [TestCase(2021, 10, 4)]
        [TestCase(2022, 10, 3)]
        public void ReturnsQueensBirthdayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _qldPublicHolidayService.QueensBirthday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2012, 5, 7)]
        [TestCase(2021, 5, 3)]
        public void ReturnsLabourDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _qldPublicHolidayService.LabourDay(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }


        [Test]
        public void ReturnsAllIndividualHolidays()
        {
            const int year = 2012;

            var expected = new List<DateTime>
            {
                new DateTime(year, 10, 1),
                new DateTime(year, 5, 7)
            };

            var result = _qldPublicHolidayService.GetAll(year);

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(DateTime));
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}