Book2 book2 = new("Professional C# and .NET", "Wrox Press");

Console.WriteLine(book2);

Book1 book1 = new() { Title = "Professional C# and .NET", Publisher = "Wrox Press" };
Book1 book3 = new() { Title = "Professional C# and .NET", Publisher = "Wrox Press" };

if (!object.ReferenceEquals(book1, book3))
    Console.WriteLine("2 different references for equal records.");

if (book1 == book3)
{
    Console.WriteLine("Both records have the same values.");
}

// Nominal record.
public record Book1
{
    public string Title { get; init; } = string.Empty;
    public string Publisher { get; init; } = string.Empty;
}

// Positional record.
public record Book2(string Title, string Publisher);
