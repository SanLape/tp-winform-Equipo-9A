namespace ejemplo1
{
    partial class AltaImagen
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
            this.txtOtraImagen = new System.Windows.Forms.Label();
            this.textImagen = new System.Windows.Forms.TextBox();
            this.pictureImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOtraImagen
            // 
            this.txtOtraImagen.AutoSize = true;
            this.txtOtraImagen.Location = new System.Drawing.Point(118, 79);
            this.txtOtraImagen.Name = "txtOtraImagen";
            this.txtOtraImagen.Size = new System.Drawing.Size(90, 16);
            this.txtOtraImagen.TabIndex = 0;
            this.txtOtraImagen.Text = "URL-IMAGEN";
            // 
            // textImagen
            // 
            this.textImagen.Location = new System.Drawing.Point(261, 79);
            this.textImagen.Name = "textImagen";
            this.textImagen.Size = new System.Drawing.Size(194, 22);
            this.textImagen.TabIndex = 1;
            this.textImagen.TextChanged += new System.EventHandler(this.textImagen_TextChanged);
            // 
            // pictureImagen
            // 
            this.pictureImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureImagen.Location = new System.Drawing.Point(150, 143);
            this.pictureImagen.Name = "pictureImagen";
            this.pictureImagen.Size = new System.Drawing.Size(336, 254);
            this.pictureImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureImagen.TabIndex = 2;
            this.pictureImagen.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(243, 434);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(112, 42);
            this.btnAgregarImagen.TabIndex = 3;
            this.btnAgregarImagen.Text = "AGREGAR";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // AltaImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 510);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pictureImagen);
            this.Controls.Add(this.textImagen);
            this.Controls.Add(this.txtOtraImagen);
            this.Name = "AltaImagen";
            this.Text = "AltaImagen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtOtraImagen;
        private System.Windows.Forms.TextBox textImagen;
        private System.Windows.Forms.PictureBox pictureImagen;
        private System.Windows.Forms.Button btnAgregarImagen;
    }
}