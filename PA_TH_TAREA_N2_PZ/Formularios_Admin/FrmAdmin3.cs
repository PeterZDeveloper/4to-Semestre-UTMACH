using System;
using System.Linq;
using System.Windows.Forms;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmAdmin3 : Form
    {
        private TLista<Cursos> TLista; // Lista para manejar los cursos

        public FrmAdmin3()
        {
            InitializeComponent();
            TLista = new TLista<Cursos>(); // Inicializa la lista de cursos
        }

        // Cerrar
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Pedro Zavala");
            this.Close();
        }

        // Insertar
        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        // Modificar
        private void button2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        // Eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void FrmAdmin3_Load(object sender, EventArgs e)
        {
            Listar(); // Llama al método Listar al cargar el formulario
        }



        public void Nuevo()
        {
            try
            {
                FrmEdit3 frm = new FrmEdit3(); 
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Cursos curso = frm.CrearObjeto(); // Llama al método para crear el objeto usando el último constructor
                    TLista<Cursos>.Insertar(curso); // Inserta el curso en la lista
                    MessageBox.Show("Se ha ingresado el curso...");
                }
                else
                {
                    MessageBox.Show("Ingreso cancelado...");
                }
                Listar(); // Actualiza la lista
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar curso: " + ex.Message);
            }
        }

        public void Modificar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Crear y mostrar el formulario de edición
                    FrmEdit3 frm = new FrmEdit3();

                    // Obtener el curso seleccionado en el DataGridView
                    Cursos cursoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Cursos;
                    frm.SetDatos(cursoSeleccionado);  // Cargar los datos en el formulario

                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        // Crear el nuevo objeto Cursos modificado
                        Cursos cursoModificado = frm.CrearObjeto();

                        // Buscar la posición del curso original usando el nombre
                        int posicion = TLista<Cursos>.BuscarPorString(c => c.Nombre, cursoSeleccionado.Nombre);

                        if (posicion != -1)
                        {
                            // Actualizar el curso en la lista
                            TLista<Cursos>.Modificar(posicion, cursoModificado);
                            MessageBox.Show("Se ha actualizado el curso.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el curso para actualizar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Actualización cancelada...");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un curso para modificar.");
                }

                // Actualiza la lista en el DataGridView
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar curso: " + ex.Message);
            }
        }

        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("¿Está seguro de eliminar este curso?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        // Obtener el curso seleccionado en el DataGridView
                        Cursos cursoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Cursos;

                        // Buscar la posición del curso en la lista usando el nombre
                        int posicion = TLista<Cursos>.BuscarPorString(c => c.Nombre, cursoSeleccionado.Nombre);

                        if (posicion != -1) // Si el curso existe en la lista
                        {
                            TLista<Cursos>.Eliminar(posicion);
                            MessageBox.Show("Curso eliminado.");
                        }
                        else
                        {
                            MessageBox.Show("El curso no se encontró en la lista.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un curso para eliminar.");
                }

                // Actualiza la lista en el DataGridView
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }


        private void Listar()
        {
            var listaCursos = TLista<Cursos>.Listar()
                .Select(curso => new
                {

                    curso.Nombre,
                    curso.Tipo,
                    curso.NCursos,
                    curso.Fpago,
                    curso.SubTotal,
                    curso.Total
                }).ToList();

            dataGridView1.DataSource = listaCursos;

        }
    }
}
