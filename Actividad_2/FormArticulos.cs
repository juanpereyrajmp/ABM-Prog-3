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
    public partial class FormArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public FormArticulos()
        {
            InitializeComponent();
        }

        private void FormArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloManager articuloManager = new ArticuloManager();

            try
            {
                listaArticulo = articuloManager.ListarArticulos();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["Imagen"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                cargarImagen(listaArticulo[0].Imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
               picBoxArticulos.Load(imagen);  
            }
            catch (Exception)
            {
                //picBoxArticulos.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
                picBoxArticulos.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            //listaFiltrada = listaArticulo.FindAll(x => x.Nombre == textBoxFiltro.Text);
            string filtro = textBoxFiltro.Text;

            if(filtro.Length >= 1)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            }
            else 
            {
                listaFiltrada = listaArticulo;
            }

            //dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo nuevoArticulo = new FormAgregarArticulo();
            nuevoArticulo.ShowDialog();
            cargar();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {

            Articulo seleccion;
            seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormAgregarArticulo modificarArticulo = new FormAgregarArticulo(seleccion);
            modificarArticulo.ShowDialog();
            cargar();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccion.Imagen);
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

            ArticuloManager manager = new ArticuloManager();

            Articulo seleccion;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro querés eliminar el articulo seleccionado?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    manager.EliminarArticulo(seleccion.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            FormAgregarImagen formAgregarImagen = new FormAgregarImagen();
            formAgregarImagen.ShowDialog();
        }
    }
}
