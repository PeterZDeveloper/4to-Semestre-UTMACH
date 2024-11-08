using System;
using System.Windows.Forms;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmAdmin2 : Form
    {
        private TLista<Cursos> TLista;

        public FrmAdmin2()
        {
            InitializeComponent();
            TLista = new TLista<Cursos>();
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

        // Cerrar
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Pedro Zavala");
            this.Close();
        }

        private void FrmAdmin2_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("¿Está seguro de eliminarlo?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Cursos cur = dataGridView1.CurrentRow.DataBoundItem as Cursos;

                        // Buscar la posición del elemento en la lista por su Nombre
                        int posicion = TLista<Cursos>.BuscarPorString(c => c.Nombre, cur.Nombre);

                        if (posicion != -1) // Si el elemento existe
                        {
                            TLista<Cursos>.Eliminar(posicion);
                            MessageBox.Show("Curso eliminado.");
                        }
                        else
                        {
                            MessageBox.Show("El elemento no se encontró en la lista.");
                        }
                    }
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        public void Nuevo()
        {
            try
            {
                FrmEdit2 frm = new FrmEdit2();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Cursos cur = frm.CrearObjeto();
                    TLista<Cursos>.Insertar(cur);
                    MessageBox.Show("Se ha ingresado el curso...");
                }
                else
                {
                    MessageBox.Show("Ingreso cancelado...");
                }
                Listar();
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
                    FrmEdit2 frm = new FrmEdit2();
                    Cursos oax = dataGridView1.CurrentRow.DataBoundItem as Cursos;
                    frm.SetDatos(oax);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Cursos objC = frm.CrearObjeto();
                        int posicion = TLista<Cursos>.BuscarPorString(c => c.Nombre, objC.Nombre);

                        if (posicion != -1)
                        {
                            TLista<Cursos>.Modificar(posicion, objC);
                            MessageBox.Show("Se ha actualizado el curso...");
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
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar curso: " + ex.Message);
            }
        }

        private void Listar()
        {
            var listaCursos = TLista<Cursos>.Listar(); // Obtén la lista de cursos

            // Aquí deberías implementar la lógica para incluir el subtotal
            foreach (var curso in listaCursos)
            {
            }

            dataGridView1.DataSource = null; // Limpiar la fuente de datos
            dataGridView1.DataSource = listaCursos; // Asignar la lista actualizada
        }

    }
}
