namespace Actividad_2
{
    partial class FormEliminarCategoria
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
            this.dgvEliminarCategoria = new System.Windows.Forms.DataGridView();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnVolverEliminarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEliminarCategoria
            // 
            this.dgvEliminarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEliminarCategoria.Location = new System.Drawing.Point(40, 54);
            this.dgvEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEliminarCategoria.MultiSelect = false;
            this.dgvEliminarCategoria.Name = "dgvEliminarCategoria";
            this.dgvEliminarCategoria.RowHeadersWidth = 51;
            this.dgvEliminarCategoria.RowTemplate.Height = 24;
            this.dgvEliminarCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminarCategoria.Size = new System.Drawing.Size(285, 230);
            this.dgvEliminarCategoria.TabIndex = 0;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(428, 92);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(86, 39);
            this.btnEliminarCategoria.TabIndex = 1;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnVolverEliminarCategoria
            // 
            this.btnVolverEliminarCategoria.Location = new System.Drawing.Point(428, 193);
            this.btnVolverEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverEliminarCategoria.Name = "btnVolverEliminarCategoria";
            this.btnVolverEliminarCategoria.Size = new System.Drawing.Size(86, 36);
            this.btnVolverEliminarCategoria.TabIndex = 2;
            this.btnVolverEliminarCategoria.Text = "Volver";
            this.btnVolverEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnVolverEliminarCategoria.Click += new System.EventHandler(this.btnVolverEliminarCategoria_Click);
            // 
            // FormEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.btnVolverEliminarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.dgvEliminarCategoria);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "FormEliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar categoria";
            this.Load += new System.EventHandler(this.FormEliminarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEliminarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnVolverEliminarCategoria;
    }
}