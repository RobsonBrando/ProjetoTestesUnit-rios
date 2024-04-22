using CalculadoraProject;

namespace CalculadoraTest
{
    public class TestCalculadora
    {
        public Calculadora ConstruirClasse()
        {
            string data = "22/04/2024";
            Calculadora calculadora = new Calculadora(data);

            return calculadora;
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 6)]
        public void TestSoma(int val1, int val2, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();

            int resultadoCalculadora = calculadora.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(10, 4, 6)]
        public void TestSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();
            int resultadoCalculadora = calculadora.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(8, 4, 2)]
        public void TestDividir(int val1, int val2, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();

            int resultadoCalculadora = calculadora.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 4, 8)]
        public void TestMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();

            int resultadoCalculadora = calculadora.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TestDividirPorZero()
        {
            Calculadora calculadora = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(4, 0));
        }
        [Fact]
        public void TestHistorico()
        {
            Calculadora calculadora = ConstruirClasse();

            calculadora.Somar(2, 93);
            calculadora.Somar(45, 12);
            calculadora.Somar(15, 4);
            calculadora.Somar(7, 4);

            var lista = calculadora.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}