using Interfaces;

SortingWithIComparable();
DependencyInjection();

void SortingWithIComparable()
{
    Person person1 = new("Jackie", "Stewart");
    Person person2 = new("Graham", "Hill");
    Person person3 = new("Damon", "Hill");

    Person[] peopleArray1 = { person1, person2, person3 };

    Array.Sort(peopleArray1);

    foreach(var person in peopleArray1)
    {
        Console.WriteLine(person);
    }
}

void DependencyInjection()
{
    Ellipse ellipse1 = new(new ConsoleLogger()) { Position = new(20, 30), Size = new(100, 120) };

    ellipse1.Draw();
}
