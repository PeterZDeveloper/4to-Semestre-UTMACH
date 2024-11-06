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
    public partial class frmEditPersona : Form
    {
        public frmEditPersona()
        {
            InitializeComponent();
        }
        public void SetDatos(Persona op)
        {
             textBox1.Text=op.Cedula;
             textBox2.Text=op.Nombres;
             textBox3.Text=op.Apellidos;
             dateTimePicker1.Value = op.FechaNacimiento; ;
             comboBox1.SelectedItem = op.Sexo.ToString();
             comboBox2.SelectedItem=op.Estado;
             comboBox3.SelectedItem = op.TipoSangre;
             comboBox4.SelectedItem = op.Ciudad;
        }
        public Persona CrearObjeto()
        {
            string ced = textBox1.Text;
            string nom = textBox2.Text;
            string ape = textBox3.Text;
            DateTime fn = dateTimePicker1.Value;
            char sex = char.Parse(comboBox1.SelectedItem.ToString());
            string est = comboBox2.SelectedItem.ToString();
            string tip = comboBox3.SelectedItem.ToString();
            string ciu = comboBox4.SelectedItem.ToString();
            Persona op = new Persona(ced, nom, ape, fn, sex, est, tip, ciu);
            return op;
        }
        public bool Validar()
        {
            bool val = true;
            if (textBox1.Text.Trim().Length == 0 && textBox2.Text.Trim().Length == 0 && textBox3.Text.Trim().Length == 0 && comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0 && comboBox3.SelectedIndex >= 0 && comboBox4.SelectedIndex >= 0)
            {
                val = false;
            }
            return val;
        }
        public void Guardar()
        {
            try
            {
                if (Validar())
                {
                    this.DialogResult = DialogResult.OK;

                }
                else
                    MessageBox.Show("Los campos con (*) son obligatorios");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
