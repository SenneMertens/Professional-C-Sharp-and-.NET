for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
} // 'i' goes out of scope here.

// We can declare a variable named 'i' again, because there's no other variable with that name in scope.

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
} // 'i' goes out of scope here.

int j = 20;

for (int i = 0; i < 10; i++)
{
    // int j = 30 // This will throw an error as 'j' is still in scope.

    Console.WriteLine(i + j);
}
