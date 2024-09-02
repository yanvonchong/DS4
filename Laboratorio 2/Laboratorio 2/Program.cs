using System;
namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.FirstName = "Yan";
            client.LastName = "Von Chong";
            client.Age = 25;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }
    }



    public class Client
    {


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;


        }
    }

}

public class MyClass
{
    public static int Valor;

}