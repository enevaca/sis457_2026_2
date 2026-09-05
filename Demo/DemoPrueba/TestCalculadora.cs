using DemoBiblioteca;

namespace DemoPrueba
{
    [TestClass]
    public sealed class TestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables -> Arrage
            int numero1 = 5;
            int numero2 = 7;

            // Ejecutamos la prueba -> Act
            int resultado = Calculadora.sumar(numero1, numero2);

            // Comprobamos el resultado -> Assert
            int resultadoEsperado = 12;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestResta()
        {
            int minuendo = 20, sustraendo = 8;
            int resultado = Calculadora.restar(minuendo, sustraendo);
            Assert.AreEqual(12, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            int numero1 = 5, numero2 = 4;
            int resultado = Calculadora.multiplicar(numero1, numero2);
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(5, Calculadora.dividir(20, 4));
        }

        [TestMethod]
        public void TestDivisionPorCero()
        {
            int dividendo = 20, divisor = 0;
            Assert.Throws<DivideByZeroException>(() => Calculadora.dividir(dividendo, divisor));
        }

        [TestMethod]
        public void TestModulo()
        {
            Assert.AreEqual(2, Calculadora.modulo(10, 4));
        }

        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(120, Calculadora.factorial(5));
        }

        [TestMethod]
        public void TestFactorialNumeroNegativo()
        {
            Assert.AreEqual(-120, Calculadora.factorial(-5));
        }

        [TestMethod]
        public void TestFactorialCero()
        {
            Assert.AreEqual(1, Calculadora.factorial(0));
        }
    }
}
