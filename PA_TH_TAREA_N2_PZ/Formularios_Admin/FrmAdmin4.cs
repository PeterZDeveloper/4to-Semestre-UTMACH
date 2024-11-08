using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmAdmin4 : Form
    {

        private TLista<Alumno> TLista;
        public FrmAdmin4()
        {
            InitializeComponent();
            TLista = new TLista<Alumno>();
        }



        //insertar
        private void button4_Click(object sender, EventArgs e)
        {
            Nuevo();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //eliminar
            Eliminar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //modificar
            Modificar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Pedro Zavala");
            this.Close();
        }

        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var resultado = MessageBox.Show("¿Está seguro de eliminarlo?", "Eliminar", MessageBoxButtons.YesNo);
                    if (resultado == DialogResult.Yes)
                    {
                        // Obtén el nombre del alumno de la fila seleccionada
                        string nombreSeleccionado = dataGridView1.CurrentRow.Cells["nombre"].Value?.ToString();

                        if (!string.IsNullOrEmpty(nombreSeleccionado))
                        {
                            // Busca el índice del alumno en la lista original usando el nombre
                            int posicion = TLista<Alumno>.BuscarPorString(a => a.nombre, nombreSeleccionado);

                            if (posicion >= 0)
                            {
                                TLista<Alumno>.Eliminar(posicion);
                                MessageBox.Show("Alumno eliminado.");
                            }
                            else
                            {
                                MessageBox.Show("El alumno no se encontró en la lista.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo obtener el nombre del alumno seleccionado.");
                        }

                        // Refresca el DataGridView después de eliminar
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para eliminar.");
                }
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
                FrmEdit4 frm = new FrmEdit4();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Alumno alu = frm.CrearObjeto();
                    if (alu != null)
                    {
                        TLista<Alumno>.Insertar(alu);
                        MessageBox.Show("Se ha ingresado el curso...");
                    }
                    else
                    {
                        MessageBox.Show("Ingreso cancelado debido a datos incompletos o inválidos.");
                    }
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
                    // Obtén el nombre del alumno de la fila seleccionada
                    string nombreSeleccionado = dataGridView1.CurrentRow.Cells["nombre"].Value?.ToString();

                    if (!string.IsNullOrEmpty(nombreSeleccionado))
                    {
                        // Busca el índice del alumno en la lista original usando el nombre
                        int posicion = TLista<Alumno>.BuscarPorString(a => a.nombre, nombreSeleccionado);

                        if (posicion >= 0)
                        {
                            // Crea y muestra el formulario de edición
                            FrmEdit4 frm = new FrmEdit4();

                            // Obtén el objeto Alumno original y pasa sus datos al formulario de edición
                            Alumno alumnoOriginal = TLista<Alumno>.GetItem(posicion);
                            frm.SetDatos(alumnoOriginal);

                            // Mostrar el formulario de edición
                            frm.ShowDialog();

                            if (frm.DialogResult == DialogResult.OK)
                            {
                                // Crear un objeto Alumno modificado a partir de los datos ingresados en el formulario
                                Alumno alumnoModificado = frm.CrearObjeto();

                                // Actualizar el elemento en la posición correcta de TLista
                                TLista<Alumno>.Modificar(posicion, alumnoModificado);
                                MessageBox.Show("Se ha actualizado el alumno.");
                            }
                            else
                            {
                                MessageBox.Show("Actualización cancelada...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el alumno para actualizar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el nombre del alumno seleccionado.");
                    }

                    // Refresca el DataGridView después de modificar
                    Listar();
                }
                else
                {
                    MessageBox.Show("Seleccione un registro para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar alumno: " + ex.Message);
            }
        }



        private void Listar()
        {
            var listaAlumnos = TLista<Alumno>.Listar()
                .Select(alu => new
                {
                    alu.nombre,
                    alu.nota1,
                    alu.nota2,
                    alu.nota3,
                    alu.promedio,
                    alu.turno,
                }).ToList();

            dataGridView1.DataSource = null; // Limpia el DataSource anterior
            dataGridView1.DataSource = listaAlumnos; // Asigna la nueva lista

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
