namespace DesignCrowd.Services.Australia.Factories
{
    public class NSWPublicHolidayCreator : IAustraliaIndividualPublicHolidayCreator
    {

        public IAustraliaIndividualPublicHolidayService Create()
        {
            return new NswPublicHolidayService();
        }
    }
}