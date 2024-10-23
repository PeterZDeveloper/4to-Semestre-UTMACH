using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PA_Intra_N1_3_Aviones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Fila 1
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "Nueva York";
            dataGridView1[1, 0].Value = "$400";
            dataGridView1[2, 0].Value = "$700";
            dataGridView1[3, 0].Value = "$1000";
            //Fila 2
            dataGridView1.Rows.Add();
            dataGridView1[0, 1].Value = "Paris";
            dataGridView1[1, 1].Value = "$500";
            dataGridView1[2, 1].Value = "$800";
            dataGridView1[3, 1].Value = "$1200";
            //Fila 3
            dataGridView1.Rows.Add();
            dataGridView1[0, 2].Value = "Tokio";
            dataGridView1[1, 2].Value = "$600";
            dataGridView1[2, 2].Value = "$900";
            dataGridView1[3, 2].Value = "$1400";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double bol = Convert.ToDouble(textBox1.Text); // Número de boletos
            string city = " ";
            string clase = " ";

            // VARIABLES PARA EL CALCULO DE FECHA
            DateTime tpedido = dateTimePicker1.Value; // La fecha de compra
            DateTime tvuelo = dateTimePicker2.Value; // Fecha del vuelo

                // CALCULO DE DIAS DE ANTELACION O DE URGENCIA
                TimeSpan diferencia = tvuelo - tpedido;
                int diasAntelacion = diferencia.Days;
                
                if (diasAntelacion < 0)
                {
                    MessageBox.Show("Error: La fecha del vuelo no puede ser anterior a la fecha del pedido.");
                    return;
                }
                
                double precioBase=0;
                double precioIntermedio = 0;

                double precioFinal = 0;
            double recargo = 0;
            double descuentoAntelacion = 0;
            double descuentoCantidad = 0;
            double descuentoFidelidad = 0;

            // Definir destino y clase seleccionada
            if (radioButton1.Checked)
            {
                city = "Nueva York";
                if (radioButton4.Checked) { precioBase = 400; clase = "Económica"; dataGridView1[1, 0].Style.BackColor = Color.LightGreen;}
                    else if (radioButton5.Checked) { precioBase = 700; clase = "Ejecutiva"; dataGridView1[2, 0].Style.BackColor = Color.LightGreen; }
                
                else if (radioButton6.Checked) { precioBase = 1000; clase = "Primera Clase"; dataGridView1[3, 0].Style.BackColor = Color.LightGreen; }
            
            }
            else if (radioButton2.Checked)
            {
                city = "París";
                if (radioButton4.Checked) { precioBase = 500; clase = "Económica"; dataGridView1[1, 1].Style.BackColor = Color.LightGreen; }
                    else if (radioButton5.Checked) { precioBase = 800; clase = "Ejecutiva"; dataGridView1[2, 1].Style.BackColor = Color.LightGreen; }
                    else if (radioButton6.Checked) { precioBase = 1200; clase = "Primera Clase"; dataGridView1[3, 1].Style.BackColor = Color.LightGreen; }
                }
            else if (radioButton3.Checked)
            {
                city = "Tokio";
                if (radioButton4.Checked) { precioBase = 600; clase = "Económica"; dataGridView1[1, 2].Style.BackColor = Color.LightGreen; }
                    else if (radioButton5.Checked) { precioBase = 900; clase = "Ejecutiva"; dataGridView1[2, 2].Style.BackColor = Color.LightGreen; }
                    else if (radioButton6.Checked) { precioBase = 1400; clase = "Primera Clase"; dataGridView1[3, 2].Style.BackColor = Color.LightGreen; }
                }

                // TEMPORADA (Alta o baja)
                if (radioButton8.Checked) // Temporada alta
                {
                    precioBase += precioBase * 0.30; // Aumento del 30% en temporada alta
                }

                // Guardamos el precio modificado como un valor intermedio para aplicar más recargos/descuentos.
                precioIntermedio = precioBase;

                // CALCULOS DE ANTELACIÓN O ULTIMA HORA
                if (diasAntelacion < 7)
                {
                    // Aumento por compra de última hora (menos de 7 días)
                    recargo = precioIntermedio * 0.20;
                }
                else if (diasAntelacion > 30)
                {
                        descuentoAntelacion = precioIntermedio * 0.10;
                }
                // Apliquemos el recargo primero (si existe)
                precioIntermedio += recargo;

                // DESCUENTO POR CANTIDAD DE BOLETOS (Si se compran 5 o más boletos)
                if (bol >= 5)
                {
                    descuentoCantidad = precioIntermedio * 0.15; // Descuento del 15% si se compran 5 o más boletos
                }

                // DESCUENTO POR FIDELIDAD (Miembro del programa de fidelidad)
                if (radioButton9.Checked) // Miembro del programa
                {
                    descuentoFidelidad = precioIntermedio * 0.05;
                }

                // Ahora aplicamos los descuentos al precio intermedio
                precioFinal = precioIntermedio - descuentoCantidad - descuentoFidelidad - descuentoAntelacion;

                // Calcular el total final multiplicado por la cantidad de boletos
                double totalFinal = precioFinal * bol; // Multiplica una vez se tengan todos los recargos/descuentos aplicados


                // Mostrar resultados
                MessageBox.Show("Se ha comprado: " + bol + " boleto/s" +
                            "\nLos boletos comprados son de clase: " + clase +
                            "\nCon destino a la Ciudad: " + city +
                            "\nEl precio final por boleto es: $" + precioFinal.ToString("F2") +
                            "\nEl precio total por todos los boletos es de: $" + totalFinal.ToString("F2") +
                            "\nEl pedido de los/del boleto/s fue realizado en la fecha: " + tpedido.ToShortDateString() +
                            "\nCon una antelación de: " + diasAntelacion + " días.");
        }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un número válido en la cantidad de boletos.");
            }
}



    }

}
