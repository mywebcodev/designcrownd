using System;

namespace DesignCrowd.Services.Australia
{
    public interface IAustraliaPublicHolidayServiceService : IChristianPublicHolidayService, IAustraliaIndividualPublicHolidayService
    {
        DateTime NewYear(int year);

        DateTime AustraliaDay(int year);

        DateTime AnzacDay(int year);
    }
}
