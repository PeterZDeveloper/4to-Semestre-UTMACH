using P_A_ClasesAbstractas_Nomina.Controlador;
using P_A_ClasesAbstractas_Nomina.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_A_ClasesAbstractas_Nomina.Formularios
{
    public partial class FrmAdmin1 : Form
    {

        private TLista<Persona> listaPersonas;

        public FrmAdmin1()
        {
            InitializeComponent();
            listaPersonas = new TLista<Persona>();

        }
        //cerrar
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //modificar
            Modificar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            Nuevo();
        }

        public void Eliminar()
        {
            if (dataGridView1.CurrentRow != null)
            {
                string cedulaSeleccionada = dataGridView1.CurrentRow.Cells["Cedula"].Value?.ToString();
                int indice = TLista<Persona>.Buscar(p => p.Cedula == cedulaSeleccionada);

                if (indice >= 0)
                {
                    TLista<Persona>.Eliminar(indice);
                    MessageBox.Show("Persona eliminada.");
                    Listar(); // Llamar al método Listar() para refrescar el DataGridView
                }
                else
                {
                    MessageBox.Show("Persona no encontrada.");
                }
            }
        }


        public void Nuevo()
        {
            FrmEdit1 frm = new FrmEdit1();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Persona nuevaPersona = frm.CrearObjeto(); // Este método debería retornar una instancia de `Persona` o una de sus subclases
                if (nuevaPersona != null)
                {
                    TLista<Persona>.Insertar(nuevaPersona);
                    MessageBox.Show("Se ha ingresado la persona...");
                }
                else
                {
                    MessageBox.Show("Ingreso cancelado debido a datos incompletos o inválidos.");
                }
            }
            Listar();
        }




        public void Modificar()
        {
            if (dataGridView1.CurrentRow != null)
            {
                string cedulaSeleccionada = dataGridView1.CurrentRow.Cells["Cedula"].Value?.ToString();
                int indice = TLista<Persona>.Buscar(p => p.Cedula == cedulaSeleccionada);

                if (indice >= 0)
                {
                    FrmEdit1 frm = new FrmEdit1();
                    frm.SetDatos(TLista<Persona>.GetItem(indice)); // Pasa la persona al formulario de edición
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Persona personaModificada = frm.CrearObjeto();
                        TLista<Persona>.Modificar(indice, personaModificada);
                        MessageBox.Show("Se ha actualizado la persona.");
                        Listar();
                    }
                }
                else
                {
                    MessageBox.Show("Persona no encontrada.");
                }
            }
        }


        private bool EsCumpleañosEsteMes(Persona persona)
        {
            DateTime fechaActual = DateTime.Today;

            // Comprobamos si el mes y día de nacimiento coinciden con el día de hoy.
            if (persona.FechaNacimiento.Month == fechaActual.Month && persona.FechaNacimiento.Day == fechaActual.Day)
            {
                // Si es su cumpleaños, mostramos el mensaje.
                MessageBox.Show("¡Feliz cumpleaños! Disfruta tus 100 USD adicionales.");
                return true;
            }

            // Si no es su cumpleaños, devolvemos false.
            return false;
        }



        private void Listar()
        {
            var listaVisualizacion = TLista<Persona>.Listar().Select(p => new
            {
                Cedula = p.Cedula,
                Nombres = p.Nombres,
                Apellidos = p.Apellidos,
                FechaNacimiento = p.FechaNacimiento.ToShortDateString(),
                Edad = p.Edad(),
                Sexo = p.Sexo,
                Estado = p.Estado,
                Tipo = p.Tipo,
                Ciudad = p.Ciudad,
                SueldoBase = p.CalcularSueldo(),
                Bono_Cumpleaños = EsCumpleañosEsteMes(p) ? 100 : 0,
                Bono_Antiguedad = p.BonificacionAntiguedad(),
                SueldoTotal = p.CalcularSueldo() + (EsCumpleañosEsteMes(p) ? 100 : 0) + p.BonificacionAntiguedad()
            }).ToList();

            // Verificar si la lista tiene elementos
            if (listaVisualizacion.Any())
            {
                // Actualizar el DataSource del DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaVisualizacion;

                // Cambiar la visibilidad de las columnas según el tipo de empleado
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    col.Visible = false;
                }

                foreach (var columnName in from columna in listaVisualizacion.First().GetType().GetProperties()
                                           let columnName = columna.Name
                                           select columnName)
                {
                    dataGridView1.Columns[columnName].Visible = true;
                }
            }
            else
            {
                // Si la lista está vacía, mostrar un mensaje
                MessageBox.Show("No hay empleados para mostrar.");
                dataGridView1.DataSource = null; // Limpiar el DataGridView si la lista está vacía
            }
        }


        //imprimir uno
        private void button5_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridView1.CurrentRow != null)
            {
                // Obtener la cédula de la persona seleccionada
                string cedulaSeleccionada = dataGridView1.CurrentRow.Cells["Cedula"].Value?.ToString();
                int indice = TLista<Persona>.Buscar(p => p.Cedula == cedulaSeleccionada);

                if (indice >= 0)
                {
                    Persona personaSeleccionada = TLista<Persona>.GetItem(indice);
                    // Llamar al método Imprimir de la persona
                    personaSeleccionada.Imprimir();
                }
                else
                {
                    MessageBox.Show("Persona no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para imprimir.");
            }
        }

    }
}
