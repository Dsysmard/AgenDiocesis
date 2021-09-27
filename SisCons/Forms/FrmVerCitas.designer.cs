namespace Menu
{
    partial class FrmVerCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerCitas));
            this.GbxOpciones = new System.Windows.Forms.GroupBox();
            this.CmbDoctores = new System.Windows.Forms.ComboBox();
            this.LblSelectDoctor = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.DtpAl = new System.Windows.Forms.DateTimePicker();
            this.DtpDel = new System.Windows.Forms.DateTimePicker();
            this.LblAl = new System.Windows.Forms.Label();
            this.LblDel = new System.Windows.Forms.Label();
            this.RdbMostraPorDoctor = new System.Windows.Forms.RadioButton();
            this.RdbMostrarTodo = new System.Windows.Forms.RadioButton();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblRegistros = new System.Windows.Forms.Label();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GbxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // GbxOpciones
            // 
            this.GbxOpciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbxOpciones.BackgroundImage = global::SisCons.Properties.Resources.LabelBackgroun;
            this.GbxOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GbxOpciones.Controls.Add(this.CmbDoctores);
            this.GbxOpciones.Controls.Add(this.LblSelectDoctor);
            this.GbxOpciones.Controls.Add(this.BtnMostrar);
            this.GbxOpciones.Controls.Add(this.DtpAl);
            this.GbxOpciones.Controls.Add(this.DtpDel);
            this.GbxOpciones.Controls.Add(this.LblAl);
            this.GbxOpciones.Controls.Add(this.LblDel);
            this.GbxOpciones.Controls.Add(this.RdbMostraPorDoctor);
            this.GbxOpciones.Controls.Add(this.RdbMostrarTodo);
            this.GbxOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxOpciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbxOpciones.Location = new System.Drawing.Point(26, 38);
            this.GbxOpciones.Name = "GbxOpciones";
            this.GbxOpciones.Size = new System.Drawing.Size(468, 123);
            this.GbxOpciones.TabIndex = 0;
            this.GbxOpciones.TabStop = false;
            this.GbxOpciones.Text = "OPCIONES";
            // 
            // CmbDoctores
            // 
            this.CmbDoctores.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDoctores.FormattingEnabled = true;
            this.CmbDoctores.Location = new System.Drawing.Point(18, 86);
            this.CmbDoctores.Name = "CmbDoctores";
            this.CmbDoctores.Size = new System.Drawing.Size(115, 21);
            this.CmbDoctores.TabIndex = 3;
            this.CmbDoctores.Visible = false;
            // 
            // LblSelectDoctor
            // 
            this.LblSelectDoctor.AutoSize = true;
            this.LblSelectDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectDoctor.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblSelectDoctor.Location = new System.Drawing.Point(15, 63);
            this.LblSelectDoctor.Name = "LblSelectDoctor";
            this.LblSelectDoctor.Size = new System.Drawing.Size(85, 13);
            this.LblSelectDoctor.TabIndex = 8;
            this.LblSelectDoctor.Text = "SELECCIONAR:";
            this.LblSelectDoctor.Visible = false;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMostrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Image = global::SisCons.Properties.Resources.page_white_magnify;
            this.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMostrar.Location = new System.Drawing.Point(382, 63);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(71, 51);
            this.BtnMostrar.TabIndex = 6;
            this.BtnMostrar.Text = "MOSTRAR";
            this.BtnMostrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnMostrar, "MOSTRAR REGISTROS");
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // DtpAl
            // 
            this.DtpAl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpAl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpAl.Location = new System.Drawing.Point(277, 85);
            this.DtpAl.Name = "DtpAl";
            this.DtpAl.Size = new System.Drawing.Size(99, 21);
            this.DtpAl.TabIndex = 5;
            // 
            // DtpDel
            // 
            this.DtpDel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDel.Location = new System.Drawing.Point(156, 86);
            this.DtpDel.Name = "DtpDel";
            this.DtpDel.Size = new System.Drawing.Size(97, 21);
            this.DtpDel.TabIndex = 4;
            // 
            // LblAl
            // 
            this.LblAl.AutoSize = true;
            this.LblAl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAl.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblAl.Location = new System.Drawing.Point(274, 63);
            this.LblAl.Name = "LblAl";
            this.LblAl.Size = new System.Drawing.Size(24, 13);
            this.LblAl.TabIndex = 4;
            this.LblAl.Text = "AL:";
            // 
            // LblDel
            // 
            this.LblDel.AutoSize = true;
            this.LblDel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDel.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblDel.Location = new System.Drawing.Point(153, 63);
            this.LblDel.Name = "LblDel";
            this.LblDel.Size = new System.Drawing.Size(30, 13);
            this.LblDel.TabIndex = 3;
            this.LblDel.Text = "DEL:";
            // 
            // RdbMostraPorDoctor
            // 
            this.RdbMostraPorDoctor.AutoSize = true;
            this.RdbMostraPorDoctor.BackgroundImage = global::SisCons.Properties.Resources.LabelBackgroun;
            this.RdbMostraPorDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbMostraPorDoctor.Location = new System.Drawing.Point(18, 42);
            this.RdbMostraPorDoctor.Name = "RdbMostraPorDoctor";
            this.RdbMostraPorDoctor.Size = new System.Drawing.Size(192, 17);
            this.RdbMostraPorDoctor.TabIndex = 2;
            this.RdbMostraPorDoctor.TabStop = true;
            this.RdbMostraPorDoctor.Text = "MOSTRAR CITAS POR OBISPO.";
            this.RdbMostraPorDoctor.UseVisualStyleBackColor = true;
            this.RdbMostraPorDoctor.CheckedChanged += new System.EventHandler(this.RdbMostraPorDoctor_CheckedChanged);
            // 
            // RdbMostrarTodo
            // 
            this.RdbMostrarTodo.AutoSize = true;
            this.RdbMostrarTodo.BackgroundImage = global::SisCons.Properties.Resources.LabelBackgroun;
            this.RdbMostrarTodo.Checked = true;
            this.RdbMostrarTodo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbMostrarTodo.Location = new System.Drawing.Point(18, 19);
            this.RdbMostrarTodo.Name = "RdbMostrarTodo";
            this.RdbMostrarTodo.Size = new System.Drawing.Size(254, 17);
            this.RdbMostrarTodo.TabIndex = 1;
            this.RdbMostrarTodo.TabStop = true;
            this.RdbMostrarTodo.Text = "MOSTRAR TODAS LAS CITAS AGENDADAS";
            this.RdbMostrarTodo.UseVisualStyleBackColor = true;
            this.RdbMostrarTodo.CheckedChanged += new System.EventHandler(this.RdbMostrarTodo_CheckedChanged);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::SisCons.Properties.Resources.printer;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimir.Location = new System.Drawing.Point(329, 344);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(73, 51);
            this.BtnImprimir.TabIndex = 8;
            this.BtnImprimir.Text = "IMPRIMIR";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnImprimir, "IMPRIMIR");
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::SisCons.Properties.Resources.door_in;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(408, 344);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 51);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnSalir, "SALIR DE LA VENTANA");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblRegistros
            // 
            this.LblRegistros.AutoSize = true;
            this.LblRegistros.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistros.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblRegistros.Location = new System.Drawing.Point(29, 176);
            this.LblRegistros.Name = "LblRegistros";
            this.LblRegistros.Size = new System.Drawing.Size(74, 13);
            this.LblRegistros.TabIndex = 10;
            this.LblRegistros.Text = "REGISTROS:";
            // 
            // DgvDatos
            // 
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(26, 192);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatos.Size = new System.Drawing.Size(468, 150);
            this.DgvDatos.TabIndex = 7;
            // 
            // FrmVerCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 408);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.LblRegistros);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.GbxOpciones);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerCitas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VER CITAS AGENDADAS";
            this.Load += new System.EventHandler(this.FrmVerCitas_Load);
            this.GbxOpciones.ResumeLayout(false);
            this.GbxOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxOpciones;
        private System.Windows.Forms.Label LblAl;
        private System.Windows.Forms.Label LblDel;
        private System.Windows.Forms.RadioButton RdbMostraPorDoctor;
        private System.Windows.Forms.RadioButton RdbMostrarTodo;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.DateTimePicker DtpAl;
        private System.Windows.Forms.DateTimePicker DtpDel;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox CmbDoctores;
        private System.Windows.Forms.Label LblSelectDoctor;
        private System.Windows.Forms.Label LblRegistros;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}