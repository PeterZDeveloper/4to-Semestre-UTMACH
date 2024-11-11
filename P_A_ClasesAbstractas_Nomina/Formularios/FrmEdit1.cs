using P_A_ClasesAbstractas_Nomina.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_A_ClasesAbstractas_Nomina
{
    public partial class FrmEdit1 : Form
    {
        List<Persona> personas = new List<Persona>();
        public FrmEdit1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Fijo of;
        Contratado oc;
        Comision ocom;
        Comisionados ocoms;
        /*
Fijo
Comision
Comisionado
Contratado
         */
        // Guardar
        private void button1_Click(object sender, EventArgs e)
        {
            CalcularTotales();  // Calcular totales (si aplica a la lógica del negocio)
            this.DialogResult = DialogResult.OK;  // Marca el diálogo como exitoso
            this.Close();  // Cierra el formulario
        }

        public Persona CrearObjeto()
        {
            string ced = textBox1.Text;
            string nom = textBox2.Text;
            string ape = textBox3.Text;
            DateTime fn = dateTimePicker1.Value;
            char sex = char.Parse(comboBox4.SelectedItem.ToString());
            string est = comboBox3.SelectedItem.ToString();
            string ciu = comboBox1.SelectedItem.ToString();
            string tip = comboBox2.SelectedItem.ToString();
            double sal = Double.Parse(textBox4.Text);
            double ant = Double.Parse(textBox5.Text);
            double ies = Double.Parse(textBox6.Text);

            Persona nuevoEmpleado = null;

            if (tip.Equals("Fijo"))
            {
                if (ant <= (sal * 0.50))
                {
                    double iess = (sal * ies) / 100;
                    nuevoEmpleado = new Fijo(ced, nom, ape, fn, sex, est, tip, ciu, sal, iess, ant);
                }
                else
                {
                    MessageBox.Show("El anticipio es mayor al 50% del salario.");
                }
            }
            else if (tip.Equals("Contratado"))
            {
                nuevoEmpleado = new Contratado(ced, nom, ape, fn, sex, est, tip, ciu, sal, ies, ant);
            }
            else if (tip.Equals("Comision"))
            {
                nuevoEmpleado = new Comision(ced, nom, ape, fn, sex, est, tip, ciu, sal, ies);
            }
            else if (tip.Equals("Comisionado"))
            {
                nuevoEmpleado = new Comisionados(ced, nom, ape, fn, sex, est, tip, ciu, sal, ies, ant);
            }

            return nuevoEmpleado;
        }


        public void SetDatos(Persona p)
        {
            // Asegúrate de que las propiedades del objeto p sean las correctas
            textBox1.Text = p.Cedula;  
            textBox2.Text = p.Nombres;  
            textBox3.Text = p.Apellidos; 
            dateTimePicker1.Value = p.FechaNacimiento; 
            comboBox4.SelectedItem = p.Sexo.ToString();  
            comboBox3.SelectedItem = p.Estado; 
            comboBox1.SelectedItem = p.Ciudad;  
            comboBox2.SelectedItem = p.Tipo; 

            // Si hay campos adicionales como salario, antigüedad o IESS, añade las líneas aquí, de acuerdo a las propiedades de la clase concreta
        }

        //metodo extraido del deber
        private double ValidarDouble(string texto)
        {
            return double.TryParse(texto, out double resultado) ? resultado : 0;
        }

        private void CalcularTotales()
        {
            double pago = 0;
            double total = 0;

            // Asegúrate de que las variables estén correctamente inicializadas
            if (comboBox2.SelectedItem.Equals("Fijo"))
            {
                of = new Fijo();  // Asegúrate de pasar los parámetros necesarios al crear la instancia
                total = of.CalcularSueldo();  // Calculamos el sueldo para el empleado Fijo
            }
            else if (comboBox2.SelectedItem.Equals("Contratado"))
            {
                oc = new Contratado();  // Inicializas el objeto Contratado
                total = oc.CalcularSueldo();  // Calculamos el sueldo para el empleado Contratado
            }
            else if (comboBox2.SelectedItem.Equals("Comision"))
            {
                ocom = new Comision();  // Inicializas el objeto Comision
                total = ocom.CalcularSueldo();  // Calculamos el sueldo para el empleado Comision
            }
            else if (comboBox2.SelectedItem.Equals("Comisionado"))
            {
                ocoms = new Comisionados();  // Inicializas el objeto Comisionado
                total = ocoms.CalcularSueldo();  // Calculamos el sueldo para el empleado Comisionado
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un tipo de empleado.");
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoEmpleado = comboBox2.SelectedItem.ToString();//obligatorio para evitar errores

            if (tipoEmpleado == "Contratado")
            {
                label10.Text = "Hora";
                label11.Text = "Costo";
                label12.Text = "IEES";
            }
            else if (tipoEmpleado == "Fijo")
            {
                label10.Text = "Anticipo";
                label11.Text = "Salario";
                label12.Text = "IEES";
            }
            else if (tipoEmpleado == "Comision")
            {
                label10.Text = "Tarifa";
                label11.Text = "Salario";
                label12.Text = "Ventas";
            }
            else if (tipoEmpleado == "Comisionado")
            {
                label10.Text = "Tarifa";
                label11.Text = "Salario";
                label12.Text = "Ventas";
            }
        }

        //cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //cierra el insertar
        }



    }
}
