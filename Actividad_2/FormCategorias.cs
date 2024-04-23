using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {

        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CategoriaManager categoria = new CategoriaManager();
            dgdCategorias.DataSource = categoria.listar();
            
        }
    }
}
