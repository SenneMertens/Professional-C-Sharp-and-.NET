// Passing a value type by reference.
int int1 = 1;

ChangingAValueTypeByReference(ref int1);

Console.WriteLine($"The value of int1 changed to: {int1}.");

// Passing a reference by reference.
SomeData someData1 = new() { Value = 1 };

ChangingAReferenceTypeByReference(ref someData1);

Console.WriteLine($"The new value of some someData1.Value is: {someData1.Value}.");

// Using the in modifier to pass by reference and making the variable read-only.
SomeValue someValue1 = new(1, 2, 3, 4);

PassingAValueTypeByReferenceReadOnly(someValue1);

// Using a refernce return.
SomeValue someValue2 = new(1, 2, 3, 4);
SomeValue someValue3 = new(5, 6, 7, 8);

SomeValue result1 = ReferenceReturn(ref someValue2, ref someValue3);
ref SomeValue result2 = ref ReferenceReturn(ref someValue2, ref someValue3);
ref readonly SomeValue result3 = ref ReferenceReturn(ref someValue2, ref someValue3);

ref readonly SomeValue result4 = ref ReferenceReturnReadOnly(in someValue2, in someValue3);
SomeValue result5 = ReferenceReturnReadOnly(in someValue2, in someValue3);

void ChangingAValueTypeByReference(ref int int1)
{
    int1 = 2;
}

void ChangingAReferenceTypeByReference(ref SomeData somedata1)
{
    somedata1.Value = 2;
    somedata1 = new() { Value = 3 };
}

void PassingAValueTypeByReferenceReadOnly(in SomeValue someValue1)
{
    // someValue1.Value1 = 4; // You can't change the value as it's a read-only variable.
}

ref SomeValue ReferenceReturn(ref SomeValue someValue1, ref SomeValue someValue2)
{
    int sum1 = someValue1.Value1 + someValue1.Value2 + someValue1.Value3 + someValue1.Value4;
    int sum2 = someValue2.Value1 + someValue2.Value2 + someValue2.Value3 + someValue2.Value4;

    ref SomeValue result1 = ref (sum1 > sum2) ? ref someValue1 : ref someValue2;

    return ref result1;
}

ref readonly SomeValue ReferenceReturnReadOnly(in SomeValue someValue1, in SomeValue someValue2)
{
    int sum1 = someValue1.Value1 + someValue1.Value2 + someValue1.Value3 + someValue1.Value4;
    int sum2 = someValue2.Value1 + someValue2.Value2 + someValue2.Value3 + someValue2.Value4;

    return ref (sum1 > sum2) ? ref someValue1 : ref someValue2;
}

public class SomeData
{
    public int Value { get; set; }
}

public struct SomeValue
{
    public int Value1 { get; set; }

    public int Value2 { get; set; }

    public int Value3 { get; set; }

    public int Value4 { get; set; }

    public SomeValue(int value1, int value2, int value3, int value4)
    {
        Value1 = value1;
        Value2 = value2;
        Value3 = value3;
        Value4 = value4;
    }
}