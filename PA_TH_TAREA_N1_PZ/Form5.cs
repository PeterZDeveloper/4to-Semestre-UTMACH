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

namespace PA_TH_TAREA_N1_PZ
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //LISTA DE POSTULANTES:
        List<Postulante> listaPostulantes = new List<Postulante>();

        Postulante op;
        string nom;
        double acier;
        double fallo;

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje de copyright personal >:)
            MessageBox.Show("Hecho por Pedro Zavala");
            // Cerrar el formulario.
            this.Close();
        }
        //agregar
        private void button2_Click(object sender, EventArgs e)
        {
             nom = textBox1.Text;
             acier = Convert.ToDouble(textBox2.Text);
             fallo = Convert.ToDouble(textBox3.Text);

            if (acier + fallo > 100)
            {
                MessageBox.Show("La suma de respuestas correctas e incorrectas no debe exceder 100.");
                return;
            }

            double total = (acier * 4.08) + (fallo * -1.04);

            // Crear y agregar el postulante a la lista
            op = new Postulante(nom, acier, fallo, total);
            listaPostulantes.Add(op);

            // Opcional: Mostrar también en los ListBox para confirmar
            listBox1.Items.Add(nom);
            listBox2.Items.Add(acier.ToString());
            listBox3.Items.Add(fallo.ToString());
            listBox4.Items.Add(total.ToString());

            // Limpiar los TextBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado
            if (listBox1.SelectedIndex != -1) // Con que tenga uno, sabemos que están alineados
            {
                int index = listBox1.SelectedIndex; // Obtener el índice de la selección

                // Eliminar en todas las ListBox el índice seleccionado
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
                listBox3.Items.RemoveAt(index);
                listBox4.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.");
            }
        }

        //nuevo
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        //consultar este boton se encargara de mostar el otro formulario con los estudiantes que han aprobado y los que han reprobado
        private void button5_Click(object sender, EventArgs e)
        {
            Form5_5 consultaForm = new Form5_5(listaPostulantes); // Pasar la lista de postulantes
            consultaForm.Show();
        }
    }
}
