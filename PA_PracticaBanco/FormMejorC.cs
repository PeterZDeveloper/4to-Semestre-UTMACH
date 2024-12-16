using PA_PracticaBanco.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_PracticaBanco
{
    public partial class FormMejorC : Form
    {
        public FormMejorC()
        {
            InitializeComponent();
            RellenarInfo();
            var cuenta1 = new Cuenta("2350837296", "Pedro Zavala", "Junin y Olmedo", "099999999", 30, "Ahorros", 1500);
            var cuenta2 = new Cuenta("9876543210", "Juan Pérez", "Guabo y Buenavista", "088888888", 25, "Corriente", 2000);
            var cuenta3 = new Cuenta("1112223334", "Ana Gómez", "Juan montalvo y 25 de junio", "077777777", 40, "Ahorros", 5);
            var cuenta4 = new Cuenta("5556667778", "Luis Martínez", "Palmeras y octava norte", "066666666", 35, "Corriente", 80);
            TListaCuenta.Insertar(cuenta1);
            TListaCuenta.Insertar(cuenta2);
            TListaCuenta.Insertar(cuenta3);
            TListaCuenta.Insertar(cuenta4);
        }

        public void RellenarInfo()
        {
            // Obtener los clientes con mayor saldo para ahorros y corriente
            var clienteAhorros = TListaCuenta.listaCuentas
                .Where(c => c.TipoCuenta == "Ahorros")
                .OrderByDescending(c => c.SaldoDisponible)
                .FirstOrDefault();

            var clienteCorriente = TListaCuenta.listaCuentas
                .Where(c => c.TipoCuenta == "Corriente")
                .OrderByDescending(c => c.SaldoDisponible)
                .FirstOrDefault();

            // Rellenar datos para cuenta de ahorros
            if (clienteAhorros != null)
            {
                textBox1.Text = clienteAhorros.NumeroCuenta.ToString();
                textBox2.Text = clienteAhorros.Nombre;
                textBox3.Text = clienteAhorros.TipoCuenta;
                textBox4.Text = clienteAhorros.SaldoDisponible.ToString("F2");
            }
            else
            {
                textBox1.Text = "No implementado";
                textBox2.Text = "No implementado";
                textBox3.Text = "No implementado";
                textBox4.Text = "No implementado";
            }

            // Rellenar datos para cuenta corriente
            if (clienteCorriente != null)
            {
                textBox5.Text = clienteCorriente.NumeroCuenta.ToString();
                textBox6.Text = clienteCorriente.Nombre;
                textBox7.Text = clienteCorriente.TipoCuenta;
                textBox8.Text = clienteCorriente.SaldoDisponible.ToString("F2");
            }
            else
            {
                textBox5.Text = "No implementado";
                textBox6.Text = "No implementado";
                textBox7.Text = "No implementado";
                textBox8.Text = "No implementado";
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cerrar
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //actualizar
            RellenarInfo();
        }
    }
}
