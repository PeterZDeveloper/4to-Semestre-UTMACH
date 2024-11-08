using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmEdit4 : Form
    {
        public FrmEdit4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cancelar
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //guardar
            CalcularTotales();
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cerrar el formulario después de guardar
        }

        public void SetDatos(Alumno alu)
        {
            textBox1.Text = alu.nombre;
            textBox2.Text = alu.nota1.ToString("F2");
            textBox3.Text = alu.nota2.ToString("F2");
            textBox4.Text = alu.nota3.ToString("F2");
            comboBox1.Text = alu.turno.ToString();
    
        }

        public Alumno CrearObjeto()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un turno.");
                return null;
            }

            string nom = textBox1.Text;
            double n1 = ValidarDouble(textBox2.Text);
            double n2 = ValidarDouble(textBox3.Text);
            double n3 = ValidarDouble(textBox4.Text);
            double prom = (n1 + n2 + n3) / 3;
            string turn = comboBox1.SelectedItem.ToString();

            return new Alumno(nom, n1, n2, n3, prom, turn);
        }



        private double ValidarDouble(string texto)
        {
            return double.TryParse(texto, out double resultado) ? resultado : 0;
        }

        private void CalcularTotales()
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
