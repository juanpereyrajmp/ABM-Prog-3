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

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            Categoria seleccionada = (Categoria)dgvEliminarCategoria.CurrentRow.DataBoundItem;

            ArticuloManager articuloManager = new ArticuloManager();
            CategoriaManager categoriamanager = new CategoriaManager();

            List<Articulo> listaArticulos = articuloManager.ListarArticulos();


            bool enUso = listaArticulos.Any(item => item.Categoria.Descripcion == seleccionada.Descripcion);
            //bool enUso = listaArticulos.Any(item => item.Categoria.Id == seleccionada.Id);

            if (!enUso)
            {
                categoriamanager.eliminarCategoria(seleccionada.Id);
                MessageBox.Show("Categoria eliminada correctamente");
            }
            else
            {
                MessageBox.Show("No se puede eliminar una categoria en uso");
            }

            List<Categoria> listaCategoria = categoriamanager.listar();
            dgvEliminarCategoria.DataSource = listaCategoria;
        }
    }
}
