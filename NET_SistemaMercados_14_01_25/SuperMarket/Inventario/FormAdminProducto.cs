using Logica.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket.Inventario
{
    public partial class FormAdminProducto : Form
    {
        public FormAdminProducto()
        {
            InitializeComponent();
        }



        ProductoLN pln = new ProductoLN();
        public void Listar()
        {
            dataGridView1.DataSource = pln.ViewProducto();
        }

        private void FormAdminProducto_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
