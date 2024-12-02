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
using System.Xml.Linq;

namespace alquilerdemaquinaria.Formularios
{
    public partial class AgregarAlquiler : Form
    {
        public AgregarAlquiler(String funcion)
        {
            InitializeComponent();
            Tlistatarifa.rellenarcombobox(comboBox2);
            Tlistasocio.rellenarcombobox(comboBox1);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        public void setdatos(Alquiler oc)
        {
            textBox1.Text = (oc.Id).ToString();
            comboBox1.SelectedItem = oc.Socio.Id;
            comboBox2.SelectedItem = oc.Tarifa.Codigo;
            dateTimePicker1.Value = oc.FechaEntrega;
            dateTimePicker2.Value = oc.FechaTentativa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            int idsocio= int.Parse(comboBox1.SelectedItem.ToString());
            Socio oc = Tlistasocio.getSocio(Tlistasocio.Buscar(idsocio));
            String codigomaquinaria = comboBox2.SelectedItem.ToString();
            tarifa ta = Tlistatarifa.getSocio(Tlistatarifa.Buscar(codigomaquinaria));
            DateTime fechaentrega = dateTimePicker1.Value;
            DateTime fechaprevista = dateTimePicker2.Value;


            Alquiler al = new Alquiler(id,oc, ta, fechaentrega, fechaprevista);
            Tlistaalquiler.insertar(al);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
