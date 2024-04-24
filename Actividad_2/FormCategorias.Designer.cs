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
            this.btnAgregarCategoria.Location = new System.Drawing.Point(111, 86);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(155, 50);
            this.btnAgregarCategoria.TabIndex = 5;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(111, 144);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(155, 50);
            this.btnModificarCategoria.TabIndex = 6;
            this.btnModificarCategoria.Text = "Modificar Categoria";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(111, 202);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(155, 50);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar Categoria";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // dgdCategorias
            // 
            this.dgdCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCategorias.Location = new System.Drawing.Point(585, 86);
            this.dgdCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdCategorias.Name = "dgdCategorias";
            this.dgdCategorias.RowHeadersWidth = 51;
            this.dgdCategorias.Size = new System.Drawing.Size(344, 401);
            this.dgdCategorias.TabIndex = 8;
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 586);
            this.Controls.Add(this.dgdCategorias);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1163, 633);
            this.MinimumSize = new System.Drawing.Size(1163, 633);
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