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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolverEditarCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEditarCategoria
            // 
            this.textBoxEditarCategoria.Location = new System.Drawing.Point(44, 115);
            this.textBoxEditarCategoria.Name = "textBoxEditarCategoria";
            this.textBoxEditarCategoria.Size = new System.Drawing.Size(168, 22);
            this.textBoxEditarCategoria.TabIndex = 0;
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Location = new System.Drawing.Point(241, 115);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(113, 43);
            this.btnEditarCategoria.TabIndex = 1;
            this.btnEditarCategoria.Text = "Confirmar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(310, 177);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnVolverEditarCategoria
            // 
            this.btnVolverEditarCategoria.Location = new System.Drawing.Point(241, 423);
            this.btnVolverEditarCategoria.Name = "btnVolverEditarCategoria";
            this.btnVolverEditarCategoria.Size = new System.Drawing.Size(113, 43);
            this.btnVolverEditarCategoria.TabIndex = 3;
            this.btnVolverEditarCategoria.Text = "Volver";
            this.btnVolverEditarCategoria.UseVisualStyleBackColor = true;
            this.btnVolverEditarCategoria.Click += new System.EventHandler(this.btnVolverEditarCategoria_Click);
            // 
            // FormEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 503);
            this.Controls.Add(this.btnVolverEditarCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEditarCategoria);
            this.Controls.Add(this.textBoxEditarCategoria);
            this.Location = new System.Drawing.Point(251, 126);
            this.MaximumSize = new System.Drawing.Size(441, 550);
            this.MinimumSize = new System.Drawing.Size(441, 550);
            this.Name = "FormEditarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEditarCategoria;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolverEditarCategoria;
    }
}