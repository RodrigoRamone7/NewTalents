using System;
using Xunit;
using NewTalents;

namespace TestNewTalents
{
    public class CalculadoraTestes
    {
        private Calculadora _calc;
        public CalculadoraTestes()
        {
            _calc = new Calculadora(DateTime.Now.ToShortDateString());
        }

        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        [InlineData (10, 5, 15)]
        [InlineData (30, 32, 62)]
        public void somar_Valoresn1En2_retornarResultado(int n1, int n2, int resultado)
        {
            // Arrange / Act
            int resultadoCalculadora = _calc.somar(n1, n2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        [InlineData(10, 5, 5)]
        [InlineData(30, 32, -2)]
        public void subtrair_Valoresn1En2_retornarResultado(int n1, int n2, int resultado)
        {
            // Arrange / Act
            int resultadoCalculadora = _calc.subtrair(n1, n2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(10, 5, 50)]
        [InlineData(30, 32, 960)]
        public void multiplicar_Valoresn1En2_retornarResultado(int n1, int n2, int resultado)
        {
            // Arrange / Act
            int resultadoCalculadora = _calc.multiplicar(n1, n2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(4, 4, 1)]
        [InlineData(50, 10, 5)]
        [InlineData(30, 3, 10)]
        public void dividir_Valoresn1En2_retornarResultado(int n1, int n2, int resultado)
        {
            // Arrange / Act
            int resultadoCalculadora = _calc.dividir(n1, n2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void dividir_DivisaoPorZero_retornarException()
        {

            // Assert
            Assert.Throws<DivideByZeroException>(
                () => _calc.dividir(3, 0)
             );
        }

        [Fact]
        public void TestarHistorico()
        {

            _calc.somar(1, 2);
            _calc.somar(3, 5);
            _calc.somar(6, 10);
            _calc.somar(5, 8);

            var lista = _calc.historico();

            Assert.NotEmpty(_calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}
