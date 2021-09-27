namespace Menu
{
    partial class FrmPrincipalDiagnostico
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalDiagnostico));
            this.TsbMenu = new System.Windows.Forms.ToolStrip();
            this.TsBtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEditar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TsbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TsbMenu
            // 
            this.TsbMenu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnNuevo,
            this.TsBtnEditar,
            this.TsBtnEliminar,
            this.toolStripSeparator1,
            this.TsBtnSalir,
            this.toolStripSeparator2});
            this.TsbMenu.Location = new System.Drawing.Point(0, 0);
            this.TsbMenu.Name = "TsbMenu";
            this.TsbMenu.Size = new System.Drawing.Size(597, 52);
            this.TsbMenu.TabIndex = 6;
            this.TsbMenu.Text = "toolStrip1";
            // 
            // TsBtnNuevo
            // 
            this.TsBtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TsBtnNuevo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnNuevo.Image = global::SisCons.Properties.Resources.page_white_add;
            this.TsBtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnNuevo.Name = "TsBtnNuevo";
            this.TsBtnNuevo.Size = new System.Drawing.Size(47, 49);
            this.TsBtnNuevo.Text = "NUEVO";
            this.TsBtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnNuevo.ToolTipText = "NUEVO REGISTRO";
            this.TsBtnNuevo.Click += new System.EventHandler(this.TsBtnNuevo_Click);
            // 
            // TsBtnEditar
            // 
            this.TsBtnEditar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnEditar.Image = global::SisCons.Properties.Resources.page_white_edit;
            this.TsBtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnEditar.Name = "TsBtnEditar";
            this.TsBtnEditar.Size = new System.Drawing.Size(53, 49);
            this.TsBtnEditar.Text = "EDITAR";
            this.TsBtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnEditar.ToolTipText = "EDITAR REGISTRO";
            this.TsBtnEditar.Click += new System.EventHandler(this.TsBtnEditar_Click);
            // 
            // TsBtnEliminar
            // 
            this.TsBtnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnEliminar.Image = global::SisCons.Properties.Resources.page_white_delete;
            this.TsBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnEliminar.Name = "TsBtnEliminar";
            this.TsBtnEliminar.Size = new System.Drawing.Size(66, 49);
            this.TsBtnEliminar.Text = "ELIMINAR";
            this.TsBtnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnEliminar.ToolTipText = "ELIMINAR REGISTRO";
            this.TsBtnEliminar.Click += new System.EventHandler(this.TsBtnEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // TsBtnSalir
            // 
            this.TsBtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnSalir.Image = global::SisCons.Properties.Resources.door_in;
            this.TsBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnSalir.Name = "TsBtnSalir";
            this.TsBtnSalir.Size = new System.Drawing.Size(45, 49);
            this.TsBtnSalir.Text = "SALIR";
            this.TsBtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnSalir.ToolTipText = "SALIR DE LA VENTANA";
            this.TsBtnSalir.Click += new System.EventHandler(this.TsBtnSalir_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(26, 86);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatos.Size = new System.Drawing.Size(549, 266);
            this.DgvDatos.TabIndex = 7;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(308, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(100, 21);
            this.TxtBuscar.TabIndex = 9;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LblBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblBuscar.Location = new System.Drawing.Point(244, 14);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(55, 13);
            this.LblBuscar.TabIndex = 8;
            this.LblBuscar.Text = "BUSCAR:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPrincipalDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 374);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.TsbMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipalDiagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADO";
            this.Load += new System.EventHandler(this.FrmPrincipalDiagnostico_Load);
            this.TsbMenu.ResumeLayout(false);
            this.TsbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TsbMenu;
        private System.Windows.Forms.ToolStripButton TsBtnNuevo;
        private System.Windows.Forms.ToolStripButton TsBtnEditar;
        private System.Windows.Forms.ToolStripButton TsBtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsBtnSalir;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}