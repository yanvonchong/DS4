﻿

namespace Laboratorio_8_4
{
    internal class CuentaBancaria
    {
    }
}

// propiedades con validación
public class CuentaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
        set
        {
            if (value >= 0)
            {
                saldo = value;
            }
            else
            {
                throw new ArgumentException("El saldo no puede ser negativo.");
            }
        }
    }
}