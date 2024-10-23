using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA_Intra_N1_1_ICF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
            X Y
            X = recorrido en horizontal empeznado de izquierda a derecha.
            Y = recorido en vertical empezando de abajo hacia arriba.
            0 punto de partida 
            */
            //Fila 1
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "Hasta 25 años";
            dataGridView1[1, 0].Value = "ICF ≤ 2.0";
            dataGridView1[2, 0].Value = "2.1 ≤ ICF ≤ 3.5";
            dataGridView1[3, 0].Value = "3.6 ≤ ICF ≤ 5.0";
            dataGridView1[4, 0].Value = "ICF > 5.0";
            //Fila 2
            dataGridView1.Rows.Add();
            dataGridView1[0, 1].Value = "Hasta 26 años y 40 años";
            dataGridView1[1, 1].Value = "ICF ≤ 2.5";
            dataGridView1[2, 1].Value = "2.6 ≤ ICF ≤ 4.0";
            dataGridView1[3, 1].Value = "4.1 ≤ ICF ≤ 6.0";
            dataGridView1[4, 1].Value = "ICF > 6.0";
            //Fila 3
            dataGridView1.Rows.Add();
            dataGridView1[0, 2].Value = "Mas de 40 años";
            dataGridView1[1, 2].Value = "ICF ≤ 3.0";
            dataGridView1[2, 2].Value = "3.1 ≤ ICF ≤ 4.5";
            dataGridView1[3, 2].Value = "4.6 ≤ ICF ≤ 7.0";
            dataGridView1[4, 2].Value = "ICF > 7.0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            double run = Convert.ToDouble(textBox1.Text);
            double rep = Convert.ToDouble(textBox2.Text);
            double eda = Convert.ToDouble(textBox3.Text);
                double icf = 0;
                string condicion = "";

                {
                    if (run > 0 && eda > 0)
                    {
                        icf = (rep * run) / eda;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre 0.");
                        return;
                    }
                }
                if (eda <= 25)
                {
                    // Hasta 25 años primera fila.
                    if (icf <= 2.0)
                    {
                        condicion = "Excelente condición";
                        dataGridView1[1, 0].Style.BackColor = Color.LightGreen;
                    }
                    else if (icf <= 3.5)
                    {
                        condicion = "Buena condición";
                        dataGridView1[2, 0].Style.BackColor = Color.LightGreen;

                    }
                    else if (icf <= 5.0)
                    {
                        condicion = "Condición regular";
                        dataGridView1[3, 0].Style.BackColor = Color.LightGreen;

                    }
                    else
                    {
                        condicion = "Condición baja";
                        dataGridView1[4, 0].Style.BackColor = Color.LightGreen;

                    }
                }
                else if (eda >= 26 && eda <= 40)
                {
                    // Entre 26 y 40 años segunda fila
                    if (icf <= 2.5)
                    {
                        condicion = "Excelente condición";
                        dataGridView1[1, 1].Style.BackColor = Color.LightGreen;

                    }
                    else if (icf <= 4.0)
                    {
                        condicion = "Buena condición";
                        dataGridView1[2, 1].Style.BackColor = Color.LightGreen;

                    }
                    else if (icf <= 6.0)
                    {
                        condicion = "Condición regular";
                        dataGridView1[3, 1].Style.BackColor = Color.LightGreen;

                    }
                    else
                    {
                        condicion = "Condición baja";
                        dataGridView1[4, 1].Style.BackColor = Color.LightGreen;

                    }
                }
                else if (eda > 40)
                {
                    // Más de 40 años tercera fila
                    if (icf <= 3.0)
                    {
                        condicion = "Excelente condición";
                        dataGridView1[1, 2].Style.BackColor = Color.LightGreen;

                    }
                    else if (icf <= 4.5)
                    {
                        condicion = "Buena condición";
                        dataGridView1[2, 2].Style.BackColor = Color.LightGreen;

                    }
                    else if (icf <= 7.0)
                    {
                        condicion = "Condición regular";
                        dataGridView1[3, 2].Style.BackColor = Color.LightGreen;

                    }
                    else
                    {
                        condicion = "Condición baja";
                        dataGridView1[4, 2].Style.BackColor = Color.LightGreen;

                    }
                }

                MessageBox.Show(" El usuario con una edad: " + eda+ " años"+
                    "\n Tiene un indice de Condición Física de " + icf + " Y su " + condicion);

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce números válidos en los campos.");
            }

        }
    }
}
