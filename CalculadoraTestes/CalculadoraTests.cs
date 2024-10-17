using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
     
      public CalculadoraImp construirClasse()
      {
        string data = "";

        CalculadoraImp calc = new CalculadoraImp(data);

        return calc;
      }

    [Theory]
    [InlineData (1,2,3)]
    [InlineData (4,5,9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
       CalculadoraImp calc = construirClasse();
          
        int resultadoCalculadora = calc.Somar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);  
    }

    [Theory]
    [InlineData (1,2,2)]
    [InlineData (4,5,20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
       CalculadoraImp calc = construirClasse();
          
        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);  
    }

    [Theory]
    [InlineData (6,2,3)]
    [InlineData (5,5,1)]
    public void TestDividir(int val1, int val2, int resultado)
    {
       CalculadoraImp calc = construirClasse();
          
        int resultadoCalculadora = calc.Dividir(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);  
    }


    [Theory]
    [InlineData (6,2,4)]
    [InlineData (5,5,0)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
       CalculadoraImp calc = construirClasse();
          
        int resultadoCalculadora = calc.Subtrair(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);  
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        CalculadoraImp calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

     [Fact]
    public void TestarHistorico()
    {
        CalculadoraImp calc = construirClasse();

        calc.Somar(1,2);
        calc.Somar(2,8);
        calc.Somar(7,5);
        calc.Somar(5,3);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }



   

}
