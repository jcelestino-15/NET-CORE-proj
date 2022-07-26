using Xunit;
using test.services;

namespace test.UnitTests.services
{
    public class testservice_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var testService = new testservice();
            bool result = testService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }
    }
}