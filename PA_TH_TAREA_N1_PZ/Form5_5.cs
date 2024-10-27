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
    public partial class Form5_5 : Form
    {
        public Form5_5(List<Postulante> listaPostulantes)
        {
            InitializeComponent();
            CargarDatos(listaPostulantes); // Llama al método CargarDatos para llenar el DataGridView
        }

        private void CargarDatos(List<Postulante> listaPostulantes)//List ya viene por defecto con sus metodos
        {
            // Configurar el DataGridView para ajustar columnas automáticamente
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //como no creamos filas de antemanos debemos poner el .fill para que esten bien las celdas.
            // Cargar los datos en el DataGridView
            dataGridView1.DataSource = listaPostulantes.Select(op => new
            {//En diseño no hay filas colocadas de antemano, estas se colocan con cada consulta que hagas
                Nombre = op.Nombre,
                Aciertos = op.Aciertos,
                Fallos = op.Fallos,
                Puntaje = op.Puntaje,
                Estado = op.Puntaje >= 0 ? "Aprobado" : "Reprobado" //comparativa para determinar si esta aprobado o no

            }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //boton cerrar, este cierra el 5_5 pero no cierra el 5
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //boton resaltar
        private void button2_Click(object sender, EventArgs e)
        {
            ResaltarFilas();
        }

         void ResaltarFilas()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)//usaste el foreach para recorrer todas las filas
            {
                // Obtén el valor de la columna "Estado" para cada fila
                string estado = row.Cells["Estado"].Value.ToString();

                // Cambia el color de la fila según el estado
                if (estado == "Aprobado")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (estado == "Reprobado")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }



        }
}
}