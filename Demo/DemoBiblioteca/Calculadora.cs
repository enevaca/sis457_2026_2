namespace DemoBiblioteca
{
    public class Calculadora
    {
        public static int sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public static int restar(int minuendo, int sustraendo) => minuendo - sustraendo;

        public static Func<int, int, int> multiplicar = (numero1, numero2) => numero1 * numero2;

        public static int dividir(int dividendo, int divisor) => dividendo / divisor;

        public static int modulo(int dividendo, int divisor) => dividendo % divisor;

        public static long factorial(int numero)
        {
            long factorial = 1;
            for (int i = 2; i <= Math.Abs(numero); i++) factorial *= i;

            if (numero < 0) factorial *= -1;
            return factorial;
        }
    }
}
