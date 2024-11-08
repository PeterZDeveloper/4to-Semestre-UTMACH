using System;
using System.Windows.Forms;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmEdit1 : Form
    {
        public FrmEdit1()
        {
            InitializeComponent();
        }

        public void SetDatos(Electronico elec)
        {
            textBox1.Text = elec.Codigo;
            textBox6.Text = elec.Costo.ToString("F2");
            textBox2.Text = elec.Descuento.ToString("F2");
            textBox3.Text = elec.Incremento.ToString("F2");
            textBox4.Text = elec.IGV.ToString("F2");
            textBox5.Text = elec.Total.ToString("F2");

            // Ajustar el estado del RadioButton según el tipo
            if (elec.Tipo == "Audio") radioButton1.Checked = true;
            else if (elec.Tipo == "Video") radioButton2.Checked = true;
            else if (elec.Tipo == "Linea Blanca") radioButton3.Checked = true;
        }

        public Electronico CrearObjeto()
        {
            string cod = textBox1.Text;
            double cos = ValidarDouble(textBox6.Text); // Costo
            double des = ValidarDouble(textBox2.Text); // Descuento
            double inc = ValidarDouble(textBox3.Text); // Incremento
            double igv = ValidarDouble(textBox4.Text); // IGV
            string type = " ";
            double total = ValidarDouble(textBox5.Text); // Total

            // Determina el tipo según el RadioButton seleccionado
            if (radioButton1.Checked) //audio
            {
                type = "Audio";
            }
            else if (radioButton2.Checked) //video
            {
                type = "Video";
            }
            else if (radioButton3.Checked) //linea blanca
            {
                type = "Linea Blanca";
            }

            // Crea y devuelve el objeto Electronico
            Electronico elec = new Electronico(cod, cos, des, inc, igv, type, total);
            return elec;
        }

        // Método para validar y convertir a double
        private double ValidarDouble(string texto)
        {
            double resultado;
            if (string.IsNullOrWhiteSpace(texto) || !double.TryParse(texto, out resultado))
            {
                return 0; // Retorna 0 si el texto no es válido
            }
            return resultado;
        }

        private bool Validar()
        {
            // Comprobar que el campo de código no esté vacío
            if (string.IsNullOrWhiteSpace(textBox1.Text)) // Código
            {
                return false;
            }

            // Validar los campos de tipo double
            if (ValidarDouble(textBox6.Text) == 0 && !string.IsNullOrWhiteSpace(textBox6.Text)) // Costo
            {
                return false;
            }
            if (ValidarDouble(textBox2.Text) == 0 && !string.IsNullOrWhiteSpace(textBox2.Text)) // Descuento
            {
                return false;
            }
            if (ValidarDouble(textBox3.Text) == 0 && !string.IsNullOrWhiteSpace(textBox3.Text)) // Incremento
            {
                return false;
            }
            if (ValidarDouble(textBox4.Text) == 0 && !string.IsNullOrWhiteSpace(textBox4.Text)) // IGV
            {
                return false;
            }
            if (ValidarDouble(textBox5.Text) == 0 && !string.IsNullOrWhiteSpace(textBox5.Text)) // Total
            {
                return false;
            }

            // Aquí puedes agregar más validaciones según sea necesario
            return true;
        }


        private void CalcularTotales()
        {
            double costo = Convert.ToDouble(textBox6.Text);
            double descuento = 0;
            double incremento = 0;
            double IGV = 0;
            double total = 0;

            if (checkBox1.Checked)
            {
                if (radioButton1.Checked) descuento = costo * 0.06;
                else if (radioButton2.Checked) descuento = costo * 0.08;
                else if (radioButton3.Checked) descuento = costo * 0.05;

                double costoConDescuento = costo - descuento;
                IGV = costoConDescuento * 0.19;
                total = costoConDescuento + IGV;

                textBox2.Text = descuento.ToString("F2");
            }
            else
            {
                if (radioButton1.Checked) incremento = costo * 0.07;
                else if (radioButton2.Checked) incremento = costo * 0.09;
                else if (radioButton3.Checked) incremento = costo * 0.10;

                double costoConIncremento = costo + incremento;
                IGV = costoConIncremento * 0.19;
                total = costoConIncremento + IGV;

                textBox3.Text = incremento.ToString("F2");
            }

            textBox4.Text = IGV.ToString("F2");
            textBox5.Text = total.ToString("F2");
        }

        public void Guardar()
        {
            try
            {
                CalcularTotales(); // Asegúrate de que se llaman antes de validar
                if (Validar())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Los campos con (*) son obligatorios");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Formato de entrada no válido: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }


        // Evento del botón Guardar
        private void button2_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        // Evento del botón Cancelar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
