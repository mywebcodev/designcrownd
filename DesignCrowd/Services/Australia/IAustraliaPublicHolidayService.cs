using System;

namespace DesignCrowd.Services.Australia
{
    // https://info.australia.gov.au/about-australia/special-dates-and-events/public-holidays

    public interface IAustraliaPublicHolidayServiceService : IChristianPublicHolidayService, IAustraliaIndividualPublicHolidayService
    {
        DateTime NewYear(int year);

        DateTime AustraliaDay(int year);

        DateTime BankHoliday(int year);
    }
}
