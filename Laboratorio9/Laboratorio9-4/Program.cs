using System;

class Program
{
    static void Main()
    {
        
        Laboratorio94.MiRandom aleatorio = new Laboratorio94.MiRandom();
                
        int Numero_Random = aleatorio.Gen_Numero(1, 100);
        Console.WriteLine($"Número aleatorio entre 1 y 100: {Numero_Random}");
                
        int[] Arreglo_Random = aleatorio.Gen_Arreglo(1, 50, 5);
        Console.WriteLine("Arreglo de números aleatorios entre 1 y 50:");
        foreach (int numero in Arreglo_Random)
        {
            Console.WriteLine(numero);
        }

        Console.ReadKey();
    }
}
