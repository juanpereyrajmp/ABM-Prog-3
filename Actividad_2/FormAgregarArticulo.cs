using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using manager;

namespace Actividad_2
{
    public partial class FormAgregarArticulo : Form
    {
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            ArticuloManager manager = new ArticuloManager();
            Imagen nuevaImagen = new Imagen();

            try
            {
                nuevoArticulo.Codigo = txtBoxCodigo.Text;
                nuevoArticulo.Nombre = txtBoxNombre.Text;
                nuevoArticulo.Descripcion = txtBoxDescripcion.Text;
                nuevoArticulo.Precio = decimal.Parse(txtBoxPrecio.Text);
                nuevoArticulo.Imagen = txtBoxImagen.Text;
                nuevoArticulo.Marca = (Marca)cboMarca.SelectedItem;
                nuevoArticulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                manager.AgregarArticulo(nuevoArticulo);
                MessageBox.Show("Articulo agregado con éxito");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaManager marcaManager = new MarcaManager();
            CategoriaManager categoriaManager = new CategoriaManager();

            try
            {
                cboMarca.DataSource = marcaManager.ListarMarcas();
                cboCategoria.DataSource = categoriaManager.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
            }
        }
    }
}
