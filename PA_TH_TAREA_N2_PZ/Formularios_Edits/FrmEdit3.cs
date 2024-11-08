using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmEdit3 : Form
    {
        public FrmEdit3()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar listas
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            // Cargar cursos y precios según el tipo seleccionado
            if (comboBox1.SelectedItem.Equals("TI"))
            {
                CargarCursosTI();
            }
            else if (comboBox1.SelectedItem.Equals("Derecho"))
            {
                CargarCursosDerecho();
            }
            else if (comboBox1.SelectedItem.Equals("Medicina"))
            {
                CargarCursosMedicina();
            }
        }

        private int EliminarCursoMedicina(string cursoAEliminar)
        {
            switch (cursoAEliminar)
            {
                case "Gastroenterología":
                    listBox3.Items.Remove(3750);
                    return 3750;
                case "Electrocardiografía":
                    listBox3.Items.Remove(4000);
                    return 4000;
                case "Primeros Auxilios":
                    listBox3.Items.Remove(200);
                    return 200;
                case "Terapia floral":
                    listBox3.Items.Remove(200);
                    return 200;
                case "Neurociencia":
                    listBox3.Items.Remove(5000);
                    return 5000;
                default:
                    return 0;
            }
        }

        private int EliminarCursoTI(string cursoAEliminar)
        {
            switch (cursoAEliminar)
            {
                case "AI Boot Camp":
                    listBox3.Items.Remove(350);
                    return 350;
                case "Curso de programación":
                    listBox3.Items.Remove(1000);
                    return 1000;
                case "Curso de algoritmos":
                    listBox3.Items.Remove(150);
                    return 150;
                case "Curso de Power BI":
                    listBox3.Items.Remove(150);
                    return 150;
                case "Curso de Scrum":
                    listBox3.Items.Remove(250);
                    return 250;
                default:
                    return 0;
            }
        }

        private int EliminarCursoDerecho(string cursoAEliminar)
        {
            switch (cursoAEliminar)
            {
                case "Criminologia":
                    listBox3.Items.Remove(750);
                    return 750;
                case "Derecho femenino":
                    listBox3.Items.Remove(100);
                    return 100;
                case "Copyright":
                    listBox3.Items.Remove(400);
                    return 400;
                case "Derecho Penal":
                    listBox3.Items.Remove(500);
                    return 500;
                case "Politicas Publicas":
                    listBox3.Items.Remove(100);
                    return 100;
                default:
                    return 0;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private int AgregarCursoTI(string cursoSeleccionado)
        {
            switch (cursoSeleccionado)
            {
                case "AI Boot Camp":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(350);
                    return 350;
                case "Curso de programación":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(1000);
                    return 1000;
                case "Curso de algoritmos":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(150);
                    return 150;
                case "Curso de Power BI":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(150);
                    return 150;
                case "Curso de Scrum":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(250);
                    return 250;
                default:
                    return 0;
            }
        }

        private int AgregarCursoDerecho(string cursoSeleccionado)
        {
            switch (cursoSeleccionado)
            {
                case "Criminologia":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(750);
                    return 750;
                case "Derecho femenino":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(100);
                    return 100;
                case "Copyright":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(400);
                    return 400;
                case "Derecho Penal":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(500);
                    return 500;
                case "Politicas Publicas":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(100);
                    return 100;
                default:
                    return 0;
            }
        }

        private int AgregarCursoMedicina(string cursoSeleccionado)
        {
            switch (cursoSeleccionado)
            {
                case "Gastroenterología":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(3750);
                    return 3750;
                case "Electrocardiografía":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(4000);
                    return 4000;
                case "Primeros Auxilios":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(200);
                    return 200;
                case "Terapia floral":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(200);
                    return 200;
                case "Neurociencia":
                    listBox4.Items.Add(cursoSeleccionado);
                    listBox2.Items.Remove(5000);
                    return 5000;
                default:
                    return 0;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso a eliminar.");
                return;
            }

            string cursoAEliminar = listBox4.SelectedItem.ToString();
            string tipoCurso = comboBox1.SelectedItem.ToString();
            int costo = 0;

            // Determinar costo según tipo de curso y agregar a las listas correspondientes
            if (tipoCurso == "TI")
            {
                costo = EliminarCursoTI(cursoAEliminar);
            }
            else if (tipoCurso == "Derecho")
            {
                costo = EliminarCursoDerecho(cursoAEliminar);
            }
            else if (tipoCurso == "Medicina")
            {
                costo = EliminarCursoMedicina(cursoAEliminar);
            }

            // Agregar costo a listBox1 y remover de listBox4
            if (costo > 0)
            {
                listBox1.Items.Add(cursoAEliminar);
                listBox2.Items.Add(costo);
                listBox4.Items.Remove(listBox4.SelectedItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso y un tipo de curso.");
                return;
            }

            string cursoSeleccionado = listBox1.SelectedItem.ToString();
            string tipoCurso = comboBox1.SelectedItem.ToString();
            int costo = 0;

            // Determinar costo según tipo de curso y agregar a las listas correspondientes
            if (tipoCurso == "TI")
            {
                costo = AgregarCursoTI(cursoSeleccionado);
            }
            else if (tipoCurso == "Derecho")
            {
                costo = AgregarCursoDerecho(cursoSeleccionado);
            }
            else if (tipoCurso == "Medicina")
            {
                costo = AgregarCursoMedicina(cursoSeleccionado);
            }

            // Agregar costo a listBox3 y remover de listBox1
            if (costo > 0)
            {
                listBox3.Items.Add(costo);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide  ();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Método para establecer los datos del curso
        public void SetDatos(Cursos curso)
        {
            //nombre de alumon textbox1
            //public Cursos(string nombre, string tipo, double nCursos, string fpago,
            //double descuento, double incremento, double subTotal, double total)
         
            textBox1.Text = curso.Nombre;
            comboBox1.Text = curso.Tipo.ToString();
            //ncursos = al numero de cursos seleccionados
            comboBox2.Text = curso.Fpago.ToString();
            textBox3.Text = curso.SubTotal.ToString("F2");


        }

        // Método para crear el objeto curso
        // Método para crear el objeto curso
        public Cursos CrearObjeto()
        {
            string nombre = textBox1.Text;
            int numCursos = listBox3.Items.Count; // Cantidad de cursos seleccionados
            string tipo = comboBox1.SelectedItem.ToString();
            string formaPago = comboBox2.SelectedItem.ToString();

            // Valores ya calculados y mostrados en los textboxes después de llamar a CalcularTotales
            double subtotal = ValidarDouble(textBox3.Text);
            double total = ValidarDouble(textBox4.Text);

            return new Cursos(nombre, tipo, numCursos, formaPago, subtotal, total);
        }

        private double ValidarDouble(string texto)
        {
            return double.TryParse(texto, out double resultado) ? resultado : 0;
        }

        private void CalcularTotales()
        {
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
            }

            // Mostrar el costo total y la matrícula en los textboxes
            textBox3.Text = total.ToString("0.00"); // Mostramos el costo total en textBox3
            textBox4.Text = pago.ToString("0.00");  // Mostramos la matrícula en textBox4
        }


        //GUARDAR

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularTotales();
            this.DialogResult = DialogResult.OK; // Marca el diálogo como exitoso
            this.Close(); // Cierra el formulario
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void CargarCursosTI()
        {
            listBox1.Items.AddRange(new object[] {
        "AI Boot Camp", "Curso de programación", "Curso de algoritmos", "Curso de Power BI", "Curso de Scrum"
    });
            listBox2.Items.AddRange(new object[] { 350, 1000, 150, 150, 250 });
        }

        private void CargarCursosDerecho()
        {
            listBox1.Items.AddRange(new object[] {
        "Criminologia", "Derecho femenino", "Copyright", "Derecho Penal", "Politicas Publicas"
    });
            listBox2.Items.AddRange(new object[] { 750, 100, 400, 500, 100 });
        }

        private void CargarCursosMedicina()
        {
            listBox1.Items.AddRange(new object[] {
        "Gastroenterología", "Electrocardiografía", "Primeros Auxilios", "Terapia floral", "Neurociencia"
    });
            listBox2.Items.AddRange(new object[] { 3750, 4000, 200, 200, 5000 });
        }

        private void FrmEdit3_Load(object sender, EventArgs e)
        {

        }
    }


}

