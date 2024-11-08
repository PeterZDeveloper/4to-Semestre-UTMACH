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
    public partial class FrmAdmin1 : Form
    {

        private TLista<Electronico> TLista;

        public FrmAdmin1()
        {
            InitializeComponent();
            TLista = new TLista<Electronico>();
            AjustarColumnasDataGridView();

        }

        private void AjustarColumnasDataGridView()
        {
            // Recorre cada columna en el DataGridView y ajusta su tamaño
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void FrmAdmin1_Load(object sender, EventArgs e)
        {
            Listar();
        }
        //Electronico elec
        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("¿Está seguro de eliminarlo?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        Electronico elec = dataGridView1.CurrentRow.DataBoundItem as Electronico;

                        // Buscar la posición del elemento en la lista por su Código
                        int posicion = TLista<Electronico>.BuscarPorString(e => e.Codigo, elec.Codigo);

                        if (posicion != -1) // Si el elemento existe
                        {
                            TLista<Electronico>.Eliminar(posicion);
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
                FrmEdit1 frm = new FrmEdit1();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Electronico elec = frm.CrearObjeto();
                    TLista<Electronico>.Insertar(elec);  // Calificación estática corregida
                    frm.Close();
                    MessageBox.Show("Se ha ingresado el electrónico...");
                }
                else
                {
                    frm.Close();
                    MessageBox.Show("Ingreso cancelado...");
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar electrónico: " + ex.Message);
            }
        }


        public void Modificar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    FrmEdit1 frm = new FrmEdit1();
                    Electronico oax = dataGridView1.CurrentRow.DataBoundItem as Electronico;
                    frm.SetDatos(oax);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Electronico objE = frm.CrearObjeto();
                        int posicion = TLista<Electronico>.BuscarPorString(e => e.Codigo, objE.Codigo);

                        if (posicion != -1)
                        {
                            TLista<Electronico>.Modificar(posicion, objE);
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
            dataGridView1.DataSource = TLista<Electronico>.Lista.ToList();  // Calificación estática corregida
        }

        //insertar
        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        //eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar();

        }
        //modificar

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        //CERRAR
        private void button4_Click(object sender, EventArgs e)
        {
            // Mostrar el mensaje de copyright personal >:)
            MessageBox.Show("Hecho por Pedro Zavala");
            // Cerrar el formulario.
            this.Close();
        }
    }
}
