using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTRA_1_Manejo_De_Syntaxis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Soltero");
            comboBox1.Items.Add("Casado");
            comboBox1.Items.Add("Divorciado");
            comboBox1.Items.Add("Viudo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        //METODO SIGNOS ZODIACALES
        public String SignoZ(int dia, int mes)
        {
            String signo = "";
            switch (mes)
            {
                case 1:
                    if (dia > 21)
                    {
                        signo = "ACUARIO";
                    }
                    else
                    {
                        signo = "CAPRICORNIO";
                    }
                    break;
                case 2:
                    if (dia > 19)
                    {
                        signo = "PISCIS";
                    }
                    else
                    {
                        signo = "ACUARIO";
                    }
                    break;
                case 3:
                    if (dia > 20)
                    {
                        signo = "ARIES";
                    }
                    else
                    {
                        signo = "PISCIS";
                    }
                    break;
                case 4:
                    if (dia > 20)
                    {
                        signo = "TAURO";
                    }
                    else
                    {
                        signo = "ARIES";
                    }
                    break;
                case 5:
                    if (dia > 21)
                    {
                        signo = "GEMINIS";
                    }
                    else
                    {
                        signo = "TAURO";
                    }
                    break;
                case 6:
                    if (dia > 20)
                    {
                        signo = "CANCER";
                    }
                    else
                    {
                        signo = "GEMINIS";
                    }
                    break;
                case 7:
                    if (dia > 22)
                    {
                        signo = "LEO";
                    }
                    else
                    {
                        signo = "CANCER";
                    }
                    break;
                case 8:
                    if (dia > 21)
                    {
                        signo = "VIRGO";
                    }
                    else
                    {
                        signo = "LEO";
                    }
                    break;
                case 9:
                    if (dia > 22)
                    {
                        signo = "LIBRA";
                    }
                    else
                    {
                        signo = "VIRGO";
                    }
                    break;
                case 10:
                    if (dia > 22)
                    {
                        signo = "ESCORPION";
                    }
                    else
                    {
                        signo = "LIBRA";
                    }
                    break;
                case 11:
                    if (dia > 21)
                    {
                        signo = "SAGITARIO";
                    }
                    else
                    {
                        signo = "ESCORPION";
                    }
                    break;
                case 12:
                    if (dia > 21)
                    {
                        signo = "CAPRICORNIO";
                    }
                    else
                    {
                        signo = "SAGITARIO";
                    }
                    break;
            }
            return signo;
        }
        //METODO EDAD
        public int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > hoy.AddYears(-edad)) edad--;
            return edad;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string cedula = textBox1.Text;
            string nombre = textBox2.Text;
            string apellidos = textBox3.Text;

            DateTime fechaNacimiento = dateTimePicker1.Value;

            //LLAMADA AL VALOR DE EDAD
            int edad = CalcularEdad(fechaNacimiento);


            string estadoCivil = comboBox1.SelectedItem.ToString();

            string sexo = " ";
            if (radioButton1.Checked)
            {
                sexo = "Femenino";
            }
            else if (radioButton2.Checked)
            {
                sexo = "Masculino";
            }

            //METODOS EXTRA:

            //ASGNACION DE VARIABLES MEDIANTE FECHA DE NACIMIENTO PARA EL SIGNO ZODIACAL
            int dia = fechaNacimiento.Day; 
            int mes = fechaNacimiento.Month; 

            string signoZodiacal = SignoZ(dia, mes);

            //IMPRESION DE DATOS
            string info = $"Cédula: {cedula}\n" +
                          $"Nombre: {nombre}\n" +
                          $"Apellidos: {apellidos}\n" +
                          $"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}\n" +
                          $"Edad: {edad}\n" +
                          $"Estado Civil: {estadoCivil}\n" +
                          $"Signo Zodiacal: {signoZodiacal}\n" +
                          $"Sexo: {sexo}";
            //MESSAGEBOX = A JOPTIONPANEL en java. 
            MessageBox.Show(info, "Información del Usuario");

        }

    }
}
