namespace CatalogoGestion2025
{
    partial class ventanaDetalle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnImagen = new System.Windows.Forms.Button();
            this.lblCategoriaOK = new System.Windows.Forms.Label();
            this.lblMarcaOK = new System.Windows.Forms.Label();
            this.lblNombreOK = new System.Windows.Forms.Label();
            this.lblCodigoOK = new System.Windows.Forms.Label();
            this.picboxDetalle = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboxCategoria = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.tboxUrlImagen = new System.Windows.Forms.TextBox();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(379, 192);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(24, 21);
            this.btnImagen.TabIndex = 46;
            this.btnImagen.Text = "…";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // lblCategoriaOK
            // 
            this.lblCategoriaOK.AutoSize = true;
            this.lblCategoriaOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaOK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCategoriaOK.Location = new System.Drawing.Point(375, 304);
            this.lblCategoriaOK.Name = "lblCategoriaOK";
            this.lblCategoriaOK.Size = new System.Drawing.Size(17, 24);
            this.lblCategoriaOK.TabIndex = 45;
            this.lblCategoriaOK.Text = "*";
            this.lblCategoriaOK.Visible = false;
            // 
            // lblMarcaOK
            // 
            this.lblMarcaOK.AutoSize = true;
            this.lblMarcaOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaOK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMarcaOK.Location = new System.Drawing.Point(375, 265);
            this.lblMarcaOK.Name = "lblMarcaOK";
            this.lblMarcaOK.Size = new System.Drawing.Size(17, 24);
            this.lblMarcaOK.TabIndex = 44;
            this.lblMarcaOK.Text = "*";
            this.lblMarcaOK.Visible = false;
            // 
            // lblNombreOK
            // 
            this.lblNombreOK.AutoSize = true;
            this.lblNombreOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNombreOK.Location = new System.Drawing.Point(375, 113);
            this.lblNombreOK.Name = "lblNombreOK";
            this.lblNombreOK.Size = new System.Drawing.Size(17, 24);
            this.lblNombreOK.TabIndex = 43;
            this.lblNombreOK.Text = "*";
            this.lblNombreOK.Visible = false;
            // 
            // lblCodigoOK
            // 
            this.lblCodigoOK.AutoSize = true;
            this.lblCodigoOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoOK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCodigoOK.Location = new System.Drawing.Point(375, 76);
            this.lblCodigoOK.Name = "lblCodigoOK";
            this.lblCodigoOK.Size = new System.Drawing.Size(17, 24);
            this.lblCodigoOK.TabIndex = 42;
            this.lblCodigoOK.Text = "*";
            this.lblCodigoOK.Visible = false;
            // 
            // picboxDetalle
            // 
            this.picboxDetalle.Location = new System.Drawing.Point(422, 76);
            this.picboxDetalle.Name = "picboxDetalle";
            this.picboxDetalle.Size = new System.Drawing.Size(244, 249);
            this.picboxDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxDetalle.TabIndex = 41;
            this.picboxDetalle.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(460, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 23);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseEnter += new System.EventHandler(this.btnCancelar_MouseEnter);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            // 
            // cboxCategoria
            // 
            this.cboxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategoria.FormattingEnabled = true;
            this.cboxCategoria.Location = new System.Drawing.Point(235, 304);
            this.cboxCategoria.Name = "cboxCategoria";
            this.cboxCategoria.Size = new System.Drawing.Size(135, 21);
            this.cboxCategoria.TabIndex = 39;
            // 
            // cboxMarca
            // 
            this.cboxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(235, 265);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(135, 21);
            this.cboxMarca.TabIndex = 38;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(550, 351);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(99, 23);
            this.btnConfirmar.TabIndex = 37;
            this.btnConfirmar.Text = "Confirmar Edicion";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.MouseEnter += new System.EventHandler(this.btnConfirmar_MouseEnter);
            this.btnConfirmar.MouseLeave += new System.EventHandler(this.btnConfirmar_MouseLeave);
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Location = new System.Drawing.Point(235, 230);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(135, 20);
            this.tboxPrecio.TabIndex = 36;
            // 
            // tboxUrlImagen
            // 
            this.tboxUrlImagen.Location = new System.Drawing.Point(235, 192);
            this.tboxUrlImagen.Name = "tboxUrlImagen";
            this.tboxUrlImagen.Size = new System.Drawing.Size(135, 20);
            this.tboxUrlImagen.TabIndex = 35;
            this.tboxUrlImagen.Leave += new System.EventHandler(this.tboxUrlImagen_Leave);
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(235, 151);
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(135, 20);
            this.tboxDescripcion.TabIndex = 34;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(235, 113);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(135, 20);
            this.tboxNombre.TabIndex = 33;
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Location = new System.Drawing.Point(235, 76);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(135, 20);
            this.tboxCodigo.TabIndex = 32;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(146, 307);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 31;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(161, 233);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(161, 268);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 29;
            this.lblMarca.Text = "Marca";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(140, 195);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(58, 13);
            this.lblUrlImagen.TabIndex = 28;
            this.lblUrlImagen.Text = "Url Imagen";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(135, 154);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(154, 116);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(158, 79);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Codigo";
            // 
            // ventanaDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lblCategoriaOK);
            this.Controls.Add(this.lblMarcaOK);
            this.Controls.Add(this.lblNombreOK);
            this.Controls.Add(this.lblCodigoOK);
            this.Controls.Add(this.picboxDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboxCategoria);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tboxPrecio);
            this.Controls.Add(this.tboxUrlImagen);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "ventanaDetalle";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picboxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblCategoriaOK;
        private System.Windows.Forms.Label lblMarcaOK;
        private System.Windows.Forms.Label lblNombreOK;
        private System.Windows.Forms.Label lblCodigoOK;
        private System.Windows.Forms.PictureBox picboxDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboxCategoria;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tboxPrecio;
        private System.Windows.Forms.TextBox tboxUrlImagen;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}