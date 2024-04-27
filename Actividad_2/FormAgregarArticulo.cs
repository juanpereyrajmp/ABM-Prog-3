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
        private bool validarVacio(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return true;
            }
            return false;
        }
        private bool validarNegativo(decimal num)
        {
            
            if(num < 0)
            {
                return true;
            }
            return false;
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
            ArticuloManager imagenes = new ArticuloManager();

            try
            {
                if(articulo == null)
                {
                    articulo = new Articulo();
                }

                /*if(validarVacio(txtBoxCodigo.Text))
                {
                    MessageBox.Show("El Codigo no puede estar vacio");
                }*/
                articulo.Codigo = txtBoxCodigo.Text;
                articulo.Codigo = txtBoxCodigo.Text;
                articulo.Codigo = txtBoxCodigo.Text;
                articulo.Nombre = txtBoxNombre.Text;
                articulo.Descripcion = txtBoxDescripcion.Text;
                /*if (validarNegativo(decimal.Parse(txtBoxPrecio.Text)))
                {
                    MessageBox.Show("El Precio no puede ser Negativo");
                    Close();
                }*/
                articulo.Precio = decimal.Parse(txtBoxPrecio.Text);
                articulo.Imagen = (string)txtBoxImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if(articulo.Id != 0 && validarVacio(txtBoxCodigo.Text))
                {
                    manager.ModificarArticulo(articulo);
                    imagenes.modificarImagenArticulo(articulo);
                    MessageBox.Show("Articulo modificado con éxito");

                }
                else if ((validarVacio(txtBoxCodigo.Text)))
                    {
                    MessageBox.Show("El Codigo no puede estar vacio - Vuelva a Agregar el Articulo");
                    }
                    else if (validarNegativo(decimal.Parse(txtBoxPrecio.Text)))
                    {
                     MessageBox.Show("El Precio no puede ser Negativo - Vuela a Agregar el Articulo");

                    }

                else
                   {
                    manager.AgregarArticulo(articulo);
                    imagenes.agregarImagen(articulo);
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
                //pbxArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
                pbxArticulo.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }
    }
}
