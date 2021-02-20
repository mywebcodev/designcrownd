using System;

namespace DesignCrowd.Services.Australia
{
    public interface IAustraliaIndividualPublicHolidayService : IGetAllHolidays
    {
        DateTime QueensBirthday(int year);

        DateTime LabourDay(int year);
    }
}
