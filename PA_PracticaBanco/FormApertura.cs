using PA_PracticaBanco.Controlador;
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

namespace PA_PracticaBanco
{
    public partial class FormApertura : Form
    {
        public FormApertura()
        {
            InitializeComponent();
        }

        /*
    public Cuenta(string cedula, string nombre, string direccion, string telefono, int edad, string tipo, double saldoInicial)
        : base(cedula, nombre, direccion, telefono, edad)
    {
        Numero = contadorCuentas++;
        Tipo = tipo;
        Saldo = saldoInicial;
    }
         */
        public void setdatos(Cuenta oc)
        {
            textBox1.Text = (oc.Cedula).ToString();
            textBox2.Text = (oc.Nombre).ToString();
            textBox3.Text = (oc.Direccion).ToString();
            textBox4.Text = (oc.Telefono).ToString();
            textBox5.Text = (oc.Edad).ToString();
            textBox6.Text = (oc.SaldoDisponible).ToString();
            comboBox1.SelectedItem = oc.TipoCuenta.ToString();
        }

        Cuenta oc;
        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            String ced = textBox1.Text;
            String nom = textBox2.Text;
            String dir = textBox3.Text;
            String tele = textBox4.Text;
            int edad = int.Parse(textBox5.Text);
            double saldo = double.Parse(textBox6.Text);
            String tipo = comboBox1.SelectedItem.ToString();
            
            Cuenta oc = new Cuenta(ced,nom,dir,tele,edad,tipo,saldo);
            TListaCuenta.Insertar(oc);
            DialogResult = DialogResult.OK;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            //imprimir

            oc.Imprimir();

        }
    }
}
