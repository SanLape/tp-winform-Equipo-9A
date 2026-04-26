using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace ejemplo1
{
    public partial class AltaImagen : Form
    {

        ImagenNegocio imagenNegocio = new ImagenNegocio();
        private int idArticulo;

       
       
        public AltaImagen(int idArticulo)
        {
            InitializeComponent();
            this.idArticulo = idArticulo;
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            Imagen img = new Imagen();
            img.Url = textImagen.Text;
            img.IdArticulo = idArticulo;



            imagenNegocio.agregarImagen(img);

            MessageBox.Show("Imagen agregada");
            Close();
        }

        private void textImagen_TextChanged(object sender, EventArgs e)
        {
            string urlDefault = "https://mrchava.es/wp-content/uploads/2021/09/placeholder.png";

            if (string.IsNullOrWhiteSpace(textImagen.Text))
            {
                pictureImagen.Load(urlDefault);
                return;
            }

            try
            {
                pictureImagen.Load(textImagen.Text);
            }
            catch
            {
                pictureImagen.Load(urlDefault);
            }
        }
    }  

}
