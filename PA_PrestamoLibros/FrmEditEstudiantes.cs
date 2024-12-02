using PA_PrestamoLibros.Controlador;
using PA_PrestamoLibros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PA_PrestamoLibros
{
    public partial class FrmEditEstudiantes : Form
    {
        public FrmEditEstudiantes(String funcion)
        {
            InitializeComponent();
            label7.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox1.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) {
                label7.Visible = true;
                dateTimePicker2.Visible = true;

            }
            if (!checkBox1.Checked)
            {
                label7.Visible = false;
                dateTimePicker2.Visible = false;

            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//CERRAR
            this.Close();
        }
        //public Estudiante(string cedula, string nombre, string apellido, char sexo, DateTime fechaNacimiento, DateTime fechaFinSancion, bool sancionado, string cedula1, string nombre1, string apellido1, char sexo1, DateTime fechaNacimiento1, DateTime fechaFinSancion1, bool sancionado1)

        public void setdatos(Estudiante oe)
        {
            textBox1.Text = (oe.Cedula1).ToString();
            textBox2.Text = (oe.Nombre1).ToString();
            textBox3.Text = (oe.Apellido1).ToString();
            comboBox1.SelectedItem = oe.Sexo1.ToString();
            dateTimePicker1.Value = oe.FechaNacimiento1;
            checkBox1.Checked = oe.Sancionado1;
            oe.FechaFinSancion1 = DateTime.MinValue;
            if (checkBox1.Checked)
            {
                oe.FechaFinSancion1 = dateTimePicker2.Value;
            }
        }

        //(string cedula, string nombre, string apellido, string sexo, DateTime fechaNacimiento, DateTime fechaFinSancion, bool sancionado)

        private void button1_Click(object sender, EventArgs e)
        {//AGREGAR
            string ced = textBox1.Text.ToString();
            string nom = textBox2.Text.ToString();
            string ape = textBox3.Text.ToString();
            string sex = comboBox1.SelectedItem.ToString();
            DateTime fNaci = dateTimePicker1.Value;
            bool sancion = checkBox1.Checked;
            DateTime fsancionado = DateTime.MinValue;
            if (checkBox1.Checked) {
                fsancionado = dateTimePicker2.Value;
                
            }


            Estudiante es = new Estudiante(ced,nom,ape,sex,fNaci,fsancionado,sancion);
            TListaBiblioteca.AgregarEstudiante(es);
            DialogResult = DialogResult.OK;
        }
    }
}
