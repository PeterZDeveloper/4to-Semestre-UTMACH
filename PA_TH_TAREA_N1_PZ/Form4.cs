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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //agregar
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura de datos de las notas y turno
                string nombre = textBox1.Text;
                double nota1 = Convert.ToDouble(textBox2.Text);
                double nota2 = Convert.ToDouble(textBox3.Text);
                double nota3 = Convert.ToDouble(textBox4.Text);
                string turno = comboBox1.Text;

                // Cálculo del promedio
                double promedio = (nota1 + nota2 + nota3) / 3;

                // Cálculo del promedio como porcentaje
                double promedioPorcentaje = (promedio / 10) * 100;

                // Agregar los datos al DataGridView
                dataGridView1.Rows.Add(nombre, nota1, nota2, nota3, promedio, turno);

                if (promedioPorcentaje >= 70)
                {
                    textBox5.BackColor = Color.LightGreen;
                }
                if (promedioPorcentaje < 70)
                {
                    textBox5.BackColor = Color.LightCoral; 
                }
                // Mostrar el promedio como porcentaje en textBox5
                textBox5.Text = promedioPorcentaje.ToString("0.00") + "%";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar las notas: " + ex.Message);
            }

        }
        //eliminar
        private void button5_Click(object sender, EventArgs e)
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
