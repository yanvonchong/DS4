using System;

class Program
{
    private int[] sueldos; 

    public void Cargar()
    {
        sueldos = new int[6]; 
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + f + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); 
        }
    }

   
    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios: ");
        for (int f = 1; f <= 5; f++)
        {
            Console.WriteLine("[" + sueldos[f] + "]");
        }
        Console.ReadKey();
    }

    
    static void Main(string[] args)
    {
        Program pv = new Program();
        pv.Cargar();
        pv.Imprimir();
    }
}
