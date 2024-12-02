using alquilerdemaquinaria.Entidades;
using alquilerdemaquinaria.Tlista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alquilerdemaquinaria.Formularios
{
    public partial class TablaAdmin : Form
    {
        public TablaAdmin()
        {
            InitializeComponent();
            Tlistasocio.AgregarSocios();
            Tlistatarifa.Agregartarifas();
            comboBox1.SelectedIndex = 0;
        }

        public void listarAlquilados()
        {
            var datosTabla = Tlistaalquiler.listaAlquiler.Select(p => new
            {
                IdAlquiler= p.Id,
                Idsocio = p.Socio.Id,
                IdMaquinaria = p.Tarifa.Codigo,
                fechaEntrega = p.FechaEntrega,
                fechaPrevista = p.FechaTentativa,
                Dias = p.Dias,
                Importe = p.Importe,
                Descuentodia = p.descuentosdias(),
                Descuentosocio = p.descuentossocio(),
                Garantía = p.Deposito(),
                Multa = "",
                TotalAPagar = p.Pagototal
            }).ToList();

            dataGridView1.DataSource = datosTabla;

        }

        public void listarSocio()
        {
            var datosTabla = Tlistasocio.ListaDeSocios.Select(p => new
            {
                 Idsocio = p.Id,
                ContratodAfilacion = p.ContratoAfilacion,
            }).ToList();

            dataGridView1.DataSource = datosTabla;

        }

        public void listarTarifas()
        {
            var datosTabla = Tlistatarifa.ListaDetarifa.Select(p => new
            {
                Codigo = p.Codigo,
                Tipo = p.Tipo,
                Tarifa= p.Tarifadia
            }).ToList();

            dataGridView1.DataSource = datosTabla;

        }

        public void listarDevolucion()
        {
            var datosTabla = TlistaDevolucion.listaAlquiler.Select(p => new
            {
                IdAlquiler = p.Al.Id,
                Idsocio = p.Al.Socio.Id,
                IdMaquinaria = p.Al.Tarifa.Codigo,
                fechaEntrega = p.Al.FechaEntrega,
                fechaPrevista = p.Al.FechaTentativa,
                fechaDevolucion= p.Fechadevolucion,
                Dias = p.Al.Dias,
                Importe = p.Al.Importe,
                Descuentodia = p.Al.descuentosdias(),
                Descuentosocio = p.Al.descuentossocio(),
                Garantía = p.Al.Deposito(),
                Multa = p.Multa1,
                TotalAPagar = p.Al.Pagototal
            }).ToList();

            dataGridView1.DataSource = datosTabla;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarAlquiler frm = new AgregarAlquiler("Agregar");
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                frm.Close();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                frm.Close();
                MessageBox.Show("Ingreso cancelado...");
            }
            verificarcombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarAlquiler frm = new AgregarAlquiler("Editar");
            int cedula = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Console.Write(cedula);
            Alquiler al = Tlistaalquiler.getPersona(Tlistaalquiler.Buscar(cedula));
            frm.setdatos(al);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                frm.Close();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                frm.Close();
                MessageBox.Show("Ingreso cancelado...");
            }
            verificarcombo();
        }

        public void verificarcombo()
        {
            String str = comboBox1.SelectedItem.ToString();
            if (str.Equals("Tarifa"))
            {
                listarTarifas();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (str.Equals("Socios"))
            {
                listarSocio();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (str.Equals("Alquilados"))
            {
                listarAlquilados();
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else if (str.Equals("Devueltos"))
            {
                listarDevolucion();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            verificarcombo();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agregardevolucion frm = new Agregardevolucion();
            int cedula = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Console.Write(cedula);
            Alquiler al = Tlistaalquiler.getPersona(Tlistaalquiler.Buscar(cedula));
            frm.setdatos(al);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                frm.Close();
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                frm.Close();
                MessageBox.Show("Ingreso cancelado...");
            }
            verificarcombo();
        }

        private void porcentajeEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TlistaDevolucion.agregadopromedio(dataGridView1);
        }

        private void equipoMasAlquiladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TlistaDevolucion.agregadomaximo(dataGridView1);
        }

        private void TablaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
