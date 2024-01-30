using System;
using System.IO;
using Xunit;


namespace CanHazFunny.Tests;

public class JokeServiceOutputTests
{
    [Fact]
    public void Write_Should_Write_Joke_To_Console()
    {
        // Arrange
        JokeServiceOutput jokeServiceOutput = new();

        // Redirect Console.WriteLine output to a StringWriter
        using (StringWriter output = new())
        {
            Console.SetOut(output);

            // Act
            jokeServiceOutput.Write("This is a joke");

            // Assert
            Assert.Equal("This is a joke", output.ToString().Trim());
        }
    }


}