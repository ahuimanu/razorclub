using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            //Arrange
            var primeService = new PrimeService();

            //Act
            bool result = primeService.IsPrime(1);

            //Assert
            Assert.False(result, "1 should not be prime");
        }
    }
}