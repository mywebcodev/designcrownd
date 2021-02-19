using System;

namespace DesignCrowd.Services.Australia
{
    public interface IAustraliaIndividualPublicHolidayService
    {
        DateTime QueensBirthday(int year);

        DateTime LabourDay(int year);
    }
}
