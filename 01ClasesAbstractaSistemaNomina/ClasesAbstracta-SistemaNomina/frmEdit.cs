using ClasesAbstracta_SistemaNomina.Contralador;
using ClasesAbstracta_SistemaNomina.Entidades;
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

namespace ClasesAbstracta_SistemaNomina
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
            setVisible(false);
        }
        Fijo of;
        Contratado contr;
        Comision comi;
        Comisionado Comisionados;


        public Persona PersonaVieja;
        private static bool modificar;

        public  bool Modificar { get => modificar; set => modificar = value; }

        public void SetDatos(Persona per)
        {
            textBox1.Text = per.Cedula.ToString();
            textBox2.Text = per.Nombres.ToString();
            textBox3.Text = per.Apellidos.ToString();
            dateTimePicker1.Value = per.FechaNacimiento;
            comboBox1.Text = per.Sexo.ToString();
            comboBox3.Text = per.Tipo.ToString();

            if (per is Comisionado comisionado)
            {
                textBox5.Text = comisionado.Ventas.ToString();
                textBox6.Text = comisionado.Porcentaje.ToString();
                textBox7.Text = comisionado.Salario.ToString();
            }
            else if (per is Comision comision)
            {
                textBox5.Text = comision.Ventas.ToString();
                textBox6.Text = comision.Porcentaje.ToString();
            }
            else if (per is Fijo fijo)
            {
                textBox5.Text = fijo.Salario.ToString();
                textBox6.Text = fijo.Iees.ToString();
                textBox7.Text = fijo.Anticipo.ToString();
            }
            else if (per is Contratado contratado)
            {
                textBox5.Text = contratado.Hora.ToString();
                textBox6.Text = contratado.Costo.ToString();
                textBox7.Text = contratado.Iess.ToString();
            }
        }

        public Persona CrearObjeto()
        {
            string ced = textBox1.Text;
            string nom = textBox2.Text;
            string ape = textBox3.Text;
            DateTime fn = dateTimePicker1.Value;
            char sex = char.Parse(comboBox1.SelectedItem.ToString());
            string tipo = comboBox3.SelectedItem.ToString();
            double x1 = double.Parse(textBox5.Text);//salario
            double x2 = double.Parse(textBox6.Text);//iess
            double x3 = string.IsNullOrEmpty(textBox7.Text) ? 0.0 : double.Parse(textBox7.Text); // anticipo
            if (tipo.Equals("Fijo"))
            {
                if (x3 <= (x1 * 0.5))
                {
                    double Ieees = (x1 * x2) / 100;
                    of = new Fijo(ced, nom, ape, fn, sex, tipo, 0, x1, Ieees, x3);
                }
                else
                {
                    MessageBox.Show("Anticipo mayot a 50%");
                }
            }
            else if (tipo.Equals("Contratado"))
            {
                contr = new Contratado(ced, nom, ape, fn, sex, tipo, 0, x1, x2, x3);
            }
            else if (tipo.Equals("Comision"))
            {
                comi = new Comision(ced, nom, ape, fn, sex, tipo, 0, x1, x2);
            }
            else if (tipo.Equals("Comisionado"))
            {
                Comisionados = new Comisionado(ced, nom, ape, fn, sex, tipo, 0, x1, x2, x3);
            }

            Persona persona = of ?? (Persona)contr ?? (Persona)comi ?? (Persona)Comisionados;


            if (modificar)
            {
                return persona;
            }
            else
            {
                if (persona != null)
                {
                    TlistaPersona.Insertar(persona);
                }
                MessageBox.Show("Registro Creado");
                return persona;

            }



        }


        private void button1_Click(object sender, EventArgs e)
        {
            CrearObjeto();
            this.Close();
         
            if (modificar)
            {
                Persona oax = CrearObjeto();
                TlistaPersona.Modificar(TlistaPersona.Buscar(PersonaVieja.Cedula), oax);
            }
          

            /*
             * 
            DialogResult result = MessageBox.Show("¿Desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (of != null || contr != null || comi != null || Comisionados != null)
            {
                if (comboBox3.SelectedItem.Equals("Fijo"))
                {
                    of.imprimir();
                }
                else if (comboBox3.SelectedItem.Equals("Contratado"))
                {
                    contr.imprimir();
                }
                else if (comboBox3.SelectedItem.Equals("Comision"))
                {
                    comi.imprimir();
                }
                else if (comboBox3.SelectedItem.Equals("Comisionado"))
                {
                    Comisionados.imprimir();
                }

            }
            else
            {
                MessageBox.Show("No se ha guardado ningun dato");
            }
            
        }

        public void setVisible(bool a)
        {
            label10.Visible = a;
            label11.Visible = a;
            label12.Visible = a;
            textBox5.Visible = a;
            textBox6.Visible = a;
            textBox7.Visible = a;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            setVisible(true);
            if (comboBox3.SelectedItem.Equals("Fijo"))
            {
                label10.Text = "Salario";
                label11.Text = "Iees";
                label12.Text = "Anticipo";

            }
            else if (comboBox3.SelectedItem.Equals("Contratado"))
            {
                label10.Text = "Hora";
                label11.Text = "Costo";
                label12.Text = "Iees";
            }
            else if (comboBox3.SelectedItem.Equals("Comision"))
            {
                label10.Text = "Ventas";
                label11.Text = "Porcentaje";
                label12.Text = "";
                label12.Visible = false;
                textBox7.Visible = false;
            }
            else if (comboBox3.SelectedItem.Equals("Comisionado"))
            {
                label10.Text = "Ventas";
                label11.Text = "Porcentaje";
                label12.Text = "Salario";
            }
        }
    }
}
