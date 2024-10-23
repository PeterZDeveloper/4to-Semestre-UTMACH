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

namespace PA_Intra_N1_2_Boletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            dataGridView1[0, 0].Value = "Ciudad A";
            dataGridView1[1, 0].Value = "$ 50";
            dataGridView1[2, 0].Value = "$ 70";
            dataGridView1[3, 0].Value = "$ 90";
            //Fila 2
            dataGridView1.Rows.Add();
            dataGridView1[0, 1].Value = "Ciudad B";
            dataGridView1[1, 1].Value = "$ 40";
            dataGridView1[2, 1].Value = "$ 60";
            dataGridView1[3, 1].Value = "$ 80";
            //Fila 3
            dataGridView1.Rows.Add();
            dataGridView1[0, 2].Value = "Ciudad C";
            dataGridView1[1, 2].Value = "$ 30";
            dataGridView1[2, 2].Value = "$ 50";
            dataGridView1[3, 2].Value = "$ 70";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
            string vag = comboBox1.SelectedItem.ToString();
            double bol = Convert.ToDouble(textBox1.Text);
            string city = " ";
                double precioBase = 0;
                double precioFinal = 0;
                double recargo = 0;

                if (radioButton1.Checked)
            {
                city = "A";
                if (comboBox1.SelectedItem.Equals("Turista"))
                {
                    dataGridView1[1, 0].Style.BackColor = Color.LightGreen;
                        precioFinal = bol * 50;
                }
                else if (comboBox1.SelectedItem.Equals("Preferente"))
                {
                    dataGridView1[2, 0].Style.BackColor = Color.LightGreen;
                        precioBase =  70;
                        recargo = precioBase * 0.10;
                        precioFinal = (precioBase + recargo) * bol;


                    }
                    else if (comboBox1.SelectedItem.Equals("VIP"))
                {
                    dataGridView1[3, 0].Style.BackColor = Color.LightGreen;
                        precioBase = 90;
                        recargo = precioBase * 0.20; 
                        precioFinal = (precioBase + recargo) * bol;
                    }
            }
                else if (radioButton2.Checked)
                {
                    if (comboBox1.SelectedItem.Equals("Turista"))
                    {
                        dataGridView1[1, 1].Style.BackColor = Color.LightGreen;
                        precioFinal = bol * 40;
                    }
                    else if (comboBox1.SelectedItem.Equals("Preferente"))
                    {
                        dataGridView1[2, 1].Style.BackColor = Color.LightGreen;
                        precioBase =  60;
                        recargo = precioBase * 0.20;
                        precioFinal = (precioBase + recargo) * bol;
                    }
                    else if (comboBox1.SelectedItem.Equals("VIP"))
                    {
                        dataGridView1[3, 1].Style.BackColor = Color.LightGreen;
                        precioBase =  80;
                        recargo = precioBase * 0.20;
                        precioFinal = (precioBase + recargo) * bol;
                    }
                }
                else if (radioButton3.Checked)
                    {
                        if (comboBox1.SelectedItem.Equals("Turista"))
                        {
                            dataGridView1[1, 2].Style.BackColor = Color.LightGreen;
                            precioFinal = bol * 30;
                        }
                        else if (comboBox1.SelectedItem.Equals("Preferente"))
                        {
                            dataGridView1[2, 2].Style.BackColor = Color.LightGreen;
                            precioBase =  50;
                            recargo = precioBase * 0.20;
                            precioFinal = (precioBase + recargo) * bol;
                        }
                        else if (comboBox1.SelectedItem.Equals("VIP"))
                        {
                            dataGridView1[3, 2].Style.BackColor = Color.LightGreen;
                            precioBase = 70;
                            recargo = precioBase * 0.20;
                            precioFinal = (precioBase + recargo) * bol;
                        }
                    }
                    // Aplicar 10% de descuento si los boletos son igual o mayor a 4
                    if (bol >= 4)
                {
                    precioFinal *= 0.90; 
                }

                MessageBox.Show("El pasajero ha seleccionado el vagon: " + vag
                + "\n Y se ha comprado: " + bol + " boleto"
                + "\n Con destino a la Ciudad: " + city
                +"\n El precio total es de: $" + precioFinal);

                }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introduce un número válido en la cantidad de boletos.");
            }
        }
        
   
    }
}
