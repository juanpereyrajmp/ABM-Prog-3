﻿using System;
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
            ArticuloManager articuloManager = new ArticuloManager();
            listaArticulo = articuloManager.ListarArticulos();
            dgvArticulos.DataSource = articuloManager.ListarArticulos();
            cargarImagen(listaArticulo[0].Imagen);
            
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
               picBoxArticulos.Load(imagen);  
            }
            catch (Exception ex)
            {
                //picBoxArticulos.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
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

            dgvArticulos.DataSource= null;
            dgvArticulos.DataSource = listaFiltrada;

            

        }
    }
}
