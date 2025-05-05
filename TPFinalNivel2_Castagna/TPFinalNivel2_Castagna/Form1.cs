using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using dominio;
using negocio;

namespace CatalogoGestion2025
{
    public partial class GestionCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        private string rutaImagen;
        private string rutaImagenAux;

        public GestionCatalogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarStock();
            cargarComboBoxCampo();
        }

        private void cargarStock()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = articuloNegocio.listar();
                dgvStcok.DataSource = listaArticulos;
                dgvStcok.Columns["Precio"].DefaultCellStyle.Format = "0.00";
                dgvStcok.Columns["UrlImagen"].Visible = false;
                dgvStcok.Columns["Id"].Visible = false;
                dgvStcok.Columns["Descripcion"].Visible = false;
                dgvStcok.Columns["Categoria"].Visible = false;

                // Verificar si la lista tiene elementos antes de cargar la imagen
                if (listaArticulos != null && listaArticulos.Count > 0)
                    cargarImagen(listaArticulos[0].UrlImagen);
                else
                    picboxStock.Load("https://epichotelsanluis.com/wp-content/uploads/2022/11/placeholder-300x200.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                picboxStock.Load(imagen);
            }
            catch (Exception ex)
            {
                picboxStock.Load("https://epichotelsanluis.com/wp-content/uploads/2022/11/placeholder-300x200.png");
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvStcok.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado ningún artículo. Por favor, seleccione un artículo de la lista para ver sus detalles.",
                        "Artículo no seleccionado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                Articulo articulo = (Articulo)dgvStcok.CurrentRow.DataBoundItem;
                rutaImagen = articulo.UrlImagen;
                ventanaDetalle detalle = new ventanaDetalle(articulo);
                detalle.ShowDialog();
                cargarStock();
                rutaImagenAux = articulo.UrlImagen;
                if (rutaImagen != rutaImagenAux && !string.IsNullOrEmpty(rutaImagen))
                    File.Delete(rutaImagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventanaDetalle detalle = new ventanaDetalle();
            detalle.ShowDialog();
            cargarStock();
        }

        private void dgvStcok_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStcok.CurrentRow != null)
            {
                Articulo articulo = (Articulo)dgvStcok.CurrentRow.DataBoundItem;
                cargarImagen(articulo.UrlImagen);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvStcok.CurrentRow == null)
            {
                MessageBox.Show("No se ha seleccionado ningún artículo. Por favor, selecciona un artículo de la lista para continuar.", "Artículo no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo articulo = (Articulo)dgvStcok.CurrentRow.DataBoundItem;
                try
                {
                    DialogResult respuesta = MessageBox.Show("Se procederá a eliminar permanentemente el artículo '" + articulo.Nombre + "'. Esta acción no se puede deshacer y podría afectar otros registros relacionados. ¿Desea continuar?", "Confirmación de eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.OK)
                    {
                        negocio.eliminar(articulo.Id);
                        cargarStock();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void cargarComboBoxCampo()
        {
            cboIngreso.Items.Add("Codigo");
            cboIngreso.Items.Add("Nombre");
            cboIngreso.Items.Add("Precio");
            cboIngreso.Items.Add("Marca");
        }

        private void cboxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado un item
            if (cboIngreso.SelectedItem == null)
                return;

            txtRespaldo.Text = null;
            txtFiltroPalabra.AutoCompleteCustomSource = null;
            txtRespaldo.AutoCompleteCustomSource = null;
            lblAyuda.Visible = false;
            lblAuxiliar.Visible = false;
            txtRespaldo.Enabled = false;
            string opcion = cboIngreso.SelectedItem.ToString();

            if (opcion == "Codigo" || opcion == "Nombre")
            {
                cboCriterioBusqueda.Items.Clear();
                cboCriterioBusqueda.Items.Add("Comienza con");
                cboCriterioBusqueda.Items.Add("Contiene");
                cboCriterioBusqueda.Items.Add("Termina con");
            }
            else if (opcion == "Precio")
            {
                cboCriterioBusqueda.Items.Clear();
                cboCriterioBusqueda.Items.Add("Menor a");
                cboCriterioBusqueda.Items.Add("Entre");
                cboCriterioBusqueda.Items.Add("Mayor a");
            }
            else
            {
                cboCriterioBusqueda.Items.Clear();
                cboCriterioBusqueda.Items.Add("Categoria");
                cboCriterioBusqueda.Items.Add("Todos");
                autocompletar();
            }
        }

        private void cboxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCriterioBusqueda.SelectedItem == null)
                return;

            string criterio = cboCriterioBusqueda.SelectedItem.ToString();

            if (criterio == "Entre")
            {
                txtRespaldo.Enabled = true;
                lblAyuda.Visible = true;
                lblAuxiliar.Visible = true;
                lblAyuda.Text = "Minimo";
                lblAuxiliar.Text = "Maximo";
            }
            else if (criterio == "Categoria")
            {
                txtRespaldo.Enabled = true;
                lblAyuda.Visible = true;
                lblAuxiliar.Visible = true;
                lblAyuda.Text = "Marca";
                lblAuxiliar.Text = "Categoria";
            }
            else
            {
                lblAyuda.Visible = false;
                lblAuxiliar.Visible = false;
                txtRespaldo.Enabled = false;
                txtRespaldo.Text = null;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboIngreso.SelectedItem != null && cboCriterioBusqueda.SelectedItem != null)
            {
                string campo = cboIngreso.SelectedItem.ToString();
                string criterio = cboCriterioBusqueda.SelectedItem.ToString();
                if (validarParametros(campo, criterio))
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    try
                    {
                        if (criterio == "Entre" || criterio == "Categoria")
                        {
                            string parametroA = txtFiltroPalabra.Text;
                            string parametroB = txtRespaldo.Text;
                            dgvStcok.DataSource = negocio.filtro(campo, criterio, parametroA, parametroB);
                        }
                        else
                        {
                            string parametro = txtFiltroPalabra.Text;
                            dgvStcok.DataSource = negocio.filtro(campo, criterio, parametro, "");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("El parámetro de búsqueda ingresado es incorrecto. Por favor, revise que los datos sean los adecuados y cumplan con el formato requerido.", "Parámetro de búsqueda inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El parámetro de búsqueda ingresado es incorrecto. Por favor, verifique que los valores sean los adecuados y cumplan con el formato requerido.", "Parámetro de búsqueda inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool validarParametros(string campo, string criterio)
        {
            string cadena = txtFiltroPalabra.Text;
            if (campo == "Precio" || campo == "Marca")
            {
                if (string.IsNullOrEmpty(cadena))
                    return false;

                switch (criterio)
                {
                    case "Categoria":
                    case "Entre":
                        if (string.IsNullOrEmpty(txtRespaldo.Text))
                            return false;
                        if (campo == "Precio")
                        {
                            bool numerosValidos = validarNumeros(cadena) && validarNumeros(txtRespaldo.Text);
                            return numerosValidos;
                        }
                        return true;

                    default:
                        if (campo == "Precio")
                        {
                            bool numerosValidos = validarNumeros(cadena);
                            return numerosValidos;
                        }
                        return true;
                }
            }
            else
            {
                return true;
            }
        }

        public bool validarNumeros(string numero)
        {
            return int.TryParse(numero, out int num);
        }

        public void autocompletar()
        {
            AutoCompleteStringCollection listaColeccion;
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    listaColeccion = new AutoCompleteStringCollection();
                    if (i == 0)
                    {
                        CategoriasNegocio negocioC = new CategoriasNegocio();
                        List<Categorias> listaC = negocioC.listarCategorias();
                        foreach (Categorias cat in listaC)
                        {
                            listaColeccion.Add(cat.Descripcion);
                        }
                        txtRespaldo.AutoCompleteCustomSource = listaColeccion;
                    }
                    else
                    {
                        MarcasNegocio negocioM = new MarcasNegocio();
                        List<Marcas> listaM = negocioM.listarMarcas();
                        foreach (Marcas mar in listaM)
                        {
                            listaColeccion.Add(mar.Descripcion);
                        }
                        txtFiltroPalabra.AutoCompleteCustomSource = listaColeccion;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            // Limpiar filtros
            cboIngreso.SelectedIndex = -1;
            cboCriterioBusqueda.SelectedIndex = -1;
            txtFiltroPalabra.Text = "";
            txtRespaldo.Text = "";

            // Restaurar DataGridView con la lista completa
            cargarStock();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App  de gestión de artículos\nVersión 1.0 bien pobre jajaj\nDesarrollado por Dev_Dami", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}








