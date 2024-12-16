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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aperturar
            FormApertura frm = new FormApertura();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                frm.Close();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                frm.Close();
                MessageBox.Show("Ingreso cancelado...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //depositar
            FormRetiro_Deposito frm = new FormRetiro_Deposito();
            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //mejor cliente
            FormMejorC frm = new FormMejorC();
            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Pago interes
            // Filtrar clientes elegibles para intereses
            var clientesConIntereses = TListaCuenta.listaCuentas
                .Where(c => (c.TipoCuenta == "Ahorros" && c.SaldoDisponible >= 10) ||
                            (c.TipoCuenta == "Corriente" && c.SaldoDisponible >= 100))
                .ToList();

            // Procesar el pago de intereses
            foreach (var cuenta in clientesConIntereses)
            {
                double tasaInteres = cuenta.TipoCuenta == "Ahorros" ? 0.0005 : 0.0009;
                cuenta.Depositar(cuenta.SaldoDisponible * tasaInteres);
            }

            // Mostrar los clientes que recibieron intereses
            if (clientesConIntereses.Count > 0)
            {
                string mensaje = "Clientes con intereses pagados:\n";
                foreach (var cuenta in clientesConIntereses)
                {
                    mensaje += $"- {cuenta.Nombre} ({cuenta.TipoCuenta}): Nuevo saldo ${cuenta.SaldoDisponible:F2}\n";
                }
                MessageBox.Show(mensaje, "Pago de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay clientes elegibles para el pago de intereses.", "Pago de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
