using PA_PracticaBanco.Entidades;
using System;
using System.Windows.Forms;

public class Cuenta : Persona
{
    private static int contadorCuentas = 1;
    protected int Numero;
    private double Saldo;
    private string Tipo;

    public int NumeroCuenta => Numero;
    public double SaldoDisponible => Saldo;
    public string TipoCuenta => Tipo;

    public Cuenta(string cedula, string nombre, string direccion, string telefono, int edad, string tipo, double saldoInicial)
        : base(cedula, nombre, direccion, telefono, edad)
    {
        Numero = contadorCuentas++;
        Tipo = tipo;
        Saldo = saldoInicial;
    }

    public override void Imprimir()
    {
        MessageBox.Show($"Cuenta No: {Numero}, Nombre: {Nombre}, Saldo: {Saldo}, Tipo: {Tipo}");
    }

    public void Depositar(double cantidad)
    {
        Saldo += cantidad;
        MessageBox.Show($"Depósito realizado. Nuevo saldo: {Saldo}");
    }

    public void Retirar(double cantidad)
    {
        if (Tipo == "Ahorros" && cantidad <= Saldo ||
            Tipo == "Corriente" && Saldo - cantidad >= 100)
        {
            Saldo -= cantidad;
            MessageBox.Show($"Retiro realizado. Nuevo saldo: {Saldo}");
        }
        else
        {
            MessageBox.Show("Retiro no permitido, saldo insuficiente.");
        }
    }
}
