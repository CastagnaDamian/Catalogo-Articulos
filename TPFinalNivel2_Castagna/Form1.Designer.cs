namespace CatalogoGestion2025
{
    partial class GestionCatalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAuxiliar = new System.Windows.Forms.Label();
            this.txtRespaldo = new System.Windows.Forms.TextBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtFiltroPalabra = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCriterioBusqueda = new System.Windows.Forms.ComboBox();
            this.cboIngreso = new System.Windows.Forms.ComboBox();
            this.picboxStock = new System.Windows.Forms.PictureBox();
            this.dgvStcok = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStcok)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAuxiliar
            // 
            this.lblAuxiliar.AutoSize = true;
            this.lblAuxiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuxiliar.Location = new System.Drawing.Point(584, 76);
            this.lblAuxiliar.Name = "lblAuxiliar";
            this.lblAuxiliar.Size = new System.Drawing.Size(80, 13);
            this.lblAuxiliar.TabIndex = 28;
            this.lblAuxiliar.Text = "Label de ayuda";
            this.lblAuxiliar.Visible = false;
            // 
            // txtRespaldo
            // 
            this.txtRespaldo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRespaldo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRespaldo.Enabled = false;
            this.txtRespaldo.Location = new System.Drawing.Point(587, 52);
            this.txtRespaldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRespaldo.Name = "txtRespaldo";
            this.txtRespaldo.Size = new System.Drawing.Size(121, 20);
            this.txtRespaldo.TabIndex = 27;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(450, 76);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(80, 13);
            this.lblAyuda.TabIndex = 26;
            this.lblAyuda.Text = "Label de ayuda";
            this.lblAyuda.Visible = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.Location = new System.Drawing.Point(453, 426);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(93, 24);
            this.btnDetalle.TabIndex = 25;
            this.btnDetalle.Text = "Ver en detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.UseWaitCursor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(354, 426);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 24);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.UseWaitCursor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(255, 426);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 24);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.UseWaitCursor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtFiltroPalabra
            // 
            this.txtFiltroPalabra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFiltroPalabra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFiltroPalabra.Location = new System.Drawing.Point(453, 52);
            this.txtFiltroPalabra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltroPalabra.Name = "txtFiltroPalabra";
            this.txtFiltroPalabra.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroPalabra.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(714, 50);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 24);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(62, 53);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(56, 15);
            this.lblFiltro.TabIndex = 20;
            this.lblFiltro.Text = "Fitrar por";
            // 
            // cboCriterioBusqueda
            // 
            this.cboCriterioBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioBusqueda.FormattingEnabled = true;
            this.cboCriterioBusqueda.Location = new System.Drawing.Point(297, 50);
            this.cboCriterioBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCriterioBusqueda.Name = "cboCriterioBusqueda";
            this.cboCriterioBusqueda.Size = new System.Drawing.Size(121, 22);
            this.cboCriterioBusqueda.TabIndex = 19;
            this.cboCriterioBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboxCriterio_SelectedIndexChanged);
            // 
            // cboIngreso
            // 
            this.cboIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIngreso.FormattingEnabled = true;
            this.cboIngreso.Location = new System.Drawing.Point(151, 52);
            this.cboIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboIngreso.Name = "cboIngreso";
            this.cboIngreso.Size = new System.Drawing.Size(121, 22);
            this.cboIngreso.TabIndex = 18;
            this.cboIngreso.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // picboxStock
            // 
            this.picboxStock.Location = new System.Drawing.Point(576, 113);
            this.picboxStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picboxStock.Name = "picboxStock";
            this.picboxStock.Size = new System.Drawing.Size(239, 305);
            this.picboxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxStock.TabIndex = 17;
            this.picboxStock.TabStop = false;
            this.picboxStock.UseWaitCursor = true;
            // 
            // dgvStcok
            // 
            this.dgvStcok.AllowUserToAddRows = false;
            this.dgvStcok.AllowUserToDeleteRows = false;
            this.dgvStcok.AllowUserToResizeColumns = false;
            this.dgvStcok.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.NullValue = null;
            this.dgvStcok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStcok.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStcok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStcok.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStcok.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStcok.Location = new System.Drawing.Point(54, 113);
            this.dgvStcok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStcok.MultiSelect = false;
            this.dgvStcok.Name = "dgvStcok";
            this.dgvStcok.ReadOnly = true;
            this.dgvStcok.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStcok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStcok.Size = new System.Drawing.Size(474, 305);
            this.dgvStcok.TabIndex = 16;
            this.dgvStcok.SelectionChanged += new System.EventHandler(this.dgvStcok_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(802, 51);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // GestionCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 501);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblAuxiliar);
            this.Controls.Add(this.txtRespaldo);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFiltroPalabra);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cboCriterioBusqueda);
            this.Controls.Add(this.cboIngreso);
            this.Controls.Add(this.picboxStock);
            this.Controls.Add(this.dgvStcok);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestionCatalogo";
            this.Text = "Gestion Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStcok)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuxiliar;
        private System.Windows.Forms.TextBox txtRespaldo;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtFiltroPalabra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCriterioBusqueda;
        private System.Windows.Forms.ComboBox cboIngreso;
        private System.Windows.Forms.PictureBox picboxStock;
        private System.Windows.Forms.DataGridView dgvStcok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
    }
}

