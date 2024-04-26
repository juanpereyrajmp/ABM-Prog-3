using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Actividad_2
{
    public partial class Form1 : Form
    {
        
        //private Button currentButton;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void OppenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPrincipalDesktop.Controls.Add(childForm);
            this.panelPrincipalDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            OppenChildForm(new FormArticulos(), sender);

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            OppenChildForm(new FormCategorias(), sender);
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            OppenChildForm(new FormMarcas(), sender);
        }

       
    }
}
