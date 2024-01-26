using System.Text;

namespace ClassDemo;

public static class StringEx
{
    /// <summary>
    /// List of strings, join together by delimiter, ignore null or empty
    /// </summary>
    /// <param name="inputStrings">An array of strings that are...</param>
    /// <returns></returns>
    public static string JoinStringByDelimiter(this string thing1, params string?[] inputStrings)
    {
        ArgumentNullException.ThrowIfNull(inputStrings);
        StringBuilder result = new();
        if (inputStrings.Length > 0)
        {
            result.Append(inputStrings[0]);
            foreach (string? inputString in inputStrings[1..])
            {
                if (inputString != null)
                {
                    result.Append(' ');
                    result.Append(inputString);
                }
            }
        }
        return result.ToString();
    }
}