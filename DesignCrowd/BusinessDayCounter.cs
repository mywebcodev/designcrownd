using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignCrowd
{
    public class BusinessDayCounter
    {
        /// <summary>
        /// Gets range of the days between two dates
        /// </summary>
        /// <remarks>
        /// Weekdays are Monday, Tuesday, Wednesday, Thursday, Friday.
        /// The returned days should not include either start date or end date
        /// If end date is equal to or before start date, return empty List.
        /// </remarks>
        /// <returns>List of days</returns>
        private static List<DateTime> GetWeekdaysRangeBetweenTwoDates(DateTime start, DateTime end)
        {
            var days = new List<DateTime>();

            start = start.AddDays(1);

            if (DateTime.Compare(start, end) >= 0)
            {
                return days;
            }

            if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
            {
                days.Add(start);
            }

            days.AddRange(GetWeekdaysRangeBetweenTwoDates(start, end));

            return days;
        }

        /// <summary>
        /// Calculates the number of weekdays in between two dates.
        /// </summary>
        /// <remarks>
        /// The returned number of days should not include either start date or end date.
        /// Weekdays are Monday, Tuesday, Wednesday, Thursday, Friday.
        /// </remarks>
        /// <param name="start">The start date.</param>
        /// <param name="end">The end date.</param>
        /// <returns>Number of weekdays</returns>
        public int WeekdaysBetweenTwoDates(DateTime start, DateTime end)
        {
            return GetWeekdaysRangeBetweenTwoDates(start, end).Count;
        }

        /// <summary>
        /// Calculates the number of business days in between two dates.
        /// </summary>
        /// <remarks>
        /// The returned number of days should not include either start date or end date.
        /// Business days are Monday, Tuesday, Wednesday, Thursday, Friday
        /// but excluding any dates which appear in the supplied list of public holidays.
        /// </remarks>
        /// <param name="start">The start date.</param>
        /// <param name="end">The end date.</param>
        /// <param name="pHolidays">Collection of public holidays.</param>
        /// <returns>Number of business days</returns>
        public int BusinessDaysBetweenTwoDates(DateTime start, DateTime end, IList<DateTime> pHolidays)
        {
            var days = GetWeekdaysRangeBetweenTwoDates(start, end);

            if (pHolidays == null || !pHolidays.Any())
            {
                return days.Count;
            }

            var publicHolidaysHash = pHolidays.Select(h => h.Ticks).ToHashSet();
            return days.Count(day => !publicHolidaysHash.Contains(day.Ticks));
        }
    }
}