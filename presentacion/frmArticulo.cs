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
using helpers;



namespace presentacion
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            Actualizar();
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Precio");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoría");
            
        }

        private void Actualizar()
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                listaArticulos = articuloNegocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                Helper.ocultarColumnas(dgvArticulos, "Id", "ImagenUrl", "Descripcion");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (Helper.validarDgv(dgvArticulos))
                    return;
                
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Helper.cargarImagen(pbArticulos, seleccionado.ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }                                               
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo nuevoArticulo = new frmAgregarArticulo();
            try
            {
                nuevoArticulo.ShowDialog();
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.validarDgv(dgvArticulos))
                    return;

                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregarArticulo modificarArticulo = new frmAgregarArticulo(articuloSeleccionado);
                modificarArticulo.ShowDialog();
                Actualizar();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.validarDgv(dgvArticulos))
                    return;
                
                // Eliminación fisica.
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                DialogResult seleccion = MessageBox.Show("¿Está seguro que quiere eliminarlo?", "Eliminar artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (seleccion == DialogResult.Yes)
                {
                    articuloNegocio.eliminar(seleccionado.Id);
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());               
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (Helper.validarDgv(dgvArticulos))
                    return;

                Articulo detalleArticulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalle detalle = new frmDetalle(detalleArticulo);
                detalle.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }      
        }

        private void txtbBusquedaRapida_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtbBusquedaRapida.Text;
            try
            {
                if (filtro.Length >= 2)
                {
                    dgvArticulos.DataSource = null;
                    dgvArticulos.DataSource = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Codigo.ToUpper().Contains(filtro.ToUpper()));
                    if (dgvArticulos.CurrentCell != null)
                        dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1]; // Para que seleccione el primer elemento cuando filtramos.
                }
                else
                {
                    dgvArticulos.DataSource = listaArticulos;
                }
                Helper.ocultarColumnas(dgvArticulos, "Id", "Descripcion", "ImagenUrl");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                if (cbCampo.SelectedItem.ToString() == "Nombre")
                {
                    cbCriterio.DataSource = null;
                    cbCriterio.Items.Clear();
                    cbCriterio.Items.Add("Empieza con:");
                    cbCriterio.Items.Add("Termina con:");
                    cbCriterio.Items.Add("Contiene:");
                    cbCriterio.SelectedIndex = 0;
                    txtbBusquedaAvanzada.Enabled = true;
                }
                else if (cbCampo.SelectedItem.ToString() == "Precio")
                {
                    cbCriterio.DataSource = null;
                    cbCriterio.Items.Clear();
                    cbCriterio.Items.Add("Mayor o igual a:");
                    cbCriterio.Items.Add("Menor o igual a:");
                    cbCriterio.Items.Add("Precio exacto:");
                    cbCriterio.SelectedIndex = 0;
                    txtbBusquedaAvanzada.Enabled = true;
                }
                else if (cbCampo.SelectedItem.ToString() == "Marca")
                {
                    cbCriterio.DataSource = marca.listar();
                    txtbBusquedaAvanzada.Clear();
                    txtbBusquedaAvanzada.Enabled = false;
                }
                else if (cbCampo.SelectedItem.ToString() == "Categoría")
                {
                    cbCriterio.DataSource = categoria.listar();
                    txtbBusquedaAvanzada.Clear();
                    txtbBusquedaAvanzada.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private bool validarFiltro()
        {
            if (cbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor selecciona un campo.");
                return true;
            }
            if (cbCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(Helper.soloNumerosFiltroAvanzado(txtbBusquedaAvanzada.Text)))
                {
                    if (Helper.formatoCorrectoFiltroAvanzado(txtbBusquedaAvanzada.Text))             
                        return true;
                    MessageBox.Show("Por favor solo números");
                    return true;
                }
                if (string.IsNullOrEmpty(txtbBusquedaAvanzada.Text))
                {
                    MessageBox.Show("Por favor ingrese un número.");
                    return true;
                }
                if (Helper.numeroSinPuntosFiltroAvanzado(txtbBusquedaAvanzada.Text))
                    return true;

            }
            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())               
                    return;                
                
                string campo = cbCampo.Text;
                string criterio = cbCriterio.Text;
                string filtro = txtbBusquedaAvanzada.Text;
                dgvArticulos.DataSource = articuloNegocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
