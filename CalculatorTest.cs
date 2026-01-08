using Xunit;

public class CalculatorTest
{
    [Fact]
    public void TestAdd()
    {
        //given
        Calculator calculator = new Calculator();

        int a = 5;
        int b = 2;
        int expectedResult = 7;

        //when
        int result = calculator.Add(a, b);

        //then
        Assert.Equal(expectedResult, result);
    }
}