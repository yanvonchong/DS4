namespace Laboratorio8_2
{
    public class Cuenta 
    {
        private string idCuenta;

        public Cuenta(string prmtIdCuenta)
        {
            this.idCuenta = prmtIdCuenta;
            System.Console.WriteLine("Constructor Clase Base para cuenta {0}", prmtIdCuenta);
        }

        public virtual void CalcularInteres()
        {
            System.Console.WriteLine("Calculando interés de la cuenta {0}", this.idCuenta);
        }

        public string GetIdCuenta()
        {
            return this.idCuenta;
        }
    }

    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularInteres()
        {
            System.Console.WriteLine("CuentaCorriente.CalcularInteres() efectuado para la cuenta {0}", GetIdCuenta());
        }
    }

    public class CuentaAhorro : Cuenta
    {
        public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
        {
        }

        public override void CalcularInteres()
        {
            System.Console.WriteLine("CuentaAhorro.CalcularInteres() efectuado para la cuenta {0}", GetIdCuenta());
        }
    }
}
