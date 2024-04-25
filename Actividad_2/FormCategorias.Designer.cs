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
            this.dgdCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(83, 70);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(116, 41);
            this.btnAgregarCategoria.TabIndex = 5;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(83, 117);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(116, 41);
            this.btnModificarCategoria.TabIndex = 6;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(83, 164);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(116, 41);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // dgdCategorias
            // 
            this.dgdCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgdCategorias.Location = new System.Drawing.Point(439, 70);
            this.dgdCategorias.MultiSelect = false;
            this.dgdCategorias.Name = "dgdCategorias";
            this.dgdCategorias.RowHeadersWidth = 51;
            this.dgdCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdCategorias.Size = new System.Drawing.Size(258, 326);
            this.dgdCategorias.TabIndex = 8;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 483);
            this.Controls.Add(this.dgdCategorias);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(876, 522);
            this.MinimumSize = new System.Drawing.Size(876, 522);
            this.Name = "FormCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorías";
            this.Load += new System.EventHandler(this.FormCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.DataGridView dgdCategorias;
    }
}