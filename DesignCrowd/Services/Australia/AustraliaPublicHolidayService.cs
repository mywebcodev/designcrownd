using DesignCrowd.Services.Australia.Factories;
using System;

namespace DesignCrowd.Services.Australia
{
    public class AustraliaPublicHolidayService : IAustraliaPublicHolidayServiceService
    {
        private readonly IChristianPublicHolidayService _christianPublicHolidayService;
        private readonly IAustraliaIndividualPublicHolidayService _individualPublicHolidayService;

        public AustraliaPublicHolidayService(IChristianPublicHolidayService christianPublicHolidayService, IAustraliaIndividualPublicHolidayCreator creator)
        {
            _christianPublicHolidayService = christianPublicHolidayService;
            _individualPublicHolidayService = creator.Create();
        }

        public DateTime BankHoliday(int year)
        {
            throw new NotImplementedException();
        }

        public DateTime NewYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

        public DateTime LabourDay(int year)
        {
            return _individualPublicHolidayService.LabourDay(year);
        }

        public DateTime AustraliaDay(int year)
        {
            return new DateTime(year, 1, 26);
        }

        public DateTime QueensBirthday(int year)
        {
            return _individualPublicHolidayService.QueensBirthday(year);
        }

        public DateTime AnzacDay(int year)
        {
            return _individualPublicHolidayService.AnzacDay(year);
        }

        public DateTime Christmas(int year)
        {
            return _christianPublicHolidayService.Christmas(year);
        }

        public DateTime BoxingDay(int year)
        {
            return _christianPublicHolidayService.BoxingDay(year);
        }

        public DateTime GoodFriday(int year)
        {
            return _christianPublicHolidayService.GoodFriday(year);
        }

        public DateTime EasterSaturday(int year)
        {
            return _christianPublicHolidayService.EasterSaturday(year);
        }

        public DateTime EasterSunday(int year)
        {
            return _christianPublicHolidayService.EasterSunday(year);
        }

        public DateTime EasterMonday(int year)
        {
            return _christianPublicHolidayService.EasterMonday(year);
        }
    }
}
