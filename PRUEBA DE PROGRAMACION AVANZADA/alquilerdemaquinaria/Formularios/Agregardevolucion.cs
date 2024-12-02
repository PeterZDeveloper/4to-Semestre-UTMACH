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
    public partial class Agregardevolucion : Form
    {
        public Agregardevolucion()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }

        public void setdatos(Alquiler al)
        {
            textBox1.Text = (al.Id).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idventa = int.Parse(textBox1.Text);
            DateTime dt = dateTimePicker1.Value;
            Alquiler al = Tlistaalquiler.getPersona(Tlistaalquiler.Buscar(idventa));
            Devolucion dv = new Devolucion(al, dt);
            TlistaDevolucion.insertar(dv);
        }
    }
}
