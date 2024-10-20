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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string extraIngredient = textBox1.Text;
            int cost = extraIngredient.Length * 2; // Cada carácter suma 2€
            textBox2.Text = cost.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string extraIngredient = textBox1.Text + " (extra)";
            int cost = int.Parse(textBox2.Text);

            // Acceder a Form1 y agregar el ingrediente extra
            Form1 mainForm = (Form1)this.Owner;
           // mainForm.listBox2.Items.Add(extraIngredient + " - " + cost.ToString() + "USD");
            this.Close(); // Cerrar Form2
        }
    }
}
