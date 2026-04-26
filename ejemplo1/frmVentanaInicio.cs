using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmVentanaInicio : Form
    {
        private List<Articulo> listaArticulo;
        private List<Imagen> listaImagen;

      
        public frmVentanaInicio()
        {
            InitializeComponent();
            
        }


    




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ArticuloNegocio lista = new ArticuloNegocio();

        //    dgvArticulo.DataSource = lista.listar();



        //}



        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();

            ImagenNegocio ImagenNegocio = new ImagenNegocio();




            try
            {
                listaArticulo = artNegocio.listar();
                listaImagen = ImagenNegocio.listar();


                dgvArticulo.DataSource = listaArticulo;
                //pictureBox1.Load(listaImagen[0].Url);







                ocultarColumnas();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void ocultarColumnas()
        {
            // metodo para ocultas las columnas 
            dgvArticulo.Columns["id"].Visible = false;
            dgvArticulo.Columns["Imagen"].Visible = false;
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaMarca categoria = new frmCategoriaMarca(false);
            categoria.ShowDialog();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            frmCategoriaMarca marca = new frmCategoriaMarca(true);
            marca.ShowDialog();
        }


       
        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {





            if (dgvArticulo.CurrentRow == null) return;

            Articulo seleccionado = dgvArticulo.CurrentRow.DataBoundItem as Articulo;
            if (seleccionado == null) return;

            try
            {
                var imagen = listaImagen.FirstOrDefault(x => x.IdArticulo == seleccionado.Id);

                if (imagen != null && !string.IsNullOrEmpty(imagen.Url))
                {
                    pictureBox1.Load(imagen.Url);
                }
                else
                {
                    pictureBox1.Load("https://mrchava.es/wp-content/uploads/2021/09/placeholder.png");
                }
            }
            catch
            {
                // Si falla la URL (internet, link roto, etc.)
                pictureBox1.Load("https://mrchava.es/wp-content/uploads/2021/09/placeholder.png");
            }







            

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            
            AltaArticulo alta = new AltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e){


            if (dgvArticulo.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un Artículo para modificar");
                return;
            }

            Articulo seleccionado = dgvArticulo.CurrentRow.DataBoundItem as Articulo;

            if (seleccionado == null)
            {
                MessageBox.Show("Error al seleccionar el artículo");
                return;
            }

            try
            {
                AltaArticulo modificar = new AltaArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo artseleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    artseleccionado = dgvArticulo.CurrentRow.DataBoundItem as Articulo;
                    articuloNegocio.eliminar(artseleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = dgvArticulo.CurrentRow.DataBoundItem as Articulo;

            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un artículo");
                return;
            }

            AltaImagen altaNuevaImagen = new AltaImagen(seleccionado.Id);
            altaNuevaImagen.ShowDialog();

            cargar();


        }

        private void btnBuscaar_Click(object sender, EventArgs e)
        {


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltrada;

            ocultarColumnas();
        }
    }
}
