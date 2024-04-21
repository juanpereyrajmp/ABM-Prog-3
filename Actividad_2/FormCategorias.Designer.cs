namespace Actividad_2
{
    partial class FormCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(16, 16);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(155, 50);
            this.btnAgregarCategoria.TabIndex = 5;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(16, 73);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(155, 50);
            this.btnModificarCategoria.TabIndex = 6;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(16, 130);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(155, 50);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(344, 401);
            this.dataGridView1.TabIndex = 8;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.MaximumSize = new System.Drawing.Size(695, 477);
            this.MinimumSize = new System.Drawing.Size(695, 477);
            this.Name = "FormCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}