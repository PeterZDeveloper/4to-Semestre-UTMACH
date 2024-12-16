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
    public partial class FormRetiro_Deposito : Form
    {
        public FormRetiro_Deposito()
        {
            InitializeComponent();
        }


        private Cuenta cuentaActual;


        private void button3_Click(object sender, EventArgs e)
        {
            //salir
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton buscar
            // Buscar cliente por número de cuenta o cédula
            string busqueda = textBox1.Text;
            cuentaActual = TListaCuenta.listaCuentas
                .FirstOrDefault(c => c.NumeroCuenta.ToString() == busqueda || c.Cedula == busqueda);

            if (cuentaActual != null)
            {
                // Mostrar los datos en los TextBox correspondientes
                textBox3.Text = cuentaActual.NumeroCuenta.ToString();
                textBox4.Text = cuentaActual.Nombre;
                textBox5.Text = cuentaActual.TipoCuenta;
                textBox6.Text = cuentaActual.SaldoDisponible.ToString("F2");
            }
            else
            {
                // Mostrar mensaje si no se encuentra
                MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCampos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //realziar transaccion
            // Validar si hay un cliente seleccionado
            if (cuentaActual == null)
            {
                MessageBox.Show("Por favor, busque un cliente antes de realizar una transacción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar cantidad ingresada
            if (!double.TryParse(textBox2.Text, out double cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar tipo de transacción
            if (radioButton1.Checked) // Depósito
            {
                cuentaActual.Depositar(cantidad);
                MessageBox.Show($"Depósito realizado. Nuevo saldo: {cuentaActual.SaldoDisponible:F2}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked) // Retiro
            {
                // Validar condiciones para retiro
                if (cuentaActual.TipoCuenta == "Ahorros" && cantidad > cuentaActual.SaldoDisponible)
                {
                    MessageBox.Show("No puede retirar más del saldo disponible en una cuenta de ahorros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cuentaActual.TipoCuenta == "Corriente" && (cantidad > cuentaActual.SaldoDisponible || cuentaActual.SaldoDisponible - cantidad < 100))
                {
                    MessageBox.Show("El saldo mínimo en una cuenta corriente debe ser de $100 después del retiro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cuentaActual.Retirar(cantidad);
                MessageBox.Show($"Retiro realizado. Nuevo saldo: {cuentaActual.SaldoDisponible:F2}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de transacción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Actualizar los datos en los TextBox
            textBox6.Text = cuentaActual.SaldoDisponible.ToString("F2");
        }

        private void LimpiarCampos()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
