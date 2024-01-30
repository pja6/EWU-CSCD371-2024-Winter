using Moq;
using System.Net.Http;
using Xunit;

namespace CanHazFunny.Tests
{
    public class JokeServiceTests
    {

        [Fact]
        public void GetJoke_ReturnJoke_Success()
        {
            // Arrange
            JokeService joke = new();

            // Act
            string result = joke.GetJoke();

            // Assert
            Assert.NotNull( result);
            Assert.NotEmpty( result );
        }
    }
}
