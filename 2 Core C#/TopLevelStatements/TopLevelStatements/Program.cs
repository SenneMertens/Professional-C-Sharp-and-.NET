string string1 = new string("Hello, World!");
string string2 = "Hello, World!";
var string3 = "Hello, World!";
string string4 = new("Hello, World!");

Console.WriteLine(string1);
Console.WriteLine(string2);
Console.WriteLine(string3);
Console.WriteLine(string4);

void Method()
{
    Console.WriteLine("This is a method.");
}

Method();

Book book1 = new();
book1.Title = "Professional C# and .NET";

Console.WriteLine(book1);

class Book
{
    public string Title { get; set; }

    public override string ToString() => Title;
}
