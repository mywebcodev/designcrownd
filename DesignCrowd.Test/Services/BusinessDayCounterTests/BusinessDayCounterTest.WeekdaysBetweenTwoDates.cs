using System;
using System.Collections;
using NUnit.Framework;

namespace DesignCrowd.Test.Services.BusinessDayCounterTests
{
    public partial class BusinessDayCounterTest
    {
        public class WeekDaysBetweenTwoDates : BusinessDayCounterTest
        {
            [Test]
            [TestCaseSource(nameof(BusinessDayCounterTests))]
            public void CountWeekdays(DateTime start, DateTime end, int expected)
            {
                var result = _businessDayCounter.WeekdaysBetweenTwoDates(start, end);

                Assert.AreEqual(expected, result);
            }

            public static IEnumerable BusinessDayCounterTests
            {
                get
                {
                    // Case invalid password
                    var oneDayTestCaseData = new TestCaseData(new DateTime(2013, 10, 7), new DateTime(2013, 10, 9), 1)
                    {
                        TestName = "7th October 2013 - 9th October 2013: one day."
                    };

                    var oneWorkingWeekTestCaseData = new TestCaseData(new DateTime(2013, 10, 5), new DateTime(2013, 10, 14), 5)
                    {
                        TestName = "5th October 2013 - 14th October 2013: five days."
                    };

                    var sixtyOneCaseData = new TestCaseData(new DateTime(2013, 10, 7), new DateTime(2014, 1, 1), 61)
                    {
                        TestName = "7th October 2013 - 1th January 2014: sixty one day."
                    };

                    var startDateMoreThanEndDateCase = new TestCaseData(new DateTime(2013, 10, 7), new DateTime(2013, 10, 5), 0)
                    {
                        TestName = "7th October 2013 - 5th October 2013: zero days."
                    };

                    var startDateEqualsToEndDateCase = new TestCaseData(new DateTime(2013, 10, 7), new DateTime(2013, 10, 7), 0)
                    {
                        TestName = "7th October 2013 - 7th October 2013: zero days."
                    };

                    yield return oneDayTestCaseData;
                    yield return oneWorkingWeekTestCaseData;
                    yield return sixtyOneCaseData;
                    yield return startDateMoreThanEndDateCase;
                    yield return startDateEqualsToEndDateCase;
                }
            }
        }
    }
}
