using System;
using System.IO;
using Xunit;


namespace CanHazFunny.Tests;

public class JokeServiceOutputTests
{
    [Fact]
    public void Write_WriteToConsole_Success()
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