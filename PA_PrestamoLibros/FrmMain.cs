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

namespace PA_PrestamoLibros
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            groupBox1.Visible = false;
            TListaBiblioteca.LibrosDisponibles();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //string cedula, string nombre, string apellido, string sexo, DateTime fechaNacimiento, DateTime fechaFinSancion, bool sancionado)

        public void listarEstudiantes()
        {
            var datosTabla = TListaBiblioteca.ListaEstudiantes.Select(es => new
            {
                Cedula = es.Cedula1,
                Nombre = es.Nombre1,
                Apellido = es.Apellido1,
                Sexo = es.Sexo1,
                FechaDeNacimiento = es.FechaNacimiento1,
                Sancionado = es.Sancionado1,
                FinDeLaSancion = es.FechaFinSancion1


            }).ToList();

            dataGridView1.DataSource = datosTabla;

        }
        //(string codigoLibro, string tipo, string categoria, string editorial, string nombreLibro, string autor, int anioPublicacion, bool disponible)
        public void listarLibros()
        {
            var datosTabla = TListaBiblioteca.ListaLibros.Select(l => new
            {
            Codigo = l.CodigoLibro1,
                Tipo = l.Tipo1,
                Categoria = l.Categoria1,
                Editorial = l.Editorial1,
                NombreDelLibro = l.NombreLibro1,
                Autor = l.Autor1,
                Publicacion = l.AnioPublicacion1,
                Disponible = l.Disponible1,



            }).ToList();

            dataGridView1.DataSource = datosTabla;

        }

        public void listarPrestamos()
        {
            var datosTabla = TListaBiblioteca.ListaPrestamos.Select(pre => new
            {
                Cedula = pre.CedulaEstudiante,
                Nombre_Estudiante = pre.NombreEstudiante,
                Codigo = pre.CodigoLibro,
                Libro = pre.NombreLibro,
                FechaDePrestamo = pre.FechaPrestamo,
                FechaDeEntrega = pre.FechaEntrega,
                Devuelto = pre.Devuelto


            }).ToList();

            dataGridView1.DataSource = datosTabla;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //INSERTAR

            FrmEditEstudiantes frm = new FrmEditEstudiantes("INSERTAR");
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                frm.Close();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                frm.Close();
                MessageBox.Show("Ingreso cancelado...");
            }
            listarEstudiantes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEditEstudiantes frm = new FrmEditEstudiantes("MODIFICAR");
            string cedula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Console.Write(cedula);
            Estudiante es = TListaBiblioteca.getEstudiante(TListaBiblioteca.BuscarEstudiante(cedula));
            frm.setdatos(es);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                frm.Close();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                frm.Close();
                MessageBox.Show("Ingreso cancelado...");
            }
            listarEstudiantes();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            listarEstudiantes();

        }

        public void verificarcombo()
        {
            /*
             
Estudiantes
Libros
Prestamos
             */
            String str = comboBox1.SelectedItem.ToString();
            if (str.Equals("Estudiantes"))
            {
                listarEstudiantes();
                groupBox1.Visible = true;


                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;

            }
            else if (str.Equals("Libros"))
            {
                listarLibros();
                groupBox1.Visible = true;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;

            }
            else if (str.Equals("Prestamos"))
            {
                listarPrestamos();
                groupBox1.Visible = false;

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificarcombo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            verificarcombo();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //PRESTAMO
            //       public void setdatos(Estudiante oe, Libro ol)
            FrmPrestamo1 frm = new FrmPrestamo1();
            string cedula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Console.Write(cedula);
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Console.Write(codigo);
            //Estudiante oe = TListaBiblioteca.getEstudiante(TListaBiblioteca.BuscarEstudiante(cedula));
            Libro ol = TListaBiblioteca.getLibro(TListaBiblioteca.BuscarLibro(codigo));

            frm.setdatos(ol);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                frm.Close();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                frm.Close();
                MessageBox.Show("Ingreso cancelado...");
            }
        }
    }
}
