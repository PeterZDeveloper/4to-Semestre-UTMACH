using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmEdit6 : Form
    {
        public FrmEdit6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardar
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cerrar el formulario después de guardar
        }
        //        public Pelicula(string titulo, string categoria, int duracion, string actor)
        public void SetDatos(Pelicula peli)
        {

            textBox1.Text = peli.Titulo;
            textBox3.Text = peli.Actor;
            textBox2.Text = peli.Duracion.ToString("F2");
            

        }

        public Pelicula CrearObjeto()
        {
            string tit = textBox1.Text;
            string act = textBox3.Text;
            double dura;

            // Verificar que la duración sea un número válido
            if (!double.TryParse(textBox2.Text, out dura))
            {
                MessageBox.Show("Por favor, ingrese una duración válida.");
                return null;
            }

            string cat = "";
            if (radioButton1.Checked)
            {
                cat = "Comedia";
            }
            else if (radioButton2.Checked)
            {
                cat = "Dibujos Animados";
            }
            else if (radioButton3.Checked)
            {
                cat = "Accion";
            }
            else if (radioButton5.Checked)
            {
                cat = "Drama";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría.");
                return null;
            }

            return new Pelicula(tit, cat, dura, act);
        }


    }
}
