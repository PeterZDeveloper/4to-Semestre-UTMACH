using PA_PrestamoLibros.Controlador;
using PA_PrestamoLibros.Entidades;
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

namespace PA_PrestamoLibros
{
    public partial class FrmPrestamo1 : Form
    {
        public FrmPrestamo1()
        {
            InitializeComponent();
            TListaBiblioteca.rellenarcomboboxCedula(comboBox1);
            TListaBiblioteca.rellenarcomboboxCLibros(comboBox2);
        }

        public void setdatos(Libro ol)
        {
            comboBox2.SelectedItem = (ol.CodigoLibro1).ToString();
            textBox2.Text = ol.NombreLibro1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            string ced = comboBox1.SelectedItem.ToString();
            string nom = textBox1.Text;
            string cod = comboBox2.SelectedItem.ToString();
            string lib = textBox2.Text;
            DateTime fprestamo = dateTimePicker1.Value;
            DateTime fentrega = dateTimePicker2.Value;
            bool entregado = checkBox1.Checked;

           // Estudiante estu = TListaBiblioteca.getEstudiante(TListaBiblioteca.BuscarEstudiante(ced));
          //  Libro libro = TListaBiblioteca.getLibro(TListaBiblioteca.BuscarLibro(cod));

            Prestamo prest = new Prestamo(ced,nom,cod,lib, fprestamo, fentrega, entregado);
            TListaBiblioteca.AgregarPrestamo(prest);
            DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ced = comboBox1.SelectedItem.ToString();

            //COMBO BOX ESTUDIANTES
            textBox1.Text = TListaBiblioteca.ObtenerNombreEstudiantePorCedula(ced);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //COMBO BOX LIBROS
            string cod = comboBox2.SelectedItem.ToString();
            textBox2.Text = TListaBiblioteca.ObtenerNombreLibroPorCodigo(cod);


        }
    }
}
