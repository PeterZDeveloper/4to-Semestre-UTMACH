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

namespace OrientadoAObjetos.Entidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //VARIABLES GLOBALES 
        Fijo of;
        Consultor oc;


        private void button1_Click(object sender, EventArgs e)
        {
            string ced = textBox1.Text;
            string ape = textBox3.Text;
            string nom = textBox2.Text;
            char sex = char.Parse(comboBox1.SelectedItem.ToString());
            DateTime  fn = dateTimePicker1.Value;
            string est = comboBox2.SelectedItem.ToString();

            double v1 = double.Parse(textBox4.Text); //Sue OR horas
            double v2 = double.Parse(textBox5.Text); //imp OR cost

            if (comboBox3.SelectedItem.Equals("Consultor"))
            {

                oc = new Consultor(ced, nom, ape, fn, sex, est, v1, v2);
            }
            
            if (comboBox3.SelectedItem.Equals("Fijo"))
            {
            
                of = new Fijo(ced, nom, ape, fn, sex, est, v1, v2);

            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ifs para cambiar los labels de los tipos de trabajador.
            if(comboBox3.SelectedItem.Equals("Consultor"))
            {
                label9.Text = "Horas";
                label10.Text = "Costo";
            }
            if (comboBox3.SelectedItem.Equals("Fijo"))
            {
                label9.Text = "Sueldo";
                label10.Text = "Impuestos";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.Equals("Consultor"))
            {
                oc.Imprimir();
            }
            if (comboBox3.SelectedItem.Equals("Fijo"))
            {
                of.Imprimir();

            }
        }
    }
}
