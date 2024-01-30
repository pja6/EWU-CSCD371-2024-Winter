using Xunit;
using Moq;
using System;

namespace CanHazFunny.Tests;

public class JesterTests
{
    [Fact]
    public void TellJoke_JokeServiceIsNull_ThrowException()
    {  
        //Arrange
        IJokeServiceOutput jokeOutput = new JokeServiceOutput();

        // Act and Assert
        Assert.Throws<ArgumentNullException>(() => new Jester(null!, jokeOutput));

    }

    [Fact]
    public void TellJoke_JokeOutputIsNull_ThrowException()
    {
        //Arrange
        IJokeService jokeService = new JokeService();

        //Act and Assert
        Assert.Throws<ArgumentNullException>(() => new Jester(jokeService, null!));
    }

    [Fact]
    public void TellJoke_ReturnsJoke_Success()
    {
        // Arrange
        var jokeServiceMock = new Mock<IJokeService>();
        var outputInterfaceMock = new Mock<IJokeServiceOutput>();

        //Return two jokes, neither contain Chuck Norris
        jokeServiceMock.SetupSequence(s => s.GetJoke())
            .Returns("Why did the chicken cross the road? To get to the other side!")
            .Returns("This is another joke");

        var jester = new Jester(jokeServiceMock.Object, outputInterfaceMock.Object);

        // Act
        jester.TellJoke();

        // Assert
        outputInterfaceMock.Verify(o => o.Write("Why did the chicken cross the road? To get to the other side!"), Times.Once);
    }

    [Fact]
    public void TellJoke_DoesntContainChuckNorris_Success()
    {
        // Arrange
        var jokeServiceMock = new Mock<IJokeService>();
        var outputInterfaceMock = new Mock<IJokeServiceOutput>();

        // Return a joke containing "Chuck Norris" for the first call,
        // and a regular joke for subsequent calls to GetJoke()
        jokeServiceMock.SetupSequence(s => s.GetJoke())
            .Returns("Why did the chicken cross the road? To get to the other side!")
            .Returns("Chuck Norris can divide by zero.");

        var jester = new Jester(jokeServiceMock.Object, outputInterfaceMock.Object);

        // Act
        jester.TellJoke();

        // Assert
        outputInterfaceMock.Verify(o => o.Write("Why did the chicken cross the road? To get to the other side!"), Times.Once);
    }


}
