using System;

namespace DesignCrowd.Services.Australia
{
    public interface IAustraliaPublicHolidayService : IChristianPublicHolidayService, IAustraliaIndividualPublicHolidayService, IGetAllHolidays
    {
        DateTime NewYear(int year);

        DateTime AustraliaDay(int year);

        DateTime AnzacDay(int year);
    }
}
