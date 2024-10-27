//PZ
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_TH_TAREA_N1_PZ
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje de copyright personal >:)
            MessageBox.Show("Hecho por Pedro Zavala");
            // Cerrar el formulario.
            this.Close();
        }
        //nuevo
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty; //pelicula
            textBox2.Text = string.Empty; //duracion
            textBox3.Text = string.Empty; //actor principal
            radioButton1.Checked = false; //comedia
            radioButton2.Checked = false; //dibujos animados
            radioButton3.Checked = false; //accion
            radioButton5.Checked = false; //drama

        }
        //Agregar
        private void button2_Click(object sender, EventArgs e)
        {
            string peli = textBox1.Text.ToString();
            string dura = textBox2.Text.ToString();
            string acto = textBox3.Text.ToString();
            string tipo = "";
            if (radioButton1.Checked) //comedia
            {
                tipo = "Comedia";
                dataGridView1.Rows.Add(peli, tipo, acto, dura); //añadimos una fila con los datos

            }
            if (radioButton2.Checked)
            {
                tipo = "Dibujos Animados";
                dataGridView1.Rows.Add(peli, tipo, acto, dura);
            }
            if (radioButton3.Checked)
            {
                tipo = "Accion";
                dataGridView1.Rows.Add(peli, tipo, acto, dura);

            }
            if (radioButton5.Checked)
            {
                tipo = "Drama";
                dataGridView1.Rows.Add(peli, tipo, acto, dura);
            //En caso que no se seleccione nada salga un error.
            }
            if (!radioButton5.Checked && !radioButton3.Checked && !radioButton2.Checked && !radioButton1.Checked)
            {//NOTA: Este condicional funciona
                MessageBox.Show("Por favor, selecciona una categoria de pelicula.");
            }

        }
        //eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada 
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            { 
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
    }
}
