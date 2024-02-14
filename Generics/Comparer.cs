
namespace Generics;

public static class Comparer
{
    public static CompareResult Compare(this FullName fullName1, FullName fullName2)
    {
        return string.Compare(fullName1.LastName, fullName2.LastName) switch
        {
            0 => CompareResult.Equal,
            > 0 => CompareResult.GreaterThan,
            < 0 => CompareResult.LessThan
        };
    }

    public static CompareResult Compare(this Person fullName1, Person fullName2)
    {
        return string.Compare(fullName1.LastName, fullName2.LastName) switch
        {
            0 => CompareResult.Equal,
            > 0 => CompareResult.GreaterThan,
            < 0 => CompareResult.LessThan
        };
    }
    public static CompareResult Compare<T>(this T fullName1, T fullName2)
    {
        return string.Compare(fullName1.LastName, fullName2.LastName) switch
        {
            0 => CompareResult.Equal,
            > 0 => CompareResult.GreaterThan,
            < 0 => CompareResult.LessThan
        };
    }
}