using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_Tarea_N1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los valores de los textBox1 y textBox2 a números
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double resultado = 0;

                // Llamar a la función según la operación seleccionada
                if (radioButton1.Checked) // Suma
                {
                    textBox3.Text = $"{num1} + {num2}";
                    resultado = Sumar(num1, num2);
                }
                else if (radioButton2.Checked) // Resta
                {
                    textBox3.Text = $"{num1} - {num2}";
                    resultado = Restar(num1, num2);
                }
                else if (radioButton3.Checked) // Multiplicación
                {
                    textBox3.Text = $"{num1} * {num2}";
                    resultado = Multiplicar(num1, num2);
                }
                else if (radioButton4.Checked) // División
                {
                    if (num2 != 0)
                    {
                        textBox3.Text = $"{num1} / {num2}";
                        resultado = Dividir(num1, num2);
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0.");
                        return;
                    }
                }
                else if (radioButton5.Checked) // Residuo
                { //aveces sale NaN
                    textBox3.Text = $"{num1} % {num2}";
                    resultado = Residuo(num1, num2);
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una operación.");
                    return;
                }

                // Mostrar el resultado en textBox4
                textBox4.Text = resultado.ToString();
            }//control de error cuando el usuario no ingrese nada
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce números válidos en los campos.");
            }
        }

        // Funciones para cada operación

        private double Sumar(double x, double y)
        {
            return x + y;
        }

        private double Restar(double x, double y)
        {
            return x - y;
        }

        private double Multiplicar(double x, double y)
        {
            return x * y;
        }

        private double Dividir(double x, double y)
        {
            return x / y;
        }

        private double Residuo(double x, double y)
        {
            return x % y;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje flotante
            MessageBox.Show("Hecho por Pedro Zavala");
            //Mensaje introducido para evitar robos.
            // Cerrar el formulario actual
            this.Close();
        }
    }
}
