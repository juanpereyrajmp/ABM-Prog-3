using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_2;
using dominio;
using manager;

namespace Actividad_2
{
    public partial class FormEditarMarca : Form
    {
        private List<Marca> listaMarcas;
        private Marca seleccionada;
        public FormEditarMarca()
        {
            InitializeComponent();
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            MarcaManager adminMarcas = new MarcaManager();
            
            seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            txtMarca.Text = seleccionada.Descripcion;
        }

        private void FormEditarMarca_Load(object sender, EventArgs e)
        {
               MarcaManager adminMarcas = new MarcaManager();
               listaMarcas = adminMarcas.ListarMarcas();
               dgvMarcas.DataSource = listaMarcas;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Marca nuevaMarca = new Marca();
            MarcaManager adminMarcas = new MarcaManager();

            ArticuloManager articuloManager = new ArticuloManager();
            List<Articulo> listaArticulos = articuloManager.ListarArticulos();

            string descripcion;

            try
            {
                descripcion = txtMarca.Text;
                if (descripcion == "")
                {
                    MessageBox.Show("El campo no puede estar vacio");
                }
                else
                {
                    bool validar = listaArticulos.Any(item => item.Marca.Descripcion == descripcion);

                    if (validar)
                    {
                        MessageBox.Show("Ya existe esa marca");
                    }
                    else
                    {
                        seleccionada.Descripcion = descripcion;
                        adminMarcas.editarMarca(seleccionada);
                        MessageBox.Show("Se actualizó la marca");
                        listaMarcas = adminMarcas.ListarMarcas();
                        dgvMarcas.DataSource = listaMarcas;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

