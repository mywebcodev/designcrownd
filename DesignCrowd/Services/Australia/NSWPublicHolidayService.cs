using DesignCrowd.Extensions;
using System;
using System.Collections.Generic;

namespace DesignCrowd.Services.Australia
{
    public class NswPublicHolidayService : IAustraliaIndividualPublicHolidayService
    {
        public DateTime LabourDay(int year)
        {
            // First Monday in October.
            return new DateTime(year, 10, 1).SetNextDay(DayOfWeek.Monday);
        }

        public DateTime QueensBirthday(int year)
        {
            // Second Monday of June.
            return new DateTime(year, 6, 1).SetNextDay(DayOfWeek.Monday).AddDays(7);
        }

        public IEnumerable<DateTime> GetAll(int year)
        {
            return new[] {LabourDay(year), QueensBirthday(year)};
        }
    }
}