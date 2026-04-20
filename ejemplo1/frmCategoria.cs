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
    public partial class frmCategoria : Form
    {
        List<Categoria> catLista = new List<Categoria>();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio catNegocio = new CategoriaNegocio();

            try
            {
                catLista = catNegocio.listar();
                dgwCategoria.DataSource = catLista;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
