namespace Actividad_2
{
    partial class FormAltaCategoria
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
            this.labelDescpCategoria = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescpCategoria
            // 
            this.labelDescpCategoria.AutoSize = true;
            this.labelDescpCategoria.Location = new System.Drawing.Point(72, 160);
            this.labelDescpCategoria.Name = "labelDescpCategoria";
            this.labelDescpCategoria.Size = new System.Drawing.Size(79, 16);
            this.labelDescpCategoria.TabIndex = 0;
            this.labelDescpCategoria.Text = "Descripcion";
            this.labelDescpCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(180, 154);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(100, 22);
            this.textBoxCategoria.TabIndex = 1;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(76, 246);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 30);
            this.btnAgregarCategoria.TabIndex = 2;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Location = new System.Drawing.Point(201, 246);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(79, 30);
            this.btnCancelarCategoria.TabIndex = 3;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            // 
            // FormAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 399);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.labelDescpCategoria);
            this.MaximumSize = new System.Drawing.Size(380, 446);
            this.MinimumSize = new System.Drawing.Size(380, 446);
            this.Name = "FormAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltaCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescpCategoria;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
    }
}