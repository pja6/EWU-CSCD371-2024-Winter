using System.Text;

namespace ClassDemo;


public class Program
{
    //putting string[]? there means entire array is nullable - input strings could be null
    // putting string?[] 
    //params will automatically convert something to array
    //if you wanted to force something you could do (string first, params string?[] inputStrings)
    
    public string JoinStringByDeliminator(params string?[] inputStrings)
    {
        //always use ArgumentNullException instead of NullReferenceException
        //always pass in nameof(_thing that is null_) - so whatever could have come in as null
        //NRE should be an indication of a bug in your code not something you set up
        //GUIDELINE - return empty array not null - have to check for null otherwise
        ArgumentNullException.ThrowIfNull(inputStrings);
        //a for each loop will never have an index out of bounds error
        //don't need to implement a counter
        //will work on zero item
        StringBuilder result = new ();

        foreach (string? inputString in inputStrings) { //pluralized collection

            if(inputString != null)
            {
                if(result.Length != 0)
                    result.Append(' ');
                result.Append(inputString);
            }
            
            
        }
        //return inputStrings[0] ?? " ";//if it returns null just return a space
        return result.ToString();
    }

    public static string JoinStringByDeliminatorMark(string?[] inputStrings)
    {
        //need to check size of array
        ArgumentNullException.ThrowIfNull(inputStrings);

        StringBuilder result = new();

        if (inputStrings.Length > 0)
        {
            result.Append(inputStrings[0]);
            //1.. take the 2nd element and everything coming after
            foreach (string? inputString in inputStrings[1..])
            { //pluralized collection

                if (inputString != null)
                {
                    result.Append(' ');
                    result.Append(inputString);
                }
            }

        }
        return result.ToString();

    }

    public string GetFullName(string firstName, string lastName, string? middleName = null)
    {
        //string fullName = firstName + " ";
        //if (middleName != null)
        //{
        //fullName += middleName + " ";
        //}
        //return fullName + lastName;

        //return $"{firstName}{middleName ?? ""}{lastName}";
        return firstName + $"{(middleName != null ? ' ' + middleName : ' ')}" + lastName;

        //return firstName + " " + middleName + " " + lastName;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void Login(string username, string password)
    {
        if (!TryLogin(username, password))
        {
            throw new InvalidOperationException("Your login is not valid");
        }
    }
  
    public bool TryLogin(string username, string password)
    {
        if (password == "goodpassword")
        {
            return true;
        }
        return false;
        // Moq library in C#
    }

    public bool TryConvert(string number, out int? result)
    {
        if (number == "one")
        {
            result = 1;
            return true;
        }
        else
        {
            result = null;
            return false;
        }
    }

    public void JoinStringByDelimiter(object value)
    {
        throw new NotImplementedException();
    }
}
