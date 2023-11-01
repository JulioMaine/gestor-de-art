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
using helpers;

namespace presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo;
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                txtbCodigo.Text = articulo.Codigo;
                txtbNombre.Text = articulo.Nombre;
                rtbDescripcion.Text = articulo.Descripcion;
                txtbImagenUrl.Text = articulo.ImagenUrl;
                Helper.cargarImagen(pbArticulo, txtbImagenUrl.Text);
                txtbMarca.Text = articulo.Marca.Descripcion;
                txtbCategoria.Text = articulo.Categoria.Descripcion;
                txtbPrecio.Text = articulo.Precio.ToString("0.00");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
  
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
