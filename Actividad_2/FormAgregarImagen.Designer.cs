namespace Actividad_2
{
    partial class FormAgregarImagen
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
            this.labelCodigoAgImg = new System.Windows.Forms.Label();
            this.textBoxCodAgImg = new System.Windows.Forms.TextBox();
            this.labelUrlAgImg = new System.Windows.Forms.Label();
            this.textBoxAgImg = new System.Windows.Forms.TextBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.btnCancelarAgImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigoAgImg
            // 
            this.labelCodigoAgImg.AutoSize = true;
            this.labelCodigoAgImg.Location = new System.Drawing.Point(149, 100);
            this.labelCodigoAgImg.Name = "labelCodigoAgImg";
            this.labelCodigoAgImg.Size = new System.Drawing.Size(51, 16);
            this.labelCodigoAgImg.TabIndex = 0;
            this.labelCodigoAgImg.Text = "Codigo";
            // 
            // textBoxCodAgImg
            // 
            this.textBoxCodAgImg.Location = new System.Drawing.Point(223, 94);
            this.textBoxCodAgImg.Name = "textBoxCodAgImg";
            this.textBoxCodAgImg.Size = new System.Drawing.Size(181, 22);
            this.textBoxCodAgImg.TabIndex = 1;
            // 
            // labelUrlAgImg
            // 
            this.labelUrlAgImg.AutoSize = true;
            this.labelUrlAgImg.Location = new System.Drawing.Point(118, 165);
            this.labelUrlAgImg.Name = "labelUrlAgImg";
            this.labelUrlAgImg.Size = new System.Drawing.Size(82, 16);
            this.labelUrlAgImg.TabIndex = 2;
            this.labelUrlAgImg.Text = "URL Imagen";
            // 
            // textBoxAgImg
            // 
            this.textBoxAgImg.Location = new System.Drawing.Point(223, 162);
            this.textBoxAgImg.Name = "textBoxAgImg";
            this.textBoxAgImg.Size = new System.Drawing.Size(181, 22);
            this.textBoxAgImg.TabIndex = 3;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(152, 303);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(104, 35);
            this.btnAgregarImg.TabIndex = 4;
            this.btnAgregarImg.Text = "Agregar ";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAgImg
            // 
            this.btnCancelarAgImg.Location = new System.Drawing.Point(308, 303);
            this.btnCancelarAgImg.Name = "btnCancelarAgImg";
            this.btnCancelarAgImg.Size = new System.Drawing.Size(96, 35);
            this.btnCancelarAgImg.TabIndex = 5;
            this.btnCancelarAgImg.Text = "Cancelar";
            this.btnCancelarAgImg.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(485, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 264);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelarAgImg);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.textBoxAgImg);
            this.Controls.Add(this.labelUrlAgImg);
            this.Controls.Add(this.textBoxCodAgImg);
            this.Controls.Add(this.labelCodigoAgImg);
            this.Name = "FormAgregarImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarImagen";
            this.Load += new System.EventHandler(this.FormAgregarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoAgImg;
        private System.Windows.Forms.TextBox textBoxCodAgImg;
        private System.Windows.Forms.Label labelUrlAgImg;
        private System.Windows.Forms.TextBox textBoxAgImg;
        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.Button btnCancelarAgImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}