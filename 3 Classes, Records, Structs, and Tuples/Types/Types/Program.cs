Struct struct1 = new() { A = 1 };
Struct struct2 = struct1;

struct2.A = 2;

Console.WriteLine($"The original value didn't change with a Struct type: {struct1.A}.");

Class class1 = new() { A = 1 };
Class class2 = class1;

class2.A = 2;

Console.WriteLine($"The original value changed with a Class type: {class1.A}.");

Record record1 = new() { A = 1 };
Record record2 = record1;

record2.A = 2;

Console.WriteLine($"The original value changed with a Record type: {record1.A}.");

var tuple1 = (Number: 1, String: "A");
var tuple2 = tuple1;

tuple2.Number = 2;
tuple2.String = "B";

Console.WriteLine($"The original value didn't change with a Tuple type: {tuple1.Number}, {tuple1.String}.");

public struct Struct
{
    public int A;
}

public class Class
{
    public int A;
}

public record Record
{
    public int A;
}
