namespace Actividad_2
{
    partial class FormEliminarImagenes
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pbxImagenes = new System.Windows.Forms.PictureBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.labelEliminarImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(336, 278);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(182, 42);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(148, 278);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(182, 42);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Eliminar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pbxImagenes
            // 
            this.pbxImagenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagenes.Location = new System.Drawing.Point(336, 38);
            this.pbxImagenes.Name = "pbxImagenes";
            this.pbxImagenes.Size = new System.Drawing.Size(313, 234);
            this.pbxImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenes.TabIndex = 15;
            this.pbxImagenes.TabStop = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(16, 38);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(314, 234);
            this.dgvArticulos.TabIndex = 14;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // labelEliminarImg
            // 
            this.labelEliminarImg.AutoSize = true;
            this.labelEliminarImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarImg.Location = new System.Drawing.Point(11, 9);
            this.labelEliminarImg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEliminarImg.Name = "labelEliminarImg";
            this.labelEliminarImg.Size = new System.Drawing.Size(240, 26);
            this.labelEliminarImg.TabIndex = 18;
            this.labelEliminarImg.Text = "Seleccione la imagen";
            // 
            // FormEliminarImagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 342);
            this.Controls.Add(this.labelEliminarImg);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pbxImagenes);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(685, 381);
            this.MinimumSize = new System.Drawing.Size(685, 381);
            this.Name = "FormEliminarImagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEliminarImagenes";
            this.Load += new System.EventHandler(this.FormEliminarImagenes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pbxImagenes;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label labelEliminarImg;
    }
}