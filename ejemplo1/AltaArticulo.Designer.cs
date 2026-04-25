namespace ejemplo1
{
    partial class AltaArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBoxAlta = new System.Windows.Forms.PictureBox();
            this.TxtImagen = new System.Windows.Forms.Label();
            this.textImagen = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRECIO";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(274, 64);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(113, 20);
            this.textCodigo.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(274, 103);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(113, 20);
            this.textNombre.TabIndex = 5;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(274, 143);
            this.textDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(113, 20);
            this.textDescripcion.TabIndex = 6;
            this.textDescripcion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(274, 210);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(113, 20);
            this.textPrecio.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(196, 297);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 44);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(357, 297);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 44);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBoxAlta
            // 
            this.pictureBoxAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxAlta.Location = new System.Drawing.Point(526, 35);
            this.pictureBoxAlta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAlta.Name = "pictureBoxAlta";
            this.pictureBoxAlta.Size = new System.Drawing.Size(233, 258);
            this.pictureBoxAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlta.TabIndex = 10;
            this.pictureBoxAlta.TabStop = false;
            // 
            // TxtImagen
            // 
            this.TxtImagen.AutoSize = true;
            this.TxtImagen.Location = new System.Drawing.Point(175, 179);
            this.TxtImagen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Size = new System.Drawing.Size(77, 13);
            this.TxtImagen.TabIndex = 11;
            this.TxtImagen.Text = "-URL-IMAGEN";
            // 
            // textImagen
            // 
            this.textImagen.Location = new System.Drawing.Point(274, 174);
            this.textImagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textImagen.Name = "textImagen";
            this.textImagen.Size = new System.Drawing.Size(113, 20);
            this.textImagen.TabIndex = 12;
            this.textImagen.Leave += new System.EventHandler(this.textImagen_Leave);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(175, 242);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "CATEGORIA:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(175, 268);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "MARCA:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(274, 239);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(111, 21);
            this.cboCategoria.TabIndex = 15;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(273, 268);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(112, 21);
            this.cboMarca.TabIndex = 16;
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 471);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.textImagen);
            this.Controls.Add(this.TxtImagen);
            this.Controls.Add(this.pictureBoxAlta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AltaArticulo";
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBoxAlta;
        private System.Windows.Forms.Label TxtImagen;
        private System.Windows.Forms.TextBox textImagen;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
    }
}