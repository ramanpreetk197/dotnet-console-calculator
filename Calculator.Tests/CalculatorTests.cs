namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(28L, Add.Eval(23L, 5L));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(20L, Subtract.Eval(35L, 15L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(15L, Multiply.Eval(5L, 3L));
    }
    [Fact]
    public void TestDivide()
    {
        Assert.Equal(6L, Divide.Eval(36L, 6L));
    }
    [Fact]
    public void TestAdd2()
    {
        Assert.Equal(17L, Add.Eval(12L, 5L));
    }
    [Fact]
    public void TestSubtract2()
    {
        Assert.Equal(22L, Subtract.Eval(27L, 5L));
    }
    [Fact]
    public void TestMult2()
    {
        Assert.Equal(56L, Multiply.Eval(8L, 7L));
    }
    [Fact]
    public void TestDivide2()
    {
        Assert.Equal(9L, Divide.Eval(45L, 5L));
    }
    [Fact]
    public void TestAdd3()
    {
        Assert.Equal(69L, Add.Eval(66L, 3L));
    }
    [Fact]
    public void TestSubtract3()
    {
        Assert.Equal(2L, Subtract.Eval(8L, 6L));
    }
    [Fact]
    public void TestMult3()
    {
        Assert.Equal(12L, Multiply.Eval(3L, 4L));
    }
    [Fact]
    public void TestDivide3()
    {
        Assert.Equal(7L, Divide.Eval(35L, 5L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(11, Evaluator.Eval("+", 9, 2));
    }
    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(3, Evaluator.Eval("-", 11, 8));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(81, Evaluator.Eval("*", 9, 9));
    }
    [Fact]
    public void TestDivideOperation()
    {
        Assert.Equal(9, Evaluator.Eval("/", 81, 9));
    }

    [Fact]
    public void TestInvalidOperation()
    {
        Assert.Throws<Exception>(() => Evaluator.Eval("%", 9, 9));
    }

    [Fact]
    public void TestContinueOperations()
    {

        float result1 = Evaluator.Eval("+", 5, 10);
        Assert.Equal(15, result1);
        float result2 = Evaluator.Eval("-", result1, 5);
        Assert.Equal(10, result2);
        float result3 = Evaluator.Eval("*", result2, 2);
        Assert.Equal(20, result3);
        float result4 = Evaluator.Eval("/", result3, 4);
        Assert.Equal(5, result4);
    }
}