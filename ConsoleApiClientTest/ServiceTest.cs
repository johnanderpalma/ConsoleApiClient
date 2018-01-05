namespace ConsoleApiClientTest
{
    using System.Threading.Tasks;
    using ConsoleApiClient;
    using Xunit;

    public class ServiceTest
    {
        [Fact]
        public async Task GetAsyncTestAsync()
        {
            // Arrange
            IService target = new Service();
            string actual = string.Empty;

            // Act
            actual = await target.GetAsync();

            // Assert
            Assert.NotNull(actual);
        }
    }
}