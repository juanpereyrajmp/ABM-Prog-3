using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using manager;

namespace Actividad_2
{
    public partial class FormEliminarCategoria : Form
    {
        public FormEliminarCategoria()
        {
            InitializeComponent();
        }

        private void btnVolverEliminarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEliminarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaManager adminCategorias = new CategoriaManager();
            List<Categoria> listaCategoria = adminCategorias.listar();
            dgvEliminarCategoria.DataSource = listaCategoria;
        }
    }
}
