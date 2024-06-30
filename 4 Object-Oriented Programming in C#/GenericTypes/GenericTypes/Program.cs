LinkedList<int> linkedList1 = new();

linkedList1.AddLast(1);
linkedList1.AddLast(2);
linkedList1.AddLast(3);

foreach (var item in linkedList1)
{
    Console.WriteLine(item);
}

LinkedList<string> linkedList2 = new();

linkedList2.AddLast("Two");
linkedList2.AddLast("Four");
linkedList2.AddLast("Six");

Console.WriteLine(linkedList2.Last);

LinkedList <(int, int)> linkedList3 = new();

linkedList3.AddLast((1, 2));
linkedList3.AddLast((3, 4));

foreach (var item in linkedList3)
{
    Console.WriteLine(item);
}

LinkedList<Person> linkedList4 = new();

linkedList4.AddLast(new Person("Stephanie", "Nagel"));
linkedList4.AddLast(new Person("Matthias", "Nagel"));
linkedList4.AddLast(new Person("Katharina", "Nagel"));

Console.WriteLine(linkedList4.First);

public record Person(string FirstName, string LastName);
