using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_TAREA_N1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedIngredient = listBox1.SelectedItem.ToString();
            switch (selectedIngredient)
            {
                case "Mozzarella":
                    listBox2.Items.Add("Pizza de queso");
                    break;
                case "Prosciutto":
                    listBox2.Items.Add("Pizza con prosciutto");
                    break;
                case "Jamon":
                    listBox2.Items.Add("Pizza de jamon");
                    break;
                case "Aceitunas":
                    listBox2.Items.Add("Pizza con aceitunas");
                    break;
                case "Champiñones":
                    listBox2.Items.Add("Pizza con champiñones");
                    break;
                case "Pimientos":
                    listBox2.Items.Add("Pizza picante");
                    break;
                case "Atún":
                    listBox2.Items.Add("Pizza con atun");
                    break;
                case "BBQ":
                    listBox2.Items.Add("Pizza BBQ");
                    break;
            }
            listBox1.Items.Remove(listBox1.SelectedItem); // Remover el ingrediente de listBox1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedPlato = listBox2.SelectedItem.ToString();
            switch (selectedPlato)
            {
                case "Pizza de queso":
                    listBox1.Items.Add("Mozzarella");
                    break;
                case "Pizza con prosciutto":
                    listBox1.Items.Add("Prosciutto");
                    break;
                case "Pizza de jamon":
                    listBox1.Items.Add("Jamon");
                    break;
                case "Pizza con aceitunas":
                    listBox2.Items.Add("Aceitunas");
                    break;
                case "Pizza con champiñones":
                    listBox2.Items.Add("Champiñones");
                    break;
                case "Pizza picante":
                    listBox2.Items.Add("Pimientos");
                    break;
                case "Pizza con atun":
                    listBox2.Items.Add("Atún");
                    break;
                case "Pizza BBQ":
                    listBox2.Items.Add("BBQ");
                    break;
            }
            listBox2.Items.Remove(listBox2.SelectedItem); // Remover el plato de listBox2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 extraForm = new Form2();
            extraForm.Owner = this; // Set owner to access Form1
            extraForm.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Enabled = true; // Habilitar plástico
                checkBox2.Enabled = true; // Habilitar aluminio
                checkBox3.Enabled = true; // Habilitar isopor
            }
            else
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
        }

        List<string> ordenesAcumuladas = new List<string>(); // Lista para almacenar las órdenes

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                ordenesAcumuladas.Add(item.ToString());
            }
            listBox2.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total = 0;

            // Sumar ingredientes del listBox2
            foreach (var item in listBox2.Items)
            {
                if (item.ToString().Contains("Pizza de queso")) total += 12;
                if (item.ToString().Contains("Pizza con prosciutto")) total += 22;
                if (item.ToString().Contains("Pizza de jamon")) total += 15;
                if (item.ToString().Contains("Pizza con aceitunas")) total += 11;
                if (item.ToString().Contains("Pizza con champiñones")) total += 18;
                if (item.ToString().Contains("Pizza picante")) total += 16;
                if (item.ToString().Contains("Pizza con atun")) total += 18;
                if (item.ToString().Contains("Pizza BBQ")) total += 25;

            }

            // Sumar el costo de los envases si es para llevar
            if (radioButton1.Checked) // Para llevar
            {
                if (checkBox1.Checked) total += 3; // Plástico
                if (checkBox2.Checked) total += 9; // Aluminio
                if (checkBox3.Checked) total += 5; // Isopor
            }

            // Sumar el costo de las bebidas
            if (checkBox4.Checked) total += 10; // Jugo
            if (checkBox5.Checked) total += 7;  // Gaseosa
            if (checkBox6.Checked) total += 15; // Cerveza
            if (checkBox7.Checked) total += 50; // Vino

            textBox2.Text = "Total: " + total.ToString() + "USD";
        }

    }
}
