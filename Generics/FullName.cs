namespace Generics;

public readonly record struct FullName(string FirstName, string LastName, string? MiddleName = null)
{
    public string FirstName { get; } = FirstName ?? throw new ArgumentNullException(nameof(FirstName));
    public string LastName { get; } = LastName ?? throw new ArgumentNullException(nameof(LastName));

    public override string ToString()
    {

        return $"{FirstName}{(string.IsNullOrWhiteSpace(MiddleName) ? String.Empty : " " +  MiddleName)} {LastName}";
    }
}
