namespace Actividad_2
{
    partial class FormEditarCategoria
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
            this.textBoxEditarCategoria = new System.Windows.Forms.TextBox();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.dgvEditarCategoria = new System.Windows.Forms.DataGridView();
            this.btnVolverEditarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEditarCategoria
            // 
            this.textBoxEditarCategoria.Location = new System.Drawing.Point(20, 84);
            this.textBoxEditarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEditarCategoria.Name = "textBoxEditarCategoria";
            this.textBoxEditarCategoria.Size = new System.Drawing.Size(166, 20);
            this.textBoxEditarCategoria.TabIndex = 0;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Location = new System.Drawing.Point(248, 84);
            this.btnEditarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(85, 35);
            this.btnEditarCategoria.TabIndex = 1;
            this.btnEditarCategoria.Text = "Confirmar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // dgvEditarCategoria
            // 
            this.dgvEditarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditarCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEditarCategoria.Location = new System.Drawing.Point(20, 141);
            this.dgvEditarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEditarCategoria.MultiSelect = false;
            this.dgvEditarCategoria.Name = "dgvEditarCategoria";
            this.dgvEditarCategoria.RowHeadersWidth = 51;
            this.dgvEditarCategoria.RowTemplate.Height = 24;
            this.dgvEditarCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditarCategoria.Size = new System.Drawing.Size(313, 197);
            this.dgvEditarCategoria.TabIndex = 2;
            this.dgvEditarCategoria.SelectionChanged += new System.EventHandler(this.dgvEditarCategoria_SelectionChanged);
            // 
            // btnVolverEditarCategoria
            // 
            this.btnVolverEditarCategoria.Location = new System.Drawing.Point(248, 362);
            this.btnVolverEditarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverEditarCategoria.Name = "btnVolverEditarCategoria";
            this.btnVolverEditarCategoria.Size = new System.Drawing.Size(85, 35);
            this.btnVolverEditarCategoria.TabIndex = 3;
            this.btnVolverEditarCategoria.Text = "Volver";
            this.btnVolverEditarCategoria.UseVisualStyleBackColor = true;
            this.btnVolverEditarCategoria.Click += new System.EventHandler(this.btnVolverEditarCategoria_Click);
            // 
            // FormEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 439);
            this.Controls.Add(this.btnVolverEditarCategoria);
            this.Controls.Add(this.dgvEditarCategoria);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.textBoxEditarCategoria);
            this.Location = new System.Drawing.Point(251, 126);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(335, 454);
            this.Name = "FormEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar categoría";
            this.Load += new System.EventHandler(this.FormEditarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.DataGridView dgvEditarCategoria;
        private System.Windows.Forms.Button btnVolverEditarCategoria;
    }
}