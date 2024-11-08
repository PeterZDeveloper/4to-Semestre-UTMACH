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

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmAdmin5 : Form
    {
        public FrmAdmin5()
        {
            InitializeComponent();
        }

        //LISTA DE POSTULANTES:
        List<Postulantes> listaPostulantes = new List<Postulantes>();

        Postulantes op;
        string nom;
        double acier;
        double fallo;


        //consultar
        private void button5_Click(object sender, EventArgs e)
        {
            FrmEdit5 consultaForm = new FrmEdit5(listaPostulantes); // Pasar la lista de postulantes
            consultaForm.Show();
        }
        //eliminar
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
        //Modificar
        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si hay un elemento seleccionado en el listBox1
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex; // Obtiene el índice del elemento seleccionado

                // Si los TextBox están vacíos, es la primera vez que se hace clic en Modificar
                if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox3.Text))
                {
                    // Carga los datos del elemento seleccionado en los TextBox
                    textBox1.Text = listBox1.Items[index].ToString(); // Nombre
                    textBox2.Text = listBox2.Items[index].ToString(); // Respuestas correctas
                    textBox3.Text = listBox3.Items[index].ToString(); // Respuestas incorrectas
                }
                else
                {
                    // Asigna los nuevos valores desde los TextBox
                    nom = textBox1.Text;
                    acier = Convert.ToDouble(textBox2.Text);
                    fallo = Convert.ToDouble(textBox3.Text);

                    // Verifica que la suma de respuestas no exceda el límite
                    if (acier + fallo > 100)
                    {
                        MessageBox.Show("La suma de respuestas correctas e incorrectas no debe exceder 100.");
                        return;
                    }

                    // Calcula el nuevo total
                    double total = (acier * 4.08) + (fallo * -1.04);

                    // Actualiza el elemento en la lista principal
                    listaPostulantes[index] = new Postulantes(nom, acier, fallo, total);

                    // Actualiza los ListBox con los nuevos datos
                    listBox1.Items[index] = nom;
                    listBox2.Items[index] = acier.ToString();
                    listBox3.Items[index] = fallo.ToString();
                    listBox4.Items[index] = total.ToString();

                    MessageBox.Show("Postulante modificado exitosamente.");

                    // Limpia los TextBox para la siguiente operación
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un postulante para modificar.");
            }
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
            op = new Postulantes(nom, acier, fallo, total);
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
        //cerrar
        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje de copyright personal >:)
            MessageBox.Show("Hecho por Pedro Zavala");
            // Cerrar el formulario.
            this.Close();
        }
    }
}
