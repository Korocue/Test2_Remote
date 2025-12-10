namespace CSharpTests;

public static class Calculator
{
    public static int Add(int left, int right) => left + right;

    public static int Multiply(int left, int right) => left * right;

    public static bool IsEven(int value) => value % 2 == 0;
}
