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
    public partial class frmVentanaInicio : Form
    {
        public frmVentanaInicio()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            ArticuloNegocio lista = new ArticuloNegocio();

            dataGridView1.DataSource = lista.listar();



        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio lista = new ArticuloNegocio();

            dataGridView1.DataSource = lista.listar();


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
    }
}
