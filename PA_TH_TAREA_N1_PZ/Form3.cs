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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        //boton agregar
        private void button4_Click(object sender, EventArgs e)
        {
            string CursoSeleccionado = listBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem.Equals("TI"))
          {
            switch (CursoSeleccionado)
            {
                case "AI Boot Camp":
                    listBox4.Items.Add("AI Boot Camp");
                    listBox2.Items.Remove(350);
                    listBox3.Items.Add(350);
                    break;
                case "Curso de programación":
                    listBox4.Items.Add("Curso de programación");
                    listBox2.Items.Remove(1000);

                    listBox3.Items.Add(1000);

                    break;
                case "Curso de algoritmos":
                    listBox4.Items.Add("Curso de algoritmos");
                    listBox2.Items.Remove(150);
                    listBox3.Items.Add(150);

                    break;
                case "Curso de Power BI":
                    listBox4.Items.Add("Curso de Power BI");
                    listBox2.Items.Remove(150);
                    listBox3.Items.Add(150);

                    break;
                case "Curso de Scrum":
                    listBox4.Items.Add("Curso de Scrum");
                    listBox2.Items.Remove(250);
                    listBox3.Items.Add(250);

                    break;
            }
            listBox1.Items.Remove(listBox1.SelectedItem); // Remover el elemento seleccionado de la listBox1
        }

            if (comboBox1.SelectedItem.Equals("Derecho"))
            {
                switch (CursoSeleccionado)
                {
                    case "Criminologia":
                        listBox4.Items.Add("Criminologia");
                        listBox2.Items.Remove(750);
                        listBox3.Items.Add(750);
                        break;
                    case "Derecho femenino":
                        listBox4.Items.Add("Derecho femenino");
                        listBox2.Items.Remove(100);

                        listBox3.Items.Add(100);

                        break;
                    case "Copyright":
                        listBox4.Items.Add("Copyright");
                        listBox2.Items.Remove(400);
                        listBox3.Items.Add(400);

                        break;
                    case "Derecho Penal":
                        listBox4.Items.Add("Derecho Penal");
                        listBox2.Items.Remove(500);
                        listBox3.Items.Add(500);

                        break;
                    case "Politicas Publicas":
                        listBox4.Items.Add("Politicas Publicas");
                        listBox2.Items.Remove(100);
                        listBox3.Items.Add(100);

                        break;
                }
                listBox1.Items.Remove(listBox1.SelectedItem); // Remover el elemento seleccionado de la listBox1
            }

            if (comboBox1.SelectedItem.Equals("Medicina"))
            {
                switch (CursoSeleccionado)
                {
                    case "Gastroenterología":
                        listBox4.Items.Add("Gastroenterología");
                        listBox2.Items.Remove(3750);
                        listBox3.Items.Add(3750);
                        break;
                    case "Electrocardiografía":
                        listBox4.Items.Add("Electrocardiografía");
                        listBox2.Items.Remove(4000);

                        listBox3.Items.Add(4000);

                        break;
                    case "Primeros Auxilios":
                        listBox4.Items.Add("Primeros Auxilios");
                        listBox2.Items.Remove(200);
                        listBox3.Items.Add(200);

                        break;
                    case "Terapia floral":
                        listBox4.Items.Add("Terapia floral");
                        listBox2.Items.Remove(200);
                        listBox3.Items.Add(200);

                        break;
                    case "Neurociencia":
                        listBox4.Items.Add("Neurociencia");
                        listBox2.Items.Remove(5000);
                        listBox3.Items.Add(5000);

                        break;
                }
                listBox1.Items.Remove(listBox1.SelectedItem); // Remover el elemento seleccionado de la listBox1
            }
        }

        //boton eliminar
        private void button5_Click(object sender, EventArgs e)
        {
            string CursoAEliminar = listBox4.SelectedItem.ToString();
            if (comboBox1.SelectedItem.Equals("TI"))
            {
                switch (CursoAEliminar)
                {
                    case "AI Boot Camp":
                        listBox4.Items.Add("AI Boot Camp");
                        listBox2.Items.Remove(350);
                        listBox3.Items.Add(350);
                        break;
                    case "Curso de programación":
                        listBox4.Items.Add("Curso de programación");
                        listBox2.Items.Remove(1000);

                        listBox3.Items.Add(1000);

                        break;
                    case "Curso de algoritmos":
                        listBox4.Items.Add("Curso de algoritmos");
                        listBox2.Items.Remove(150);
                        listBox3.Items.Add(150);

                        break;
                    case "Curso de Power BI":
                        listBox4.Items.Add("Curso de Power BI");
                        listBox2.Items.Remove(150);
                        listBox3.Items.Add(150);

                        break;
                    case "Curso de Scrum":
                        listBox4.Items.Add("Curso de Scrum");
                        listBox2.Items.Remove(250);
                        listBox3.Items.Add(250);

                        break;
                }
                listBox4.Items.Remove(listBox4.SelectedItem); // Remover el elemento seleccionado de la listBox1
            }

            if (comboBox1.SelectedItem.Equals("Derecho"))
            {
                switch (CursoAEliminar)
                {
                    case "Criminologia":
                        listBox1.Items.Add("Criminologia");
                        listBox3.Items.Remove(750);
                        listBox2.Items.Add(750);
                        break;
                    case "Derecho femenino":
                        listBox1.Items.Add("Derecho femenino");
                        listBox3.Items.Remove(100);

                        listBox2.Items.Add(100);

                        break;
                    case "Copyright":
                        listBox1.Items.Add("Copyright");
                        listBox3.Items.Remove(400);
                        listBox2.Items.Add(400);

                        break;
                    case "Derecho Penal":
                        listBox1.Items.Add("Derecho Penal");
                        listBox3.Items.Remove(500);
                        listBox2.Items.Add(500);

                        break;
                    case "Politicas Publicas":
                        listBox1.Items.Add("Politicas Publicas");
                        listBox3.Items.Remove(100);
                        listBox2.Items.Add(100);

                        break;
                }
                listBox4.Items.Remove(listBox4.SelectedItem); // Remover el elemento seleccionado de la listBox1
            }

            if (comboBox1.SelectedItem.Equals("Medicina"))
            {
                switch (CursoAEliminar)
                {
                    case "Gastroenterología":
                        listBox1.Items.Add("Gastroenterología");
                        listBox3.Items.Remove(3750);
                        listBox2.Items.Add(3750);
                        break;
                    case "Electrocardiografía":
                        listBox1.Items.Add("Electrocardiografía");
                        listBox3.Items.Remove(4000);

                        listBox2.Items.Add(4000);

                        break;
                    case "Primeros Auxilios":
                        listBox1.Items.Add("Primeros Auxilios");
                        listBox3.Items.Remove(200);
                        listBox2.Items.Add(200);

                        break;
                    case "Terapia floral":
                        listBox1.Items.Add("Terapia floral");
                        listBox3.Items.Remove(200);
                        listBox2.Items.Add(200);

                        break;
                    case "Neurociencia":
                        listBox1.Items.Add("Neurociencia");
                        listBox3.Items.Remove(5000);
                        listBox2.Items.Add(5000);

                        break;
                }
                listBox4.Items.Remove(listBox4.SelectedItem); // Remover el elemento seleccionado de la listBox1
            }
        }
        //combo box de los cursos:
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             * TI
               Derecho
               Medicina
             */
            if (comboBox1.SelectedItem.Equals("TI"))
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                //cursos
                listBox1.Items.Add("AI Boot Camp");
                listBox1.Items.Add("Curso de programación");
                listBox1.Items.Add("Curso de algoritmos");
                listBox1.Items.Add("Curso de Power BI");
                listBox1.Items.Add("Curso de Scrum");

                //precios
                listBox2.Items.Add(350);
                listBox2.Items.Add(1000);
                listBox2.Items.Add(150);
                listBox2.Items.Add(150);
                listBox2.Items.Add(250);
            }
            if (comboBox1.SelectedItem.Equals("Derecho"))
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                //cursos
                listBox1.Items.Add("Criminologia");
                listBox1.Items.Add("Derecho femenino");
                listBox1.Items.Add("Copyright");
                listBox1.Items.Add("Derecho Penal");
                listBox1.Items.Add("Politicas Publicas");

                //precios
                listBox2.Items.Add(750);
                listBox2.Items.Add(100);
                listBox2.Items.Add(400);
                listBox2.Items.Add(500);
                listBox2.Items.Add(100);
            }
            if (comboBox1.SelectedItem.Equals("Medicina"))
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                //cursos
                listBox1.Items.Add("Gastroenterología");
                listBox1.Items.Add("Electrocardiografía");
                listBox1.Items.Add("Primeros Auxilios");
                listBox1.Items.Add("Terapia floral");
                listBox1.Items.Add("Neurociencia");

                //precios
                listBox2.Items.Add(3750);
                listBox2.Items.Add(4000);
                listBox2.Items.Add(200);
                listBox2.Items.Add(200);
                listBox2.Items.Add(5000);
            }
        }
        //todos los valores a cero
        private void button2_Click(object sender, EventArgs e)
        {
            //borramos todos los items de todas las listas
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            //quitamos selecciones al combobox
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            //vaciamos textbox
            textBox1.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox5.Text = string.Empty;


        }
        //boton calcular
        private void button1_Click(object sender, EventArgs e)
        {

            /*
            El pago por el servicio de enseñanza
se establece de la siguiente manera:
Existe un pago por matrícula del 80% del costo total (suma de los costos de los cursos escogidos) siempre y cuando
quiera el alumno llevar un solo curso, 60% del costo total si lleva dos cursos y 50% del costo total si lleva 3 o más
cursos. El costo total tiene un descuento del 10% si la forma de pago es al contado y un incremento del 10% si es al
crédito. Existe un pago mensual cuando la forma de pago es al crédito y es equivalente al costo total incrementado
dividido en 4 cuotas.
             */
            double descuento = 0;
            double incremento = 0;
            double pago = 0; // Los valores son tomados del listBox3
            double total = 0;

            // Sumar todos los costos en listBox3 para obtener el costo total
            foreach (var item in listBox3.Items)
            {
                total += Convert.ToDouble(item); // Convertimos a double cada elemento de la lista y lo sumamos
            }

            // Determinar el porcentaje de matrícula según el número de cursos
            int numCursos = listBox3.Items.Count;
            if (numCursos == 1)
            {
                pago = total * 0.80; // 80% si lleva un solo curso
            }
            else if (numCursos == 2)
            {
                pago = total * 0.60; // 60% si lleva dos cursos
            }
            else if (numCursos >= 3)
            {
                pago = total * 0.50; // 50% si lleva tres o más cursos
            }

            // Aplicar descuento o incremento según la forma de pago
            if (comboBox2.SelectedItem.Equals("Contado"))
            {
                // Descuento del 10% si es al contado
                descuento = pago * 0.10;
                pago -= descuento;
            }
            else if (comboBox2.SelectedItem.Equals("Credito"))
            {
                // Incremento del 10% si es al crédito
                incremento = pago * 0.10;
                pago += incremento;

                // Calcular pago mensual si es al crédito, dividiendo el pago en 4 cuotas
                double pagoMensual = pago / 4;
                textBox5.Text = pagoMensual.ToString("0.00"); // Mostramos el pago mensual en textBox5
            }

            // Mostrar el costo total y la matrícula en los textboxes
            textBox3.Text = total.ToString("0.00"); // Mostramos el costo total en textBox3
            textBox4.Text = pago.ToString("0.00");  // Mostramos la matrícula en textBox4
        }
    }
}
