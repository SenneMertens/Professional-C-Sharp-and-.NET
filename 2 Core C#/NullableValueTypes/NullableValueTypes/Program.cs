int? number1 = null;

if (number1.HasValue)
{
    int number2 = number1.Value;
}

int number3 = 42;
int? number4 = number3;
Nullable<int> number5 = null;
int number6 = number5.GetValueOrDefault();
