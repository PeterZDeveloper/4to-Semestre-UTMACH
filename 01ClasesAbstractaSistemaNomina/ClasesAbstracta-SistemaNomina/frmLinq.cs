using ClasesAbstracta_SistemaNomina.Contralador;
using ClasesAbstracta_SistemaNomina.Entidades;
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

namespace ClasesAbstracta_SistemaNomina
{
    public partial class frmLinq : Form
    {
        public frmLinq()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            ReiniciarTabla();
            //ListarPorTipo();
        }

        private void ReiniciarTabla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        public void GenerarListados()
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerarListados();
        }

        //Linq to Object
        private void selectSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void selectUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      select new { le.Cedula, Nombre = le.Nombres.ToUpper(), Apellido = le.Apellidos.ToLower(), le.Tipo , le.Sueldo};
            dataGridView1.DataSource = sql.ToList();
        }

        private void selectCampoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      select new { le.Cedula, le.Nombres, le.Apellidos,le.Tipo};
            dataGridView1.DataSource = sql.ToList();
        }

        private void whereSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      where le.Sexo == 'M'
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void multipleWhereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      where le.Tipo.Equals("Fijo") && le.Sexo == 'F'
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void orderByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      orderby le.Apellidos descending
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void orderByLenghtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      orderby le.Nombres.Length ascending
                      select le;
            dataGridView1.DataSource = sql.ToList();
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      group le by le.Tipo into t
                      select new { Tipo = t.Key, Cantidad = t.Count() };
            dataGridView1.DataSource = sql.ToList();
        }

        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      group le by le.Tipo into t
                      select new { Tipo = t.Key, Total = t.Sum(c => c.Sueldo) };
            dataGridView1.DataSource = sql.ToList();
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      group le by le.Tipo into t
                      select new { Tipo = t.Key, Minimo = t.Min(c => c.Sueldo) };
            dataGridView1.DataSource = sql.ToList();
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      group le by le.Tipo into t
                      select new { Tipo = t.Key, Promedio = t.Average(c => c.Sueldo) };
            dataGridView1.DataSource = sql.ToList();
        }

        private void cantidadHombresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      where le.Sexo == 'M'
                      group le by le.Sexo into t
                      select new { Sexo = t.Key, Cantidad = t.Count() };
            dataGridView1.DataSource = sql.ToList();
        }

        private void cantidadMujeresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sql = from le in TlistaPersona.lista
                      where le.Sexo == 'F'
                      group le by le.Sexo into t
                      select new { Sexo = t.Key, Cantidad = t.Count() };
            dataGridView1.DataSource = sql.ToList();
        }

        //Lambda
        private void selectSimpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.ToList();
        }

        private void selectUpperLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.Select(c => new { c.Cedula, Nombres = c.Nombres.ToUpper(), Apellidos = c.Apellidos.ToLower(), c.Tipo, c.Sueldo }).ToList();
        }

        private void selectCampoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.Select(c => new { c.Cedula, c.Nombres, c.Apellidos, Edad = c.Edad() }).ToList();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.Where(c => c.Tipo.Equals("Contratado")).ToList();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.Where(c => c.Tipo.Equals("Fijo") && c.Sexo == 'F').ToList();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.OrderBy(c => c.Nombres).ToList();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.OrderBy(c => c.Nombres.Length).ToList();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.GroupBy(c => c.Tipo).Select(c => new { Tipo = c.Key, Cantidad = c.Count() }).ToList();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.GroupBy(c => c.Tipo).Select(c => new { Tipo = c.Key, Total = c.Sum(f => f.Sueldo) }).ToList();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.GroupBy(c => c.Tipo).Select(c => new { Tipo = c.Key, Minimo = c.Min(f => f.Sueldo) }).ToList();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.GroupBy(c => c.Tipo).Select(c => new { Tipo = c.Key, Promedio = c.Average(f => f.Sueldo) }).ToList();

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.Where(c => c.Sexo == 'M').GroupBy(c => c.Sexo).Select(c => new { Sexo = c.Key, Cantidad = c.Count() }).ToList();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TlistaPersona.lista.Where(c => c.Sexo == 'F').GroupBy(c => c.Sexo).Select(c => new { Sexo = c.Key, Cantidad = c.Count() }).ToList();

        }

        private void resetTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReiniciarTabla();
        }


        public void Nuevo()
        {
            frmEdit frm = new frmEdit();
            frm.ShowDialog();
            dataGridView1.DataSource = TlistaPersona.lista.ToList();
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
                dataGridView1.DataSource = TlistaPersona.lista.ToList();
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
                    frm.SetDatos(oax);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        Persona exn = frm.CrearObjeto();
                        TlistaPersona.Modificar(TlistaPersona.Buscar(oax.Cedula), exn);
                        frm.Close();
                        MessageBox.Show("Se ha actualizado la persona...");
                    }
                    else
                    {
                        frm.Close();
                        MessageBox.Show("Actualizacion cancelada...");
                    }
                }
                dataGridView1.DataSource = TlistaPersona.lista.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar persona " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Nuevo();
            dataGridView1.DataSource = TlistaPersona.lista.ToList();
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
            this.Close();
        }
    }
}
