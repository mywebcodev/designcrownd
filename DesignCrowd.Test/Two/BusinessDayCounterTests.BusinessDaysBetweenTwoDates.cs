using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignCrowd.Test.Two
{
    public partial class BusinessDayCounterTests
    {
        public class BusinessDaysBetweenTwoDates : BusinessDayCounterTests
        {
            [Test]
            [TestCaseSource(nameof(BusinessDaysBetweenTwoDatesTestCaseSource))]
            public void CountBusinessDays(DateTime start, DateTime end, List<DateTime> holidays, int expected)
            {
                var result = _businessDayCounter.BusinessDaysBetweenTwoDates(start, end, holidays);

                Assert.AreEqual(expected, result);
            }

            public static IEnumerable BusinessDaysBetweenTwoDatesTestCaseSource
            {
                get
                {
                    var pHolidays = new List<DateTime>
                    {
                        new DateTime(2013, 11, 25),
                        new DateTime(2013, 11, 26),
                        new DateTime(2014, 11, 1)
                    };

                    // Case invalid password
                    var oneDayTestCaseData = new TestCaseData(new DateTime(2013, 10, 7), new DateTime(2013, 10, 9), pHolidays, 1)
                    {
                        TestName = "7th October 2013 - 9th October 2013: one day."
                    };

                    var zeroDaysTestCaseData = new TestCaseData(new DateTime(2013, 11, 24), new DateTime(2013, 11, 27), pHolidays, 0)
                    {
                        TestName = "24th December 2013 - 24th December 2013: zero days."
                    };

                    var fiftyNineDaysTestCaseData = new TestCaseData(new DateTime(2013, 10, 7), new DateTime(2014, 1, 1), pHolidays, 59)
                    {
                        TestName = "7th October 2013 - 7st January 2014: fifty nine days."
                    };

                    yield return oneDayTestCaseData;
                    yield return zeroDaysTestCaseData;
                    yield return fiftyNineDaysTestCaseData;
                }
            }
        }
    }
}
