using OrientadoAObjetos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientadoAObjetos
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Persona op;
        string ced;
        string ape;
        string nom;
        string est;
        DateTime fn;
        char sex;

        private void button1_Click(object sender, EventArgs e)
        {
             ced = textBox1.Text;
             ape = textBox3.Text;
             nom = textBox2.Text;
             sex = char.Parse(comboBox1.SelectedItem.ToString());
             fn = dateTimePicker1.Value;
             est = comboBox2.SelectedItem.ToString();
            op = new Persona(ced, ape, nom, fn,sex, est);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(op.ImprimirPersona());
        }
    }
}
