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
    public partial class frmAdminCategoria : Form
    {
        public frmAdminCategoria()
        {
            InitializeComponent();
        }
        CategoriaLN oln= new CategoriaLN();
         public void Listar()
         {
            dataGridView1.DataSource = oln.ViewCategoria();
         }
        private void frmAdminCategoria_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
