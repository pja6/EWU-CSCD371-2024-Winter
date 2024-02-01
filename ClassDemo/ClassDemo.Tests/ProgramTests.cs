// TestProjectName.Tests
namespace ClassDemo.Tests;

// ClassNameTests
public class ProgramTests
{
    Program Program { get; set; }

    // Constructors run before every test
    public ProgramTests()
    {
        Program = TestInitialize();
    }

    int _InstanceCount = 0;

    private static Program TestInitialize()
    {
        return new Program();
    }

    
    [Theory]
    [InlineData("Inigo.Montoya", "goodpassword")]
    [InlineData("Princess.Buttercup", "goodpassword")]
    [InlineData("Count.Rugen", "goodpassword")]
    [InlineData("Wesley", "goodpassword")]
    [InlineData("Dread.Pirate.Roberts", "goodpassword")]
    // MethodUnderTest_ConditionUnderTest_ExpectedResult
    public void TryLogin_WithGoodPassword_SuccessfulLogin(string username, string password)
    {
        Assert.True(Program.TryLogin(username, password));
    }

    [Fact]
    // MethodUnderTest_ConditionUnderTest_ExpectedResult
    public void TryLogin_InigoMontoyaWithGoodPassword_SuccessfulLogin()
    {
        Assert.Equal(0, _InstanceCount);
        string username = "Inigo.Montoya";
        string password = "goodpassword";
        _InstanceCount++;

        Assert.True(Program.TryLogin(username, password));
    }

    [Fact]
    public void TryLogin_InigoMontoyaWithGoodPassword_FailedLogin()
    {
        Assert.Equal(0, _InstanceCount);
        _InstanceCount++;

        Assert.False(Program.TryLogin("Inigo.Montoya", "badpassword"));
    }

    [Fact]
    public void TryLogin_PrincessButtercupWithGoodPassword_SuccessfulLogin()
    {
        Assert.True(Program.TryLogin("Princess.Buttercup", "goodpassword"));
    }

    [Fact]
    public void Login_PrincessButtercupWithGoodPassword_SuccessfulLogin()
    {
        Program.Login(username: "Princess.Buttercup", password: "goodpassword");
    }

    [Fact]
    public void Login_PrincessButtercupWithBadPassword_FailedLogin()
    {
        Assert.Throws<InvalidOperationException>(
            () => Program.Login(username: "Princess.Buttercup", password: "badpassword"));
    }

    [Fact]
    public void Login_PrincessButtercupWithBadPasswordTryCatch_FailedLogin()
    {
        try
        {
            Program.Login(username: "Princess.Buttercup", password: "badpassword");
        }
        catch (InvalidOperationException)
        {
            return;
        }
        Assert.Fail("Exception not thrown for bad login.");
    }

    [Theory]
    [InlineData("InigoMontoya", 9)]
    public void Convert_NumberString_ToInt(string inputText, int result)
    {
        Assert.True(Program.TryConvert(inputText, out int? number));
        Assert.Equal(result, number);
    }

    [Theory]
    [InlineData("Inigo", "middle", "Montoya", "Inigo middle Montoya")]
    [InlineData("Inigo", null, "Montoya", "Inigo Montoya")]
    public void GetFullName_ThreeNames_ReturnsFullName(string firstName, string? middleName, string lastName, string expected)
    {
        Assert.Equal(expected, Program.GetFullName(firstName, lastName, middleName));
    }

    [Theory]
    [InlineData("Inigo", "Montoya", "Inigo Montoya")]
    public void GetFullName_ThreeNamesOptionalParameter_ReturnsFullName(string firstName, string lastName, string expected)
    {
        Assert.Equal(expected, Program.GetFullName(firstName, lastName));
    }

    [Fact]
    public void JoinStringByDelimiter_PassInNull_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>( () => Program.JoinStringByDelimiter(null));
    }
    
    [Theory]
    [InlineData(new string?[] { "Montoya" }, "Montoya")]
    [InlineData(new string?[] { "Inigo" }, "Inigo")]
    [InlineData(new string?[] { "" },"")]
    [InlineData(new string?[] { null },"")]
    [InlineData(new string?[] { "Inigo" ,"Montoya" }, "Inigo Montoya")]


    public void JoinStringByDelimiter_OneElementNotNull_ReturnElement(string?[] actual, string expected)
    {
        Assert.Equal(expected, Program.JoinStringByDeliminator(actual));
    }
    [Fact]
    public void DisplayValue()
    {
        string temp = Program.JoinStringByDeliminator(null);
        temp = temp?.ToUpper().ToLower(); //if this returns null at ToUpper(), returns nullreferenceexcepetion
        temp = temp?.ToUpper()?.ToLower(); // if ToUpper() returns null then it will continue to ToLower() which will then do ^^
        Console.WriteLine(temp);
    }
    //if there's a possibility that a value returns null then you have to decide how you want to handle null
    //this is not the case if you just return a string - don't have to worry about null reference exception for example
    //if calling method on an expected string
    //makes api simpler by not having to check

    //temp? this operator says if this is null just return null and don't call the invoked methods (short circuits)
    //if you're adding it then it means var could be nullable so then you also need string? temp
    //null conditional operator = ?



    [Fact]
    public void JoinStringByDelimiter_ParamsArray_ReturnElement()
    {
        Assert.Equal("Inigo Montoya", Program.JoinStringByDeliminator("Inigo", "Montoya"));
    }


    [Fact]
    public void JoinStringByDelimiter_ExtensionMethod_ReturnElement()
    {
        //need the extension method to make this work
        //Assert.Equal("Inigo Montoya", "Inigo".JoinStringByDeliminator("Inigo", "Montoya"));
    }

}
 
    
