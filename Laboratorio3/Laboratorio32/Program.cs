using System;

namespace CalculadoraCirculo
{
    class Circulo
    {
        public double Radio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo();

            Console.Write("Ingrese el radio del círculo: ");
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                miCirculo.Radio = radio;
                double area = miCirculo.CalcularArea();
                Console.WriteLine($"El área del círculo es: {area:F2}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }

            Console.ReadKey();
        }
    }
}