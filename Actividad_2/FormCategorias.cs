﻿using System;
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
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
        }

        //private void btnModificarMarca_Click(object sender, EventArgs e)
        //{

        //}

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            CategoriaManager categoria = new CategoriaManager();
            dgdCategorias.DataSource = categoria.listar();
            
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            FormAltaCategoria alta = new FormAltaCategoria();
            alta.ShowDialog();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
           // FormEliminarCategoria formEliminarCategoria = new FormEliminarCategoria();
           // formEliminarCategoria.ShowDialog();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            FormEliminarCategoria formEliminarCategoria = new FormEliminarCategoria();
            formEliminarCategoria.ShowDialog();
        }
    }
}
