using System;

class Program
{
    static void Main(string[] args)
    {
        int Age = 19;
        if (Age < 18)
        {
            throw new ArithmeticException("Acceso negado - No cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso Concedido");
        }
    }
}