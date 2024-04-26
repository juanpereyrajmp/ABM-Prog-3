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
            try
            {
                nuevoArticulo.Codigo = txtBoxCodigo.Text;
                nuevoArticulo.Nombre = txtBoxNombre.Text;
                nuevoArticulo.Descripcion = txtBoxDescripcion.Text;
                nuevoArticulo.Precio = decimal.Parse(txtBoxPrecio.Text);
                nuevoArticulo.Imagen = txtBoxImagen.Text;

                manager.AgregarArticulo(nuevoArticulo);
                MessageBox.Show("Articulo agregado con éxito");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
