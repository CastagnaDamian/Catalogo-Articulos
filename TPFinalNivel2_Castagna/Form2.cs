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

namespace CatalogoGestion2025
{
    public partial class ventanaDetalle : Form
    {
        OpenFileDialog archivo = null;
        private Articulo articulo = null;
        private Articulo articuloAux;

        public ventanaDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            cargar(articulo);
            redondearBoton(btnConfirmar);
            redondearBoton(btnCancelar);
            redondearBoton(btnImagen);
        }

        public ventanaDetalle()
        {
            InitializeComponent();
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
            btnConfirmar.Text = "Agregar";
            btnConfirmar.Location = new Point(350, 352);
            btnConfirmar.Size = new Size(70, 23);
            cargar(articulo);
        }

        public void cargar(Articulo articulo)
        {
            MarcasNegocio negocioM = new MarcasNegocio();
            CategoriasNegocio negocioC = new CategoriasNegocio();
            try
            {
                cboxCategoria.DataSource = negocioC.listarCategorias();
                cboxCategoria.ValueMember = "Id";
                cboxCategoria.DisplayMember = "Descripcion";
                cboxMarca.DataSource = negocioM.listarMarcas();
                cboxMarca.ValueMember = "Id";
                cboxMarca.DisplayMember = "Descripcion";
                cboxCategoria.SelectedIndex = -1;
                cboxMarca.SelectedIndex = -1;
                if (articulo != null)
                {
                    tboxCodigo.Text = articulo.Codigo;
                    tboxNombre.Text = articulo.Nombre;
                    tboxDescripcion.Text = articulo.Descripcion;
                    tboxUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(tboxUrlImagen.Text);
                    tboxPrecio.Text = articulo.Precio.ToString();
                    cboxCategoria.SelectedValue = articulo.Categoria.Id;
                    cboxMarca.SelectedValue = articulo.Marca.Id;
                }
                desactivarBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articuloAux = new Articulo();
                articuloAux.Codigo = tboxCodigo.Text;
                articuloAux.Nombre = tboxNombre.Text;
                articuloAux.Descripcion = tboxDescripcion.Text;
                articuloAux.UrlImagen = tboxUrlImagen.Text;
                articuloAux.Marca = (Marcas)cboxMarca.SelectedItem;
                articuloAux.Categoria = (Categorias)cboxCategoria.SelectedItem;

                if (completarCampos(articuloAux) == true && validacionPrecio(tboxPrecio.Text) == true)
                {
                    articulo.Codigo = tboxCodigo.Text;
                    articulo.Nombre = tboxNombre.Text;
                    articulo.Descripcion = tboxDescripcion.Text;
                    articulo.UrlImagen = tboxUrlImagen.Text;
                    articulo.Marca = (Marcas)cboxMarca.SelectedItem;
                    articulo.Categoria = (Categorias)cboxCategoria.SelectedItem;

                    if (btnConfirmar.Text == "Agregar")
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Agregado exitosamente");
                        Close();
                    }
                    else
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado exitosamente");
                        desactivarBotones();
                        revelarMarcas(false);
                    }
                }
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
                picboxDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                picboxDetalle.Load("https://epichotelsanluis.com/wp-content/uploads/2022/11/placeholder-300x200.png");
            }
        }

        private void tboxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tboxUrlImagen.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
                Close();
            
        }

        public bool completarCampos(Articulo articulo)
        {
            if (articulo.Codigo == "" || articulo.Nombre == "" || cboxMarca.SelectedIndex == -1 || cboxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Los campos marcados(*) deben estar completos");
                revelarMarcas(true);
                return false;
            }
            return true;
        }

        public void revelarMarcas(bool estado)
        {
            if (estado == true)
            {
                lblCategoriaOK.Visible = true;
                lblCodigoOK.Visible = true;
                lblMarcaOK.Visible = true;
                lblNombreOK.Visible = true;
            }
            else
            {
                lblCategoriaOK.Visible = false;
                lblCodigoOK.Visible = false;
                lblMarcaOK.Visible = false;
                lblNombreOK.Visible = false;
            }
        }

        public bool validacionPrecio(string precio)
        {
            if (tboxPrecio.Text == "")
                articulo.Precio = 0;
            else
                try
                {
                    articulo.Precio = Convert.ToDecimal(tboxPrecio.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("El precio ingresado es incorrecto");
                    tboxPrecio.Text = "";
                    return false;
                }
            return true;
        }

        private void activarBotones(object sender, EventArgs e)
        {
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void desactivarBotones()
        {
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "png|*.png;|jpg|*.jpg";
            archivo.ShowDialog();
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tboxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private void ventanaDetalle_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_MouseEnter(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = Color.MediumBlue;
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            btnConfirmar.BackColor = Color.DodgerBlue;
        }

        private void redondearBoton(Button btn)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);
            btn.Region = new Region(path);
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.MediumBlue;

        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.DodgerBlue;
        }
    }
}



