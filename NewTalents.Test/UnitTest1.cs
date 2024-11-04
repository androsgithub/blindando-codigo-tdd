using NewTalents.App;

namespace NewTalents.Test;

public class UnitTest1
{
    private Calculadora _calc;

    public UnitTest1()
    {
        _calc = new Calculadora();
    }

    [Theory]
    [InlineData(2, 2, 4)]

    public void Somar(int val1, int val2, int resultado)
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(resultado, _calc.Somar(val1, val2));
    }


    [Theory]
    [InlineData(4, 2, 2)]

    public void Subtrair(int val1, int val2, int resultado)
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(resultado, _calc.Subtrair(val1, val2));
    }


    [Theory]
    [InlineData(4, 2, 8)]
    public void Multiplicar(int val1, int val2, int resultado)
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(resultado, _calc.Multiplicar(val1, val2));
    }


    [Theory]
    [InlineData(8, 2, 4)]
    public void Dividir(int val1, int val2, int resultado)
    {
        // Arrange
        // Act
        // Assert
        Assert.Equal(resultado, _calc.Dividir(val1, val2));
    }

    [Fact]
    public void DividirPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void HistoricoComItens()
    {
        // Arrange
        // Act
        _calc.Somar(2, 2);
        _calc.Subtrair(4, 4);
        _calc.Multiplicar(3, 3);
        // Assert
        Assert.Equal(3, _calc.Historico().Count);
    }
}