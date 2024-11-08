using System;
using System.Windows.Forms;

namespace PA_TH_TAREA_N2_PZ
{
    public partial class FrmEdit2 : Form
    {
        public FrmEdit2()
        {
            InitializeComponent();
        }

        //AGREGAR
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso para agregar.");
                return;
            }

            // Obtener el curso seleccionado
            string cursoSeleccionado = listBox1.SelectedItem.ToString();

            // Obtener el precio correspondiente al curso
            double precio = ObtenerPrecio(cursoSeleccionado);

            // Agregar el curso a listBox4 (cursos seleccionados)
            listBox4.Items.Add(cursoSeleccionado);

            // Agregar el precio a listBox3 (precios de cursos seleccionados)
            listBox3.Items.Add(precio);

            // Eliminar el curso de listBox1
            listBox1.Items.Remove(cursoSeleccionado);

            // Eliminar el precio de listBox2 (que es el precio del curso seleccionado)
            listBox2.Items.Remove(precio);
        }



        // Eliminar
 private void button5_Click(object sender, EventArgs e)
{
    if (listBox4.SelectedItem == null)
    {
        MessageBox.Show("Seleccione un curso para eliminar.");
        return;
    }

    // Obtener el curso a eliminar
    string cursoAEliminar = listBox4.SelectedItem.ToString();
    
    // Obtener el precio correspondiente al curso
    double precio = ObtenerPrecio(cursoAEliminar);

    // Eliminar el curso de listBox4
    listBox4.Items.Remove(cursoAEliminar);

    // Eliminar el precio de listBox3
    listBox3.Items.Remove(precio);

    // Agregar el curso de nuevo a listBox1
    listBox1.Items.Add(cursoAEliminar);

    // Agregar el precio de nuevo a listBox2
    listBox2.Items.Add(precio);
}




        // Cancelar
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Guardar
        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Seleccione un método de pago.");
                return;
            }

            CalcularTotales();
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cerrar el formulario después de guardar
        }

        public void SetDatos(Cursos cur)
        {
            textBox1.Text = cur.Nombre;
            textBox3.Text = cur.Descuento.ToString("F2");
            textBox4.Text = cur.Incremento.ToString("F2");
            textBox5.Text = cur.Total.ToString("F2");

            // Ajustar el estado del RadioButton según el tipo
            if (cur.Fpago == "Contado") radioButton1.Checked = true;
            else if (cur.Fpago == "Credito") radioButton2.Checked = true;
        }

        public Cursos CrearObjeto()
        {
            string nom = textBox1.Text;
            double ncur = listBox3.Items.Count; // Cantidad de cursos seleccionados
            double des = ValidarDouble(textBox4.Text);
            double inc = ValidarDouble(textBox3.Text);
            string fpago = radioButton1.Checked ? "Contado" : "Credito";
            double subtotal = ValidarDouble(textBox5.Text);
            double total = subtotal + inc - des;

            return new Cursos(nom, ncur, fpago, des, inc, subtotal, total);
        }


        private double ValidarDouble(string texto)
        {
            return double.TryParse(texto, out double resultado) ? resultado : 0;
        }

        private void CalcularTotales()
        {
            double subtotal = 0;
            double descuento = 0;
            double incremento = 0;

            foreach (var item in listBox3.Items)
            {
                subtotal += Convert.ToDouble(item);
            }

            textBox5.Text = subtotal.ToString("F2"); // Actualizar el textbox del subtotal

            double total = subtotal; // Inicializar total con el subtotal

            if (radioButton2.Checked) // Crédito
            {
                incremento = subtotal * 0.07;
                total += incremento; // Sumar incremento al total
                textBox3.Text = incremento.ToString("F2");
            }

            if (radioButton1.Checked) // Contado
            {
                descuento = subtotal * 0.05;
                total -= descuento; // Restar descuento al total
                textBox4.Text = descuento.ToString("F2");
            }

            textBox5.Text = total.ToString("F2"); // Actualizar el textbox del total
        }



        private void FrmEdit2_Load(object sender, EventArgs e)
        {
            // Cursos
            listBox1.Items.AddRange(new object[]
            {
                "AI Boot Camp",
                "Curso de programación",
                "Curso de algoritmos",
                "Curso de Power BI",
                "Curso de Scrum"
            });

            // Precios
            listBox2.Items.AddRange(new object[]
            {
                350,
                1000,
                150,
                150,
                250
            });
        }

        private double ObtenerPrecio(string curso)
        {
            if (curso == "AI Boot Camp") return 350;
            else if (curso == "Curso de programación") return 1000;
            else if (curso == "Curso de algoritmos") return 150;
            else if (curso == "Curso de Power BI") return 150;
            else if (curso == "Curso de Scrum") return 250;
            else return 0; // Valor por defecto si no coincide con ninguno
        }
    }
}
