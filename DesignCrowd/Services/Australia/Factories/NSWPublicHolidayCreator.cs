namespace DesignCrowd.Services.Australia.Factories
{
    public class NswPublicHolidayCreator : IAustraliaIndividualPublicHolidayCreator
    {

        public IAustraliaIndividualPublicHolidayService Create()
        {
            return new NswPublicHolidayService();
        }
    }
}