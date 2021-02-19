using DesignCrowd.Services;
using DesignCrowd.Services.Australia;
using DesignCrowd.Services.Australia.Factories;
using NUnit.Framework;
using System;

namespace DesignCrowd.Test.Services.HolidayTests.AustraliaTests
{
    [TestFixture]
   public class AustraliaPublicHolidayServiceTest
    {
        private AustraliaPublicHolidayService _australiaPublicHolidayService;
        private int _year = 2021;

        [SetUp]
        public void SetUp()
        {
            _australiaPublicHolidayService = new AustraliaPublicHolidayService(new ChristianPublicHolidayService(), new NswPublicHolidayCreator());
        }

        [Test]
        public void ReturnsNewYearDate()
        {
            var expected = new DateTime(_year, 1, 1);

            var result = _australiaPublicHolidayService.NewYear(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsLabourDayDate()
        {
            var expected = new DateTime(_year, 10, 4);

            var result = _australiaPublicHolidayService.LabourDay(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsAustraliaDayDate()
        {
            var expected = new DateTime(_year, 1, 26);

            var result = _australiaPublicHolidayService.AustraliaDay(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsQueensBirthdayDate()
        {
            var expected = new DateTime(_year, 6, 14);

            var result = _australiaPublicHolidayService.QueensBirthday(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsAnzacDayDate()
        {
            var expected = new DateTime(_year, 4, 26);

            var result = _australiaPublicHolidayService.AnzacDay(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsChristmasDayDate()
        {
            var expected = new DateTime(_year, 12, 27);

            var result = _australiaPublicHolidayService.Christmas(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsBoxingDayDate()
        {
            var expected = new DateTime(_year, 12, 27);

            var result = _australiaPublicHolidayService.BoxingDay(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsGoodFridayDate()
        {
            var expected = new DateTime(_year, 4, 2);

            var result = _australiaPublicHolidayService.GoodFriday(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsEasterSaturdayDate()
        {
            var expected = new DateTime(_year, 4, 3);

            var result = _australiaPublicHolidayService.EasterSaturday(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsEasterSundayDate()
        {
            var expected = new DateTime(_year, 4, 4);

            var result = _australiaPublicHolidayService.EasterSunday(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        public void ReturnsEasterMondayDate()
        {
            var expected = new DateTime(_year, 4, 5);

            var result = _australiaPublicHolidayService.EasterMonday(_year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }
    }
}
