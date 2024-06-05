SwitchStatement(2);
SwitchStatementWithPatternMatching(null);

void SwitchStatement(int int1)
{
    switch (int1)
    {
        case 1:
            Console.WriteLine("The integer equals 1.");
            break;
        case 2:
            Console.WriteLine("The integer equals 2.");
            break;
        case 3:
            Console.WriteLine("The integer equals 3.");
            break;
        default:
            Console.WriteLine("The integer doesn't equal 1, 2, or 3.");
            break;
    }
}

void SwitchStatementWithPatternMatching(object? object1)
{
    switch (object1)
    {
        case null:
            Console.WriteLine("Const pattern with null.");
            break;
        case int i when i > 42:
            Console.WriteLine("Type pattern with a when clause and a relational pattern.");
            break;
        case int:
            Console.WriteLine("Type pattern with an int.");
            break;
        case Book book1:
            Console.WriteLine("Type pattern with a Book type.");
            break;
        default:
            break;
    }
}

class Book
{
    public string Title { get; }

    public Book(string title) => Title = title;
}
