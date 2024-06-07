using Enumerations;

ColorEnumeration();
DaysOfWeekEnumeration();
EnumClass();

void ColorEnumeration()
{
    Color color1 = Color.Red;
    Console.WriteLine(color1);

    Color color2 = (Color)2;
    Console.WriteLine(color2);
    Console.WriteLine((short)color2);
}

void DaysOfWeekEnumeration()
{
    DaysOfWeek mondayAndWednesday1 = DaysOfWeek.Monday | DaysOfWeek.Wednesday;
    Console.WriteLine(mondayAndWednesday1);

    DaysOfWeek weekend1 = DaysOfWeek.Saturday | DaysOfWeek.Sunday;
    Console.WriteLine(weekend1);

    DaysOfWeek workday1 = DaysOfWeek.Monday | DaysOfWeek.Tuesday | DaysOfWeek.Wednesday | DaysOfWeek.Thursday | DaysOfWeek.Friday;
    Console.WriteLine(workday1);
}

void EnumClass()
{
    if (Enum.TryParse<Color>("Red", out Color red1))
    {
        Console.WriteLine($"Succesfully parsed: {red1}.");
    }

    foreach (var color in Enum.GetNames(typeof(Color)))
    {
        Console.WriteLine(color);
    }

    foreach (short color in Enum.GetValues(typeof(Color)))
    {
        Console.WriteLine(color);
    }

    foreach (var color in Enum.GetValues(typeof(Color)))
    {
        Console.WriteLine(color);
    }
}
