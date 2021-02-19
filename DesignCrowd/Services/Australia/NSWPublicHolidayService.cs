using DesignCrowd.Extensions;
using System;

namespace DesignCrowd.Services.Australia
{
    public class NswPublicHolidayService : IAustraliaIndividualPublicHolidayService
    {
        public DateTime BankHoliday(int year)
        {
            throw new NotImplementedException();
        }

        public DateTime LabourDay(int year)
        {
            //first Monday in October
            return new DateTime(year, 10, 1).SetNextDay(DayOfWeek.Monday);
        }

        public DateTime QueensBirthday(int year)
        {
            return new DateTime(year, 6, 1).SetNextDay(DayOfWeek.Monday).AddDays(7);
        }

        public DateTime AnzacDay(int year)
        {
            return new DateTime(year, 4, 25);
        }
    }
}