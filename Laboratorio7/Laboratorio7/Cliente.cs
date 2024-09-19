﻿namespace Laboratorio_7
{
    internal class Clientes
    {
    }
}
class Cliente
{
    private string nombre;
    private int monto;

    public Cliente(string nom)
    {
        nombre = nom;
        monto = 0;
    }

    public void Depositar(int m)
    {
        monto += m;
    }

    public void Extraer(int m)
    {
        monto = monto - m;
    }

    public int RetornarMonto()
    {
        return monto;
    }

    public void Imprimir()
    {
        Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
    }
}