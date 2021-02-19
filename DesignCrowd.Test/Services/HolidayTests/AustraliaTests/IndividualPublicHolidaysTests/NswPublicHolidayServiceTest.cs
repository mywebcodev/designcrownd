﻿using DesignCrowd.Services.Australia;
using NUnit.Framework;
using System;

namespace DesignCrowd.Test.Services.HolidayTests.AustraliaTests.IndividualPublicHolidaysTests
{
    public class NswPublicHolidayServiceTest
    {
        private NswPublicHolidayService _nswPublicHolidayService;

        [SetUp]
        public void SetUp()
        {
            _nswPublicHolidayService = new NswPublicHolidayService();
        }

        [Test]
        [TestCase(2021, 6, 14)]
        [TestCase(2022, 6, 13)]
        public void ReturnsQueensBirthdayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _nswPublicHolidayService.QueensBirthday(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }

        [Test]
        [TestCase(2021, 10, 4)]
        [TestCase(2022, 10, 3)]
        public void ReturnsLabourDayDate(int year, int month, int day)
        {
            var expected = new DateTime(year, month, day);

            var result = _nswPublicHolidayService.LabourDay(year);

            Assert.AreEqual(expected.Ticks, result.Ticks);
        }
    }
}