class program
{
    static void main(string[] args)
    {
        int num;
        Console.WriteLine("digite el numero deseado: ");
        try
        {
            num = Int16.Parse(Console.ReadLine());

        }
        catch (Exception ex)
        {
            Console.WriteLine("No ha introducido un digito valido");
            num = -1;
        }
        Console.WriteLine(num);
    }
}