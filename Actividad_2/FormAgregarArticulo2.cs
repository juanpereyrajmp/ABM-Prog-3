using dominio;
using manager;
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
    public partial class FormAgregarArticulo2 : Form
    {

        private Articulo articulo = null;
        //private Image image = null;
        public FormAgregarArticulo2()
        {
            InitializeComponent();
        }

        private void btnAgregarImagenes_Click(object sender, EventArgs e)
        {
           ArticuloManager manager = new ArticuloManager();
           //ArticuloManager imagenes = new ArticuloManager();
        

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = textBoxCodAg2.Text;
                articulo.Nombre = textBoxNomAg2.Text;
                articulo.Descripcion = textBoxDesAg2.Text;
                articulo.Precio = decimal.Parse(textBoxPreAg2.Text);
                articulo.Marca = (Marca)comboBoxMarcaAg2.SelectedItem;
                articulo.Categoria = (Categoria)comboBoxCatAg2.SelectedItem;

                manager.AgregarArticulo(articulo);
                //imagenes.agregarImagen(articulo);
                MessageBox.Show("Articulo agregado con éxito");
                
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAgregarArticulo2_Load(object sender, EventArgs e)
        {
            MarcaManager marcaManager = new MarcaManager();
            CategoriaManager categoriaManager = new CategoriaManager();

            try
            {
                comboBoxMarcaAg2.DataSource = marcaManager.ListarMarcas();
                comboBoxMarcaAg2.ValueMember = "Id";
                comboBoxMarcaAg2.DisplayMember = "Descripcion";
                comboBoxCatAg2.DataSource = categoriaManager.listar();
                comboBoxCatAg2.ValueMember = "Id";
                comboBoxCatAg2.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    textBoxCodAg2.Text = articulo.Codigo;
                    textBoxNomAg2.Text = articulo.Nombre;
                    textBoxDesAg2.Text = articulo.Descripcion;
                    textBoxPreAg2.Text = articulo.Precio.ToString();
                    //cargarImagen(articulo.Imagenes[0].Url);
                    comboBoxMarcaAg2.SelectedValue = articulo.Marca.Id;
                    comboBoxCatAg2.SelectedValue = articulo.Categoria.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
