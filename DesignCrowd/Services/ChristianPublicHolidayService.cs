using System;

namespace DesignCrowd.Services
{
    public class ChristianPublicHolidayService : IChristianPublicHolidayService
    {

        public DateTime Christmas(int year)
        {
            return new DateTime(year, 12, 25);
        }

        public DateTime BoxingDay(int year)
        {
            return new DateTime(year, 12, 26);
        }

        public DateTime GoodFriday(int year)
        {
            return EasterSunday(year).AddDays(-2);
        }

        public DateTime EasterSaturday(int year)
        {
            return EasterSunday(year).AddDays(-1);
        }

        // https://stackoverflow.com/a/2510411
        public DateTime EasterSunday(int year)
        {
            var g = year % 19;
            var c = year / 100;
            var h = (c - c / 4 - (8 * c + 13) / 25 + 19 * g + 15) % 30;
            var i = h - h / 28 * (1 - h / 28 * (29 / (h + 1)) * ((21 - g) / 11));

            var day = i - (year + year / 4 + i + 2 - c + c / 4) % 7 + 28;
            var month = 3;

            if (day > 31)
            {
                month++;
                day -= 31;
            }

            return new DateTime(year, month, day);
        }

        public DateTime EasterMonday(int year)
        {
            return EasterSunday(year).AddDays(1);
        }
    }
}
