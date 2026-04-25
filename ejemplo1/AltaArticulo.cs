using datos;
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
        private Imagen imagen = new Imagen();

        public AltaArticulo()
        {
            InitializeComponent();
        }

        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
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
            //Articulo articulo = new Articulo();
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {

                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = textNombre.Text;
                articulo.Descripcion = textDescripcion.Text;
                imagen.Url = textImagen.Text;
                imagen.IdArticulo = articulo.Id;
                articulo.Precio = decimal.Parse(textPrecio.Text);

                articulo.Marca = new Marca();
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = new Categoria();
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);

                    MessageBox.Show("Modificado exitosamente");


                }
                else
                {




                    articuloNegocio.agregarArticulo(articulo);

                    int nuevoId = articuloNegocio.ultimoId();

                    Imagen imagen = new Imagen();
                    imagen.Url = textImagen.Text;
                    imagen.IdArticulo = nuevoId;

                    cargaImagenes.agregarImagen(imagen);

                    MessageBox.Show("Agregado exitosamente");

                }



                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {

            cargarCombox();
            listaImagen = cargaImagenes.listar();



            if (articulo != null)
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

        private void cargarCombox()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "id";
                cboMarca.DisplayMember = "Nombre";
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "id";
                cboCategoria.DisplayMember = "Nombre";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxAlta.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxAlta.Load("https://mrchava.es/wp-content/uploads/2021/09/placeholder.png");
            }
        }

        private void textImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textImagen.Text);
        }
    }
}
