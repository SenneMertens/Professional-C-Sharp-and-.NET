// string string1 = null; // Compiler warning."CS8600: Converting a null literal or possible null value to non-nullable type.".

string? string1 = null;

// string string2 = string1?.ToUpper(); // Compiler warning."CS8600: Converting a null literal or possible null value to non-nullable type.".

string? string2 = string1?.ToUpper();
string string3 = string1?.ToUpper() ?? string.Empty;

if (string1 is not null)
{
    string string4 = string1.ToUpper();
}

if (string1 != null)
{
    string string5 = string1.ToUpper();
}

Book? book1 = null;

Book book2 = new Book("Professional C# and .NET");
string title = book2.Title;
string? publisher = book2.Publisher;

Console.WriteLine(title);
Console.WriteLine(publisher);
Console.WriteLine(book1);

class Book
{
    public string Title { get; set; }
    public string? Publisher { get; set; }

    public Book(string title) => Title = title;
}
