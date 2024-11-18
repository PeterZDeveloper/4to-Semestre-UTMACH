using ClasesAbstracta_SistemaNomina.Contralador;
using ClasesAbstracta_SistemaNomina.Entidades;
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

namespace ClasesAbstracta_SistemaNomina
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            comboBox1.Text = "Persona";
            dataGridView1.AutoGenerateColumns = true;
        }

        public void DataDefault()
        {
            TlistaPersona.Insertar(new Fijo("0905656981", "Maria", "Ordoñez", new DateTime(1998, 08, 28), 'F', "Fijo", 0, 2000, 9, 80));
            TlistaPersona.Insertar(new Fijo("0803456781", "Juan", "Perez", new DateTime(1995, 12, 15), 'M', "Fijo", 0, 1500, 10, 30));
            TlistaPersona.Insertar(new Contratado("1723456784", "Maria", "Carlota", new DateTime(2000, 06, 20), 'F', "Contratado", 0, 200, 9, 10));
            TlistaPersona.Insertar(new Comision("1109876542", "Roni", "Loja", new DateTime(2005, 07, 30), 'M', "Comision", 0, 4500, 25));
            TlistaPersona.Insertar(new Comisionado("0105671238", "Mary", "Juana", new DateTime(1999, 12, 20), 'F', "Comisionado", 0, 4590, 15, 500));
            GenerarListados();
        }

        private void ReiniciarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }


        public void ListarPorTipo()
        {
            ReiniciarTabla();
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "Persona":
                        dataGridView1.DataSource = TlistaPersona.lista.ToList();
                        break;
                    case "Fijo":
                        dataGridView1.DataSource = TlistaFijo.lista.ToList();
                        break;
                    case "Contratado":
                        dataGridView1.DataSource = TlistaContratado.lista.ToList();
                        break;
                    case "Comision":
                        dataGridView1.DataSource = TlistaComision.lista.ToList();
                        break;
                    case "Comisionado":
                        dataGridView1.DataSource = TlistaComisionado.lista.ToList();
                        break;
                    default:
                        MessageBox.Show("Seleccione un tipo válido.");
                        break;
                }
            }
        }

        public void GenerarListados()
        {
            ReiniciarTabla();
            TlistaFijo.ClearLista();
            TlistaContratado.ClearLista();
            TlistaComision.ClearLista();
            TlistaComisionado.ClearLista();
            foreach (Persona per in TlistaPersona.lista)
            {
                if (per is Comisionado comisionado)
                {
                    TlistaComisionado.Insertar(comisionado);
                }
                else if (per is Comision comision)
                {
                    TlistaComision.Insertar(comision);
                }
                else if (per is Fijo fijo)
                {
                    TlistaFijo.Insertar(fijo);
                }
                else if (per is Contratado contratado)
                {
                    TlistaContratado.Insertar(contratado);
                }

                ListarPorTipo();
            }
        }

        public void Nuevo()
        {
            frmEdit frm = new frmEdit();
            frm.ShowDialog();
            ListarPorTipo();
        }


        public void Eliminar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    var res = MessageBox.Show("¿Esta seguro de eliminar Persona?", "Eliminar", MessageBoxButtons.YesNo);
                    if (res.ToString().Equals("Yes"))
                    {
                        Persona obp = dataGridView1.CurrentRow.DataBoundItem as Persona;
                        TlistaPersona.Eliminar(TlistaPersona.Buscar(obp.Cedula));
                    }
                }
                GenerarListados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Persona" + ex.Message);
            }
        }

        public void Modificar()
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    frmEdit frm = new frmEdit();
                    Persona oax = dataGridView1.CurrentRow.DataBoundItem as Persona;
                    frm.PersonaVieja = oax;
                    frm.SetDatos(oax);
                    frm.Modificar = true;
                    frm.ShowDialog();

                    MessageBox.Show("Se ha actualizado la persona...");
                }
                GenerarListados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar persona " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
            GenerarListados();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarListados();
        }

        private void linqToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linqToObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinq frm = new frmLinq();
            frm.ShowDialog();
            GenerarListados();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DataDefault();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
