// Call some static functions.
using Methods;

Console.WriteLine($"Pi is {Methods.Math.GetPi()}.");
int int1 = Methods.Math.GetSquareOff(5);

Console.WriteLine($"The square root of 5 is {int1}.");

// Instantiate a Math object.
var math1 = new Methods.Math(); // This instantiates a reference type.

// Call some instance members.
math1.Value = 30;

Console.WriteLine($"The value field of the Math variable contains: {math1.Value}.");
Console.WriteLine($"The square of 5 is {math1.GetSquare}.");

// Invoking methods with local functions.
LocalFunctions.LocalFunction();
LocalFunctions.LocalFunctionWithClosure();

// Using generic methods.
int int2 = 3;
int int3 = 4;

GenericMethods.GenericMethod(ref int2, ref int3);

Console.WriteLine($"The new value of int2: {int2}. The new value of int3: {int3}.");

string string1 = "One";
string string2 = "Two";

GenericMethods.GenericMethod(ref string1, ref string2);

Console.WriteLine($"The new value of string1: {string1}. The new value of string2: {string2}.");
