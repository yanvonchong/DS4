namespace Laboratorio8_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string CUENTA = "100";

            Cuenta cuenta = new Cuenta(CUENTA);
            CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);
            CuentaAhorro cuentaAhorro = new CuentaAhorro(CUENTA);

            cuenta.CalcularInteres(); // Llama al método base
            cuentaCorriente.CalcularInteres(); // Llama al método de la cuenta corriente
            cuentaAhorro.CalcularInteres(); // Llama al método de la cuenta de ahorro
        }
    }
}
