using System.Text;

StringBuilder();
StringInterpolation();
FormattableString();
StringFormat();
VerbatimString();
RangeWithString();

void StringBuilder()
{
    StringBuilder stringBuilder1 = new("The quick");

    stringBuilder1.Append(' ');
    stringBuilder1.Append("brown fox jumped over ");
    stringBuilder1.Append("the lazy dogs 1234567890 times.");

    string string1 = stringBuilder1.ToString();

    Console.WriteLine(string1);
}

void StringInterpolation()
{
    string string1 = "World!";
    string string2 = $"Hello, {string1}";

    Console.WriteLine(string2);

    int int1 = 3;
    int int2 = 4;
    string string3 = $"The result of {int1} and {int2} is {int1 + int2}.";

    Console.WriteLine(string3);
}

void FormattableString()
{
    int int1 = 3;
    int int2 = 4;
    FormattableString formattableString1  = $"The result of {int1} and {int2} is {int1 + int2}.";

    Console.WriteLine($"Format: {formattableString1.Format}");

    for (int i = 0; i < formattableString1.ArgumentCount; i++)
    {
        Console.WriteLine($"Argument: {formattableString1.GetArgument(i)}.");
    }
}

void StringFormat()
{
    DateTime datetime1 = new(2025, 2, 14);

    Console.WriteLine($"{datetime1:D}");
    Console.WriteLine($"{datetime1:d}");

    int int1 = 2477;

    Console.WriteLine($"{int1:n} {int1:e} {int1:x} {int1:c}");

    double double1 = 3.1415;

    Console.WriteLine($"{double1:###.###}");
    Console.WriteLine($"{double1:000.000}");
}

void VerbatimString()
{
    string string1 = @"A tab: \t. A carriage return: \r. A newline: \n.";

    Console.WriteLine(string1);
}

void RangeWithString()
{
    string string1 = "The quick brown fox jumped over the lazy dogs 1234567890 times.";

    string string2 = string1[0..3];
    string string3 = string1[4..9];
    string string4 = string1[^6..^1];

    Console.WriteLine(string2);
    Console.WriteLine(string3);
    Console.WriteLine(string4);
}
