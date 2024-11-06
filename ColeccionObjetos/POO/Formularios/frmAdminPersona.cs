using POO.Controlador;
using POO.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO.Formularios
{
    public partial class frmAdminPersona : Form
    {
        public frmAdminPersona()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            TLista.Lista.Add(new Persona("070345578", "Bruno", "Diaz", new DateTime(1980, 12, 01), 'M', "Soltero", "ORH+", "Machala")); 
            TLista.Lista.Add(new Persona("070345579", "Nerea", "Castro", new DateTime(2004, 12, 01), 'F', "Soltero", "A-", "Machala"));
            TLista.Lista.Add(new Persona("070345580", "Juan", "Minuche", new DateTime(2005, 10, 10), 'M', "Casado", "A-", "Guayaquil"));
            TLista.Lista.Add(new Persona("070345581", "Paulete", "Brito", new DateTime(2006, 05, 05), 'F', "Soltero", "A-", "Machala"));

        }
        public void Listar()
        {
            dataGridView1.DataSource = TLista.Lista.ToList();
        }
        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("¿Esta seguro de eliminar persona?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res.ToString().Equals("Yes"))
                    {
                        Persona obp = dataGridView1.CurrentRow.DataBoundItem as Persona;
                        TLista.Eliminar(TLista.Buscar(obp.Cedula));
                    }
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar persona " + ex.Message);
            }

        }
        public void Modificar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEditPersona frm = new frmEditPersona();
                    frm.label1.Text = "Actualizar Persona";
                    Persona oax = dataGridView1.CurrentRow.DataBoundItem as Persona;
                    frm.SetDatos(oax);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Persona objp = frm.CrearObjeto();
                        TLista.Modificar(TLista.Buscar(objp.Cedula), objp);
                        frm.Close();
                        MessageBox.Show("Se ha actualizado la persona...");
                    }
                    else
                    {
                        frm.Close();
                        MessageBox.Show("Actualizacion cancelada...");
                    }
                }
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar persona " + ex.Message);
            }
        }




        public void Nuevo()
        {
            try
            {
                frmEditPersona frm = new frmEditPersona();
                frm.label1.Text = "Ingresar Persona";
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Persona op = frm.CrearObjeto();
                    TLista.Insertar(op);
                    frm.Close();
                    MessageBox.Show("Se ha ingresado la persona...");
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
                MessageBox.Show("Error al insertar persona " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void frmAdminPersona_Load(object sender, EventArgs e)
        {
            CargarDatos();
            Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personasMayoresEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidadMayores = TLista.CantidadMayoresEdad();
            MessageBox.Show("Cantidad de personas mayores de edad: " + cantidadMayores);
        }

        private void porcentajesMenoresDeEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double porcentajeMayores = TLista.PorcentajeMayoresEdad();
            MessageBox.Show("Porcentaje de personas mayores de edad: " + porcentajeMayores.ToString("F2") + "%");
        }

        private void porcentajeMayoresDeEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double porcentajeMenores = TLista.PorcentajeMenoresEdad();
            MessageBox.Show("Porcentaje de personas menores de edad: " + porcentajeMenores.ToString("F2") + "%");
        }

        private void examinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            



        }

        private void personasMenoresEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidadMenores = TLista.CantidadMenoresEdad();
            MessageBox.Show("Cantidad de personas menores de edad: " + cantidadMenores);
        }
    }
}
