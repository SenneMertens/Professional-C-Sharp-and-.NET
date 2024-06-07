using Classes;

Book book1 = new("Professional C# and .NET") { Publisher = "Wrox Press" };

Person person1 = new("Katharina", "Nagel");

Console.WriteLine($"{person1.FirstName} {person1.LastName}.");

GreetingService greetingService1 = new();
var greeting1 = greetingService1.Greet(person1);

Console.WriteLine(greeting1);

// Deconstruction

(var firstName1, var lastName1, _) = person1;

Console.WriteLine($"{firstName1} {lastName1}.");
