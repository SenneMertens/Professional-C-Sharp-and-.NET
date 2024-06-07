Tuples();
TupleDeconstruction();
ReturningTuples();

void Tuples()
{
    // Defining the tuple members and using a tuple literal.
    (string String1, int Number1, Book Book1) tuple1 = ("Magic", 42, new Book("Professional C# and .NET", "Wrox Press"));

    Console.WriteLine($"String: {tuple1.String1}. Number: {tuple1.Number1}. Book: {tuple1.Book1}.");

    // Using the ValueTuple type.
    var tuple2 = ("Magic", 42, new Book("Professional C# and .NET", "Wrox Press"));

    Console.WriteLine($"String: {tuple2.Item1}. Number: {tuple2.Item2}. Book: {tuple2.Item3}.");

    // Assigning member names in a tuple literal.
    var tuple3 = (String1: "Magic", Number1: 42, Book1: new Book("Professional C# and .NET", "Wrox Press"));

    Console.WriteLine($"String: {tuple3.String1}. Number: {tuple3.Number1}. Book: {tuple3.Book1}.");

    // Assigning a tuple to different names.
    (string S, int N, Book B) tuple4 = tuple3;

    // Inferring tuple names.
    Book book1 = new Book("Professional C# and .NET", "Wrox Press");

    var tuple5 = (Number: 42, book1.Title);

    Console.WriteLine(tuple5.Title);
}

void TupleDeconstruction()
{
    var tuple1 = (String1: "Magic", Number1: 42, Book1: new Book("Professional C# and .NET", "Wrox Press"));

    (string string1, int int1, Book book1) = tuple1;

    Console.WriteLine($"String: {string1}. Number: {int1}. Book: {book1}.");

    // Using discard.
    (_, _, Book book2) = tuple1;

    Console.WriteLine(book2.Title);
}

void ReturningTuples()
{
    (int result1, int remainder1) = ReturningTuplesWithAMethod(7, 2);

    Console.WriteLine($"7/2. Result: {result1}. Remainder: {remainder1}.");
}

static (int result, int remainder) ReturningTuplesWithAMethod(int dividend, int divisor)
{
    int result1 = dividend / divisor;
    int remainder1 = dividend % divisor;

    return (result1, remainder1);
}

public record Book(string Title, string Publisher);