using System;

namespace DesignCrowd.Services.Australia
{
    public interface IAustraliaIndividualPublicHolidayService
    {
        DateTime QueensBirthday(int year);

        DateTime AnzacDay(int year);

        DateTime LabourDay(int year);
    }
}
