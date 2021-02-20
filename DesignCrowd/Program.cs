using DesignCrowd.Models.Enums;
using DesignCrowd.Services;
using DesignCrowd.Services.Australia;
using DesignCrowd.Services.Australia.Factories;
using System;
using System.Linq;

namespace DesignCrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            // To see all results please run tests from DesignCrowd.Tests
            const int year = 2021;
            
            var start = new DateTime(year, 1, 1);
            var end = new DateTime(year, 12, 31);

            var counter = new BusinessDayCounter();
            var australiaIndividualPublicHolidayFactory = new AustraliaIndividualPublicHolidayFactory();
            var australiaPublicHolidayService = new AustraliaPublicHolidayService(new ChristianPublicHolidayService(), australiaIndividualPublicHolidayFactory.Create(AustralianState.NSW));
            
            var countOfWeekdays = counter.WeekdaysBetweenTwoDates(start, end);
            var countOfBusinessDays = counter.BusinessDaysBetweenTwoDates(start, end, australiaPublicHolidayService.GetAll(year).ToList());
           
            Console.WriteLine("To see all results please run tests from DesignCrowd.Tests\n");
            Console.WriteLine($"Number of Weekdays in {year}: {countOfWeekdays}");
            Console.WriteLine($"Number of Business days in {year}: {countOfBusinessDays}\n");
            Console.WriteLine($"New Year in {year}: {australiaPublicHolidayService.NewYear(year).ToShortDateString()}");
            Console.WriteLine($"Labour Day in {year}: {australiaPublicHolidayService.LabourDay(year).ToShortDateString()}");
            Console.WriteLine($"Australia Day in {year}: {australiaPublicHolidayService.AustraliaDay(year).ToShortDateString()}");
            Console.WriteLine($"Queen's Birthday in {year}: {australiaPublicHolidayService.QueensBirthday(year).ToShortDateString()}");
            Console.WriteLine($"ANZAC Day in {year}: {australiaPublicHolidayService.AnzacDay(year).ToShortDateString()}");
            Console.WriteLine($"Christmas in {year}: {australiaPublicHolidayService.Christmas(year).ToShortDateString()}");
            Console.WriteLine($"Boxing Day in {year}: {australiaPublicHolidayService.BoxingDay(year).ToShortDateString()}");
            Console.WriteLine($"Good Friday in {year}: {australiaPublicHolidayService.GoodFriday(year).ToShortDateString()}");
            Console.WriteLine($"Easter Saturday in {year}: {australiaPublicHolidayService.EasterSaturday(year).ToShortDateString()}");
            Console.WriteLine($"Easter Sunday in {year}: {australiaPublicHolidayService.EasterSunday(year).ToShortDateString()}");
            Console.WriteLine($"Easter Monday in {year}: {australiaPublicHolidayService.EasterMonday(year).ToShortDateString()}");
        }
    }
}
