using GenericTypesWithConstraints;

GenericTypesWithConstraints.LinkedList<Person> linkedList4 = new();

linkedList4.AddLast(new Person("Stephanie", "Nagel", "Mrs"));
linkedList4.AddLast(new Person("Matthias", "Nagel", "Mr"));
linkedList4.AddLast(new Person("Katharina", "Nagel", "Mrs"));

Console.WriteLine(linkedList4.First);

public record Person(string FirstName, string LastName, string Title) : ITitle { }
