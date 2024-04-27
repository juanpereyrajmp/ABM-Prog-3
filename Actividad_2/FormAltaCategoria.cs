﻿using dominio;
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
    public partial class FormAltaCategoria : Form
    {
        public FormAltaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Categoria categoria = new Categoria();
            CategoriaManager manager = new CategoriaManager();
            List<Categoria> lista = new List<Categoria>();

            lista = manager.listar();
            try
            {
                categoria.Descripcion = textBoxCategoria.Text;
                if (categoria.Descripcion == "")
                {
                    MessageBox.Show("El campo no puede estar vacio");
                }
                else
                {
                    if(!lista.Any(m => m.Descripcion.Equals(categoria.Descripcion, StringComparison.OrdinalIgnoreCase)))
                            {
                        manager.agregar(categoria);
                        MessageBox.Show("Agregada");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Esa Categoria ya existe");
                    }
                }
                //manager.agregar(categoria);
               // MessageBox.Show("Agregado exitosamente");
               // Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
