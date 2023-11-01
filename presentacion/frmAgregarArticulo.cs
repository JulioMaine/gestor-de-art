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
using dominio;
using helpers;
using System.IO;
using System.Configuration;

namespace presentacion
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";
                

                if (articulo != null)
                {
                    txtbCodigo.Text = articulo.Codigo;
                    txtbNombre.Text = articulo.Nombre;
                    rtxtbDescripcion.Text = articulo.Descripcion;
                    txtbImagenUrl.Text = articulo.ImagenUrl;
                    Helper.cargarImagen(pbArticulo, txtbImagenUrl.Text);
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    
                    txtbPrecio.Text = articulo.Precio.ToString("0.00");
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (validarDatos())
                    return;

                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtbCodigo.Text;
                articulo.Nombre = txtbNombre.Text;
                articulo.Descripcion = rtxtbDescripcion.Text;
                articulo.ImagenUrl = txtbImagenUrl.Text;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca= (Marca)cbMarca.SelectedItem;
                articulo.Precio = decimal.Parse(txtbPrecio.Text);
                
                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("El artículo fue modificado exitosamente.");
                }
                else
                {
                    articuloNegocio.agregarArticulo(articulo);
                    MessageBox.Show("El artículo fue agregado exitosamente.");
                }

                if (archivo != null && !(txtbImagenUrl.Text.ToUpper().Contains("HTTP")))
                {
                    if (File.Exists(archivo.FileName))
                    {
                        File.Delete(ConfigurationManager.AppSettings["Articulo-app"] + archivo.SafeFileName);
                    }
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Articulo-app"] + archivo.SafeFileName);
                }                   

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbImagenUrl_Leave(object sender, EventArgs e)
        {
            Helper.cargarImagen(pbArticulo, txtbImagenUrl.Text);
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            try
            {
                archivo.Filter = "jpg|*.jpg;|png|*.png";

                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtbImagenUrl.Text = archivo.FileName;
                    Helper.cargarImagen(pbArticulo, archivo.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }  
        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtbCodigo.Text))
            {
                MessageBox.Show("Por favor ingrese el código del artículo.");
                return true;
            }
            if (string.IsNullOrEmpty(txtbNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del artículo.");
                return true;
            }
            if (!(Helper.soloNumeros(txtbPrecio.Text)))
            {
                if (Helper.soloNumerosSinPuntos(txtbPrecio.Text))
                    return true;
                MessageBox.Show("Por favor ingrese solo números para el precio.");
                return true;
            }
            if (string.IsNullOrEmpty(txtbPrecio.Text))
            {
                MessageBox.Show("Por favor ingrese un número para el precio.");
                return true;
            }

            return false;
        }

    }
}
