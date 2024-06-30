using DefaultInterfaceMethods;

ILogger logger1 = new ConsoleLogger();

logger1.Log("Message");
logger1.Log(new Exception("Sample Exception"));

IEnumerableEx<string> names = new MyCollection<string> { "James", "Jack", "Jochen", "Sebastian", "Lewis", "Juan" };

var namesStartingWithJ = names.Where(name => name.StartsWith("J"));

foreach(var name in namesStartingWithJ)
{
    Console.WriteLine(name);
}
