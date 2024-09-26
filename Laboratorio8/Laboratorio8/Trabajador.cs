namespace Laboratorio8
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string NIF { get; set; }

        public Persona(string nombre, int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nif;
        }
    }

    internal class Trabajador : Persona
    {
        public int Salario { get; set; }

        public Trabajador(string nombre, int edad, string nif, int salario) : base(nombre, edad, nif)
        {
            Salario = salario;
        }
    }
}
