using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_TAREA_N1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables para almacenar la selección del usuario
            string procesador = "";
            string memoria = "";
            string disco = "";
            string accesorios = "";
            string raid = ""; // Raid es independiente

            // Validar que se haya seleccionado un procesador
            if (radioButton1.Checked)
                procesador = "Procesador Elestra";
            else if (radioButton2.Checked)
                procesador = "Procesador SXM";
            else if (radioButton3.Checked)
                procesador = "Procesador Eption";
            else if (radioButton4.Checked)
                procesador = "Procesador MDA";
            else
            {
                MessageBox.Show("Por favor, selecciona un procesador.");
                return;
            }

            // Validar que se haya seleccionado una memoria
            if (radioButton5.Checked)
                memoria = "Memoria 16 TB";
            else if (radioButton6.Checked)
                memoria = "Memoria 4 TB";
            else if (radioButton7.Checked)
                memoria = "Memoria 1 TB";
            else if (radioButton8.Checked)
                memoria = "Memoria 512 GB";
            else
            {
                MessageBox.Show("Por favor, selecciona una memoria.");
                return;
            }

            // Obtener la selección del disco desde el comboBox1
            disco = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(disco))
            {
                MessageBox.Show("Por favor, selecciona un disco.");
                return;
            }

            // Validar RAID, independiente de los accesorios
            if (checkBox3.Checked)
                raid = "Controlador RAID";

            // Validar que los checkboxes de accesorios se seleccionen correctamente
            if (checkBox2.Checked) // Si CheckBox2 (Mouse) está seleccionado
            {
                if (checkBox4.Checked)
                    accesorios += "Grabación de Video, ";
                if (checkBox5.Checked)
                    accesorios += "Micrófono, ";
            }

            // CheckBox 1 (Teclado) y CheckBox 2 (Mouse) son independientes
            if (checkBox1.Checked)
                accesorios += "Teclado, ";
            if (checkBox2.Checked)
                accesorios += "Mouse, ";

            // Quitar la última coma y espacio si hay accesorios seleccionados
            if (accesorios.EndsWith(", "))
                accesorios = accesorios.Remove(accesorios.Length - 2);

            // Si no se seleccionó ningún accesorio
            if (string.IsNullOrEmpty(accesorios))
                accesorios = "Sin accesorios";

            // Formar la cadena final con las selecciones
            string resultadoFinal = $"{procesador}, {memoria}, Disco: {disco}, Accesorios: {accesorios}";

            // Agregar el RAID si fue seleccionado
            if (!string.IsNullOrEmpty(raid))
                resultadoFinal += $", {raid}";

            // Agregar el resultado al ListBox
            listBox2.Items.Add(resultadoFinal);
        }
    }
}
