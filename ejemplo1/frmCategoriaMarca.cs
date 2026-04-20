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
                    dgwCategoria.DataSource = marcaLista;

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
                    dgwCategoria.DataSource = catLista;

                    this.Text = " CATEGORIA ";

                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
    }
}
