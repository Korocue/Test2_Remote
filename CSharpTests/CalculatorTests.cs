using CSharpTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsExpectedSum(int left, int right, int expected)
    {
        Assert.Equal(expected, Calculator.Add(left, right));
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(0, 5, 0)]
    public void Multiply_ReturnsExpectedProduct(int left, int right, int expected)
    {
        Assert.Equal(expected, Calculator.Multiply(left, right));
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(0, true)]
    public void IsEven_ReturnsExpectedParity(int value, bool expected)
    {
        Assert.Equal(expected, Calculator.IsEven(value));
    }
}
