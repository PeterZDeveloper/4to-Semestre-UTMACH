using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_A_TAREA_N1_3
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar DataGridView antes de generar una nueva factura
            dataGridView1.Rows.Clear();

            // Variables para almacenar descripciones y precios
            string descripcion = "";
            int precioProcesador = 0;
            int precioMemoria = 0;
            int precioMonitor = 0;
            int precioAccesorios = 0;

            // Procesador seleccionado
            if (radioButton1.Checked) { descripcion = "P4"; precioProcesador = 400; }
            else if (radioButton2.Checked) { descripcion = "AMD"; precioProcesador = 500; }
            else if (radioButton3.Checked) { descripcion = "DUAL CORE"; precioProcesador = 600; }
            else if (radioButton4.Checked) { descripcion = "CORE 2 DUO"; precioProcesador = 1400; }
            else { MessageBox.Show("Por favor, selecciona un procesador."); return; }

            // Añadir procesador a la factura
            dataGridView1.Rows.Add(1, descripcion, precioProcesador, precioProcesador);

            // Memoria seleccionada
            if (radioButton5.Checked) { descripcion = "256 MB"; precioMemoria = 50; }
            else if (radioButton6.Checked) { descripcion = "512 MB"; precioMemoria = 75; }
            else if (radioButton7.Checked) { descripcion = "1 GB"; precioMemoria = 700; }
            else if (radioButton8.Checked) { descripcion = "2 GB"; precioMemoria = 1350; }
            else { MessageBox.Show("Por favor, selecciona una memoria."); return; }

            // Añadir memoria a la factura
            dataGridView1.Rows.Add(1, descripcion, precioMemoria, precioMemoria);

            // Monitor seleccionado en comboBox1
            string monitorSeleccionado = comboBox1.SelectedItem?.ToString();
            switch (monitorSeleccionado)
            {
                case "Samsung 34 Odyssey G5 WQHD":
                    descripcion = "Samsung 34 Odyssey G5 WQHD"; precioMonitor = 400;
                    break;
                case "Thunderobot KU27F144M 27″":
                    descripcion = "Thunderobot KU27F144M 27″"; precioMonitor = 500;
                    break;
                case "Lg 27GN65R-B Ultragear 27 Pulgadas":
                    descripcion = "Lg 27GN65R-B Ultragear 27 Pulgadas"; precioMonitor = 600;
                    break;
                case "Asus TUF Gaming VG27WQ1B Wqhd":
                    descripcion = "Asus TUF Gaming VG27WQ1B Wqhd"; precioMonitor = 1400;
                    break;
                case "Cooler Master GA241 23.8″ Monitor":
                    descripcion = "Cooler Master GA241 23.8″ Monitor"; precioMonitor = 2200;
                    break;
                default:
                    MessageBox.Show("Por favor, selecciona un monitor."); return;
            }

            // Añadir monitor a la factura
            dataGridView1.Rows.Add(1, descripcion, precioMonitor, precioMonitor);

            // Accesorios seleccionados en checkedListBox1
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                switch (itemChecked.ToString())
                {
                    case "Tarjeta de video":
                        descripcion = "Tarjeta de video"; precioAccesorios = 200;
                        break;
                    case "tarjeta de sonido 5.1":
                        descripcion = "tarjeta de sonido 5.1"; precioAccesorios = 145;
                        break;
                    case "parlantes 5.1":
                        descripcion = "parlantes 5.1"; precioAccesorios = 75;
                        break;
                }
                // Añadir accesorio a la factura
                dataGridView1.Rows.Add(1, descripcion, precioAccesorios, precioAccesorios);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;

            // Sumar el total de cada fila en el DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells[3].Value); // La columna 3 es el total de la fila
            }

            // Mostrar el subtotal en textBox1
            textBox1.Text = subtotal.ToString();

            // Calcular y mostrar el IVA (14%) en textBox2
            decimal iva = subtotal * 0.14m;
            textBox2.Text = iva.ToString();

            // Calcular y mostrar el total a pagar en textBox3
            decimal total = subtotal + iva;
            textBox3.Text = total.ToString();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
