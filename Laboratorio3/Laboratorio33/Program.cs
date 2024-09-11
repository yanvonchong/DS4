using System;

namespace CalculadoraRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de perímetro de un rectángulo");

            // Pedimos al usuario que ingrese los lados
            Console.Write("Ingrese la longitud del primer lado: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la longitud del segundo lado: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            // Calculamos el perímetro
            double perimetro = 2 * (lado1 + lado2);

            // Mostramos el resultado
            Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
        }
    }
}