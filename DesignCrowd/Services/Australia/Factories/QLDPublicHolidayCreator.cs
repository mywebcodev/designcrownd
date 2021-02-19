namespace DesignCrowd.Services.Australia.Factories
{
    public class QldPublicHolidayCreator : IAustraliaIndividualPublicHolidayCreator
    {
        public IAustraliaIndividualPublicHolidayService Create()
        {
            return new QldPublicHolidayService();
        }
    }
}
