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
    public partial class FormEditarCategoria : Form
    {
        public FormEditarCategoria()
        {
            InitializeComponent();
        }

        private void btnVolverEditarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
