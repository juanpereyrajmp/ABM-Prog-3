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
        private Articulo articulo = null;
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        public FormAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloManager manager = new ArticuloManager();

            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtBoxCodigo.Text;
                articulo.Nombre = txtBoxNombre.Text;
                articulo.Descripcion = txtBoxDescripcion.Text;
                articulo.Precio = decimal.Parse(txtBoxPrecio.Text);
                articulo.Imagen = txtBoxImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if(articulo.Id != 0)
                {
                    manager.ModificarArticulo(articulo);
                    MessageBox.Show("Articulo modificado con éxito");

                }
                else
                {
                    manager.AgregarArticulo(articulo);
                    MessageBox.Show("Articulo agregado con éxito");
                }
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
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaManager.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtBoxCodigo.Text = articulo.Codigo;
                    txtBoxNombre.Text = articulo.Nombre;
                    txtBoxDescripcion.Text = articulo.Descripcion;
                    txtBoxPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.Imagen);
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }
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
