using System;
using System.Collections.Generic;
using System.Linq;

namespace PA_PracticaBanco.Controlador
{
    public class TListaCuenta
    {
        public static List<Cuenta> listaCuentas = new List<Cuenta>();

        // Insertar nueva cuenta
        public static void Insertar(Cuenta cuenta)
        {
            listaCuentas.Add(cuenta);
        }

        // Eliminar cuenta por posición
        public static void Eliminar(int posicion)
        {
            if (posicion >= 0 && posicion < listaCuentas.Count)
                listaCuentas.RemoveAt(posicion);
            else
                Console.WriteLine("Posición inválida.");
        }

        // Editar una cuenta existente
        public static void Editar(Cuenta cuenta, int posicion)
        {
            if (posicion >= 0 && posicion < listaCuentas.Count)
                listaCuentas[posicion] = cuenta;
            else
                Console.WriteLine("Posición inválida.");
        }

        // Buscar por número de cuenta
        public static int BuscarPorNumero(int numeroCuenta)
        {
            return listaCuentas.FindIndex(c => c.NumeroCuenta == numeroCuenta);
        }

        // Buscar por cédula
        public static Cuenta BuscarPorCedula(string cedula)
        {
            return listaCuentas.FirstOrDefault(c => c.Cedula == cedula);
        }

        // Obtener cliente con mayor saldo
        public static Cuenta ObtenerMayorSaldo()
        {
            return listaCuentas.OrderByDescending(c => c.SaldoDisponible).FirstOrDefault();
        }

        // Aplicar pago de intereses
        public static void PagarIntereses()
        {
            foreach (var cuenta in listaCuentas)
            {
                if (cuenta.TipoCuenta == "Ahorros" && cuenta.SaldoDisponible >= 10)
                {
                    cuenta.Depositar(cuenta.SaldoDisponible * 0.0005);
                }
                else if (cuenta.TipoCuenta == "Corriente" && cuenta.SaldoDisponible >= 100)
                {
                    cuenta.Depositar(cuenta.SaldoDisponible * 0.0009);
                }
            }
        }

        // Obtener todas las cuentas como lista
        public static List<Cuenta> ObtenerTodas()
        {
            return listaCuentas.ToList();
        }
    }
}
