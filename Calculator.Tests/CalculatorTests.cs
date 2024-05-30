namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestAdd2()
    {
        Assert.Equal(25L, Add.Eval(22L, 3L));
    }
    [Fact]
    public void TestAdd3()
    {
        Assert.Equal(41L, Add.Eval(33L, 8L));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(44L, Subtract.Eval(51L, 7L));
    }
    [Fact]
    public void TestSubtract2()
    {
        Assert.Equal(6L, Subtract.Eval(14L, 8L));
    }
    [Fact]
    public void TestSubtract3()
    {
         Assert.Equal(37L, Subtract.Eval(43L, 6L));
    }
    
    [Fact]
    public void TestMult()
    {
        Assert.Equal(12L, Multiply.Eval(4L, 3L));
    }
    [Fact]
    public void TestMult2()
    {
        Assert.Equal(32L, Multiply.Eval(8L, 4L));
    }
    [Fact]
    public void TestMult3()
    {
        Assert.Equal(36L, Multiply.Eval(9L, 4L));
    }
    [Fact]
    public void TestDivide()
    {
        Assert.Equal(3L, Divide.Eval(24L, 8L));
    }
    [Fact]
    public void TestDivide2()
    {
        Assert.Equal(5L, Divide.Eval(25L, 5L));
    }
    [Fact]
    public void TestDivide3()
    {
        Assert.Equal(6L, Divide.Eval(48L, 8L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(12, Evaluator.Eval("-", 16, 4));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestDivideOperation()
    {
        Assert.Equal(4, Evaluator.Eval("/", 32, 8));
    }
}