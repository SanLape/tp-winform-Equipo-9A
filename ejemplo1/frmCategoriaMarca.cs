using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace ejemplo1
{
    public partial class frmCategoriaMarca : Form
    {
        private bool marca = false;
        List<Categoria> catLista = new List<Categoria>();
        List<Marca> marcaLista = new List<Marca>();
        public frmCategoriaMarca(bool marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {

            if (marca)
            {
                MarcaNegocio macNegocio = new MarcaNegocio();
                try
                {
                    marcaLista = macNegocio.listar();
                    dgwCategoriaMarca.DataSource = marcaLista;

                    this.Text = " MARCA ";
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                try
                {
                    catLista = catNegocio.listar();
                    dgwCategoriaMarca.DataSource = catLista;

                    this.Text = " CATEGORIA ";

                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                try
                {
                    if (marca)
                    {
                        MarcaNegocio marNegocio = new MarcaNegocio();
                        Marca aux = new Marca();
                        aux.Nombre = txtNombre.Text;
                        marNegocio.agregar(aux);

                        MessageBox.Show(" MARCA AGREGADA ");

                    }
                    else
                    {
                        CategoriaNegocio catNegocio = new CategoriaNegocio();
                        Categoria aux = new Categoria();
                        aux.Nombre = txtNombre.Text;
                        catNegocio.agregar(aux);

                        MessageBox.Show(" CATEGORIA AGREGADA ");
                    }
                    cargar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                MessageBox.Show(" AGREGAR UN NOMBRE ");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (marca)
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    Marca select = (Marca)dgwCategoriaMarca.CurrentRow.DataBoundItem;

                    marcaNegocio.eliminar(select.Id);
                    
                    MessageBox.Show(" MARCA ELIMINADA ");

                }
                else
                {
                    CategoriaNegocio catNegocio = new CategoriaNegocio();
                    Categoria select = (Categoria)dgwCategoriaMarca.CurrentRow.DataBoundItem;

                    catNegocio.eliminar(select.Id);

                    MessageBox.Show(" CATEGORIA ELIMINADA ");
                }
                cargar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
