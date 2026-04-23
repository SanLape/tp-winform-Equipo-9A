using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ejemplo1
{
    public partial class AltaArticulo : Form
    {
        private List<Articulo> listaArticulo;
        private List<Imagen> listaImagen;
        private ImagenNegocio cargaImagenes = new ImagenNegocio();
        private Articulo articulo = null;
        public AltaArticulo()
        {
            InitializeComponent();
        }

        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = textNombre.Text;
               articulo.Descripcion = textDescripcion.Text;
                articulo.Precio = decimal.Parse(textPrecio.Text);

                articuloNegocio.agregarArticulo(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {

            listaImagen = cargaImagenes.listar();
            

            if (articulo!=null)
            {
                

              

                try
                {

                    textCodigo.Text = articulo.Codigo;
                    textNombre.Text = articulo.Nombre;
                    textDescripcion.Text = articulo.Descripcion;
                    textPrecio.Text = articulo.Precio.ToString();
                  

                    var imagen = listaImagen.FirstOrDefault(x => x.IdArticulo == articulo.Id);
                    if (imagen != null)
                        

                   


                    if (imagen != null && !string.IsNullOrEmpty(imagen.Url))
                    {
                        pictureBoxAlta.Load(imagen.Url);
                    }
                    else
                    {
                        pictureBoxAlta.Load("https://mrchava.es/wp-content/uploads/2021/09/placeholder.png");
                    }
                }
                catch
                {
                    // Si falla la URL (internet, link roto, etc.)
                    pictureBoxAlta.Load("https://mrchava.es/wp-content/uploads/2021/09/placeholder.png");
                    
                }

            }
        }
    }
}
