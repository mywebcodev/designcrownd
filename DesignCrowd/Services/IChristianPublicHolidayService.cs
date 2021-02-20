using System;

namespace DesignCrowd.Services
{
    public interface IChristianPublicHolidayService : IGetAllHolidays
    {
        DateTime Christmas(int year);

        DateTime BoxingDay(int year);

        DateTime GoodFriday(int year);

        DateTime EasterSaturday(int year);

        DateTime EasterSunday(int year);

        DateTime EasterMonday(int year);
    }
}
