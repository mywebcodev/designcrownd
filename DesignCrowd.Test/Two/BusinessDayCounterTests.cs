using NUnit.Framework;

namespace DesignCrowd.Test.Two
{
    [TestFixture]
    public partial class BusinessDayCounterTests
    {
        private BusinessDayCounter _businessDayCounter;

        [SetUp]
        public void Setup()
        {
            _businessDayCounter = new BusinessDayCounter();
        }
    }
}
