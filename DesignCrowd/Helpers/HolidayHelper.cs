using DesignCrowd.Extensions;
using System;

namespace DesignCrowd.Helpers
{
    public static class HolidayHelper
    {
        public static DateTime AddFollowingWeekend(DateTime date)
        {
            while (date.IsWeekend())
            {
                date = date.AddDays(1);
            }

            return date;
        }
    }
}
