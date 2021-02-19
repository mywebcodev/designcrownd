using NUnit.Framework;

namespace DesignCrowd.Test.Services.BusinessDayCounterTests
{
    [TestFixture]
    public partial class BusinessDayCounterTest
    {
        private BusinessDayCounter _businessDayCounter;

        [SetUp]
        public void Setup()
        {
            _businessDayCounter = new BusinessDayCounter();
        }
    }
}
