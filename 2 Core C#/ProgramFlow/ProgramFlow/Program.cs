IfStatement();

Book book1 = new("Professional C# and .NET");
PatternMatching(book1);

void IfStatement()
{
    Console.WriteLine("Type in a string.");
    string? input1 = Console.ReadLine();

    if (string.IsNullOrEmpty(input1))
    {
        Console.WriteLine("You typed in an empty string.");
    }
    else if (input1?.Length < 5)
    {
        Console.WriteLine("The string has less than 5 characters.");
    }
    else
    {
        Console.WriteLine("Any other string.");
    }

    Console.WriteLine($"The string was: {input1}.");
}

void PatternMatching(object object1)
{
    if (object1 is null)
    {
        throw new ArgumentNullException(nameof(object1));
    }
    else if (object1 is Book book1)
        Console.WriteLine($"Received a book: {book1.Title}.");
}

class Book
{
    public string Title { get; }

    public Book(string title) => Title = title;
}
