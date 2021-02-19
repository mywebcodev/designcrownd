using DesignCrowd.Extensions;
using System;

namespace DesignCrowd.Services.Australia
{
    public class QldPublicHolidayService : IAustraliaIndividualPublicHolidayService
    {
        public DateTime QueensBirthday(int year)
        {
            // Before 2016 except 2012 QLD celebrated Queens Birthday on the second Monday of June.
            // After 2016 date changed to the first Monday of October.
            // https://en.wikipedia.org/wiki/Queen%27s_Official_Birthday#:~:text=Australian%20states%20and%20territories%20observe,in%20Western%20Australia%20and%20Queensland.
            return year > 2015 || year == 2012 
                ? new DateTime(year, 10, 1).SetNextDay(DayOfWeek.Monday) 
                : new DateTime(year, 6, 1).SetNextDay(DayOfWeek.Monday).AddDays(7);
        }

        public DateTime LabourDay(int year)
        {
            // First Monday in May.
            return new DateTime(year, 5, 1).SetNextDay(DayOfWeek.Monday);
        }
    }
}
