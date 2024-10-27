using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_TH_TAREA_N1_PZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje de copyright personal >:)
            MessageBox.Show("Hecho por Pedro Zavala");
            // Cerrar el formulario.
            this.Close();
        }
        //boton calcular:
        private void button1_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(textBox1.Text);
            double descuento = 0; //textbox 2
            double incremento = 0; //textbox 3
            double IGV = 0; //textbox 4
            double total = 0; //textbox 5

            // Si el pago es al contado (checkBox1 está seleccionado)
            if (checkBox1.Checked)
            {
                // radioButton1 = Audio
                if (radioButton1.Checked)
                {
                    descuento = costo * 0.06;
                }
                // radioButton2 = Video
                else if (radioButton2.Checked)
                {
                    descuento = costo * 0.08;
                }
                // radioButton3 = Línea Blanca
                else if (radioButton3.Checked)
                {
                    descuento = costo * 0.05;
                }

                // Aplicar el descuento al costo
                double costoConDescuento = costo - descuento;

                // Calcular IGV sobre el costo con descuento
                IGV = costoConDescuento * 0.19;

                // Calcular el total con descuento e IGV
                total = costoConDescuento + IGV;

                // Mostrar el descuento en el textbox correspondiente
                textBox2.Text = descuento.ToString("F2");
            }
            // Si el pago es a crédito (checkBox1 no está seleccionado)
            else
            {
                // radioButton1 = Audio
                if (radioButton1.Checked)
                {
                    incremento = costo * 0.07;
                }
                // radioButton2 = Video
                else if (radioButton2.Checked)
                {
                    incremento = costo * 0.09;
                }
                // radioButton3 = Línea Blanca
                else if (radioButton3.Checked)
                {
                    incremento = costo * 0.10;
                }

                // Aplicar el incremento al costo
                double costoConIncremento = costo + incremento;

                // Calcular IGV sobre el costo con incremento
                IGV = costoConIncremento * 0.19;

                // Calcular el total con incremento e IGV
                total = costoConIncremento + IGV;

                // Mostrar el incremento en el textbox correspondiente
                textBox3.Text = incremento.ToString("F2");
            }

            // Mostrar el IGV en el textbox correspondiente
            textBox4.Text = IGV.ToString("F2");

            // Mostrar el monto total a pagar en el textbox correspondiente
            textBox5.Text = total.ToString("F2");
        }

        //boton cerrar:
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
