DigitSeparators();
BinaryNumbers();

void DigitSeparators()
{
    long long1 = 0x12_4567_89ab_cedf;
    long long2 = 0x123456789abcedf;
    long long3 = 0x12345_6789_abc_ed_f;

    Console.WriteLine(long1);
    Console.WriteLine(long2);
    Console.WriteLine(long3);
}

void BinaryNumbers()
{
    uint binary1 = 0b_1111_1110_1101_1100_1011_1010_1001_1000;
    uint hexadecimal1 = 0xfedcba98;
    uint binary2 = 0b_111_010_101_100_011_010_001_000;
    ushort binary3 = 0b_1111_0000_101010_11;

    Console.WriteLine(binary1);
    Console.WriteLine(hexadecimal1);
    Console.WriteLine(binary2);
    Console.WriteLine(binary3);
}
