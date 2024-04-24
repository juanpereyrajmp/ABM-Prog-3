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
            this.dgvEliminarCategoria.Location = new System.Drawing.Point(53, 66);
            this.dgvEliminarCategoria.Name = "dgvEliminarCategoria";
            this.dgvEliminarCategoria.RowHeadersWidth = 51;
            this.dgvEliminarCategoria.RowTemplate.Height = 24;
            this.dgvEliminarCategoria.Size = new System.Drawing.Size(380, 283);
            this.dgvEliminarCategoria.TabIndex = 0;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(571, 113);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(114, 48);
            this.btnEliminarCategoria.TabIndex = 1;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnVolverEliminarCategoria
            // 
            this.btnVolverEliminarCategoria.Location = new System.Drawing.Point(571, 237);
            this.btnVolverEliminarCategoria.Name = "btnVolverEliminarCategoria";
            this.btnVolverEliminarCategoria.Size = new System.Drawing.Size(114, 44);
            this.btnVolverEliminarCategoria.TabIndex = 2;
            this.btnVolverEliminarCategoria.Text = "Volver";
            this.btnVolverEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnVolverEliminarCategoria.Click += new System.EventHandler(this.btnVolverEliminarCategoria_Click);
            // 
            // FormEliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverEliminarCategoria);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.dgvEliminarCategoria);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormEliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEliminarCategoria";
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