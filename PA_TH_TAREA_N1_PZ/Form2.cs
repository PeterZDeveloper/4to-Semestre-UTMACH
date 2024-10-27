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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //boton cerrar
        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje de copyright personal >:)
            MessageBox.Show("Hecho por Pedro Zavala");
            // Cerrar el formulario.
            this.Close();
        }
        //boton calcular
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             El pago por los cursos seleccionados podrá ser pagado al contado o al crédito. Si el pago es al
contado hay un descuento del 5% del costo total de los cursos a llevar y si el pago es al crédito se pagará un
incremento del 7% del costo total. La aplicación debe mostrar el descuento, el incremento y el monto a pagar por
los seleccionados. 
             */

            //recibe valores de la suma de cada curso seleccionado por el usuario, los valores estan en listbox3 para ser añadidos.
            double pago = 0; 

            foreach (var item in listBox3.Items)
            {
                pago += Convert.ToDouble(item);
            }

            double descuento = 0;
            double incremento = 0;
            double total = pago; // Total inicial es el pago base

            //radioButton2 = credito
            if (radioButton2.Checked)
            {
                incremento = pago * 0.07; // 7% de incremento
                total = pago + incremento; // Total con incremento
                textBox3.Text = incremento.ToString("F2"); // Mostrar incremento en textBox3
            }

            //radioButton1 = contado
            if (radioButton1.Checked)
            {
                descuento = pago * 0.05; // 5% de descuento
                total = pago - descuento; // Total con descuento
                textBox4.Text = descuento.ToString("F2"); // Mostrar descuento en textBox4
            }

            //salida:
            textBox5.Text = total.ToString("F2"); //pago total
        }

        //boton reiniciar.
        private void button2_Click(object sender, EventArgs e)
        {
            //borramos todos los items de todas las listas
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            //volvemos a introducir los cursos y sus precios
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
        //agregar
        private void button4_Click(object sender, EventArgs e)
        {
            /*
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
             */
            string CursoSeleccionado = listBox1.SelectedItem.ToString();
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

        //eliminar
        private void button5_Click(object sender, EventArgs e)
        {
            string CursoAEliminar = listBox4.SelectedItem.ToString();
            switch (CursoAEliminar)
            {
                case "AI Boot Camp":
                    listBox1.Items.Add("AI Boot Camp");
                    listBox3.Items.Remove(350);
                    listBox2.Items.Add(350);
                    break;
                case "Curso de programación":
                    listBox1.Items.Add("Curso de programación");
                    listBox3.Items.Remove(1000);

                    listBox2.Items.Add(1000);

                    break;
                case "Curso de algoritmos":
                    listBox1.Items.Add("Curso de algoritmos");
                    listBox3.Items.Remove(150);
                    listBox2.Items.Add(150);

                    break;
                case "Curso de Power BI":
                    listBox1.Items.Add("Curso de Power BI");
                    listBox3.Items.Remove(150);
                    listBox2.Items.Add(150);

                    break;
                case "Curso de Scrum":
                    listBox1.Items.Add("Curso de Scrum");
                    listBox3.Items.Remove(250);
                    listBox2.Items.Add(250);

                    break;
            }
            listBox4.Items.Remove(listBox4.SelectedItem); // Remover el elemento seleccionado de la listBox1
        }
    

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
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
    }
}
