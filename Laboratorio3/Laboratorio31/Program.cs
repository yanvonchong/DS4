using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int b = int.Parse(Console.ReadLine());

            int resultado = CalculosMatematicos.Calcular(a, b);
            Console.WriteLine($"El resultado de la operación (a+b)*(a-b) es: {resultado}");
        }
    }

    class CalculosMatematicos
    {
        public static int Calcular(int a, int b)
        {
            int suma = Sumar(a, b);
            int resta = Restar(a, b);

            return Multiplicar(suma, resta);
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
}