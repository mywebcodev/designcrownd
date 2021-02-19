using DesignCrowd.Models.Enums;

namespace DesignCrowd.Services.Australia.Factories
{
    public interface IAustraliaIndividualPublicHolidayFactory
    {
        IAustraliaIndividualPublicHolidayCreator Create(AustralianState state);
    }
}
