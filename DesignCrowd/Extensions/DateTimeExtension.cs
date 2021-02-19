using System;
using System.Linq;

namespace DesignCrowd.Extensions
{
    public static class DateTimeExtension
    {
        private static readonly DayOfWeek[] Weekends = {DayOfWeek.Saturday, DayOfWeek.Sunday};

        public static bool IsWeekend(this DateTime date)
        {
            return Weekends.Any(wknd => date.DayOfWeek == wknd);
        }

        public static DateTime SetNextDay(this DateTime date, DayOfWeek day)
        {
            while (date.DayOfWeek != day)
            {
                date = date.AddDays(1);
            }

            return date;
        }
    }
}