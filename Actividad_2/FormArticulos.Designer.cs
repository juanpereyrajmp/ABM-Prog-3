namespace Actividad_2
{
    partial class FormArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.picBoxArticulos = new System.Windows.Forms.PictureBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 66);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(571, 317);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(398, 411);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(182, 42);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(204, 411);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(182, 42);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar Articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(10, 411);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(182, 42);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // picBoxArticulos
            // 
            this.picBoxArticulos.Location = new System.Drawing.Point(598, 66);
            this.picBoxArticulos.Name = "picBoxArticulos";
            this.picBoxArticulos.Size = new System.Drawing.Size(250, 250);
            this.picBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxArticulos.TabIndex = 7;
            this.picBoxArticulos.TabStop = false;
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltro.Location = new System.Drawing.Point(65, 31);
            this.labelFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(115, 16);
            this.labelFiltro.TabIndex = 8;
            this.labelFiltro.Text = "Filtrar por Nombre";
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(184, 31);
            this.textBoxFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(285, 20);
            this.textBoxFiltro.TabIndex = 0;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar imagenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Location = new System.Drawing.Point(598, 322);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(95, 23);
            this.btnImagenAnterior.TabIndex = 10;
            this.btnImagenAnterior.Text = "Imagen anterior";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(753, 322);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(95, 23);
            this.btnImagenSiguiente.TabIndex = 11;
            this.btnImagenSiguiente.Text = "Imagen siguiente";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarImg.Location = new System.Drawing.Point(636, 399);
            this.btnEliminarImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(182, 30);
            this.btnEliminarImg.TabIndex = 12;
            this.btnEliminarImg.Text = "Eliminar Imagenes";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 482);
            this.Controls.Add(this.btnEliminarImg);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.picBoxArticulos);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(876, 521);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(876, 521);
            this.Name = "FormArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.PictureBox picBoxArticulos;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Button btnEliminarImg;
    }
}