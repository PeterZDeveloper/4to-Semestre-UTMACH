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

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmAdmin6 : Form
    {
        private TLista<Pelicula> TLista;

        public FrmAdmin6()
        {
            InitializeComponent();
            TLista = new TLista<Pelicula>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Pedro Zavala");
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modificar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //insertar
            Nuevo();
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
                        Pelicula peli = dataGridView1.CurrentRow.DataBoundItem as Pelicula;

                        // Buscar la posición del elemento en la lista por su Código
                        int posicion = TLista<Pelicula>.BuscarPorString(p => p.Titulo, peli.Titulo);

                        if (posicion != -1) // Si el elemento existe
                        {
                            TLista<Pelicula>.Eliminar(posicion);
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
                FrmEdit6 frm = new FrmEdit6();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Pelicula peli = frm.CrearObjeto();
                    if (peli != null)  // Verificar que el objeto no sea nulo
                    {
                        TLista<Pelicula>.Insertar(peli);
                        MessageBox.Show("Se ha ingresado una pelicula...");
                        Listar(); // Actualizar DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Ingreso cancelado...");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la pelicula: " + ex.Message);
            }
        }



        public void Modificar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    FrmEdit6 frm = new FrmEdit6();
                    Pelicula   oax = dataGridView1.CurrentRow.DataBoundItem as Pelicula;
                    frm.SetDatos(oax);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Pelicula objP = frm.CrearObjeto();
                        int posicion = TLista<Pelicula>.BuscarPorString(p => p.Titulo, objP.Titulo);

                        if (posicion != -1)
                        {
                            TLista<Pelicula>.Modificar(posicion, objP);
                            MessageBox.Show("Se ha actualizado el electrónico...");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo encontrar el electrónico para actualizar.");
                        }

                        frm.Close();
                    }
                    else
                    {
                        frm.Close();
                        MessageBox.Show("Actualización cancelada...");
                    }
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar electrónico: " + ex.Message);
            }
        }

        public void Listar()
        {
            dataGridView1.DataSource = null; // Limpiar la fuente de datos
            dataGridView1.DataSource = TLista<Pelicula>.Lista.ToList();  // Calificación estática corregida
        }

    }
}
