namespace Menu
{
    partial class FrmVerHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerHistorial));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.LblRegistros = new System.Windows.Forms.Label();
            this.GbxOpciones = new System.Windows.Forms.GroupBox();
            this.CmbPacientes = new System.Windows.Forms.ComboBox();
            this.LblSelectPaciente = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.DtpAl = new System.Windows.Forms.DateTimePicker();
            this.DtpDel = new System.Windows.Forms.DateTimePicker();
            this.LblAl = new System.Windows.Forms.Label();
            this.LblDel = new System.Windows.Forms.Label();
            this.RdbMostrarPeriodos = new System.Windows.Forms.RadioButton();
            this.RdbMostrarTodos = new System.Windows.Forms.RadioButton();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GbxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::SisCons.Properties.Resources.door_in;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(363, 348);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 51);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnSalir, "SALIR DE LA VENTANA");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Image = global::SisCons.Properties.Resources.printer;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimir.Location = new System.Drawing.Point(284, 348);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(73, 51);
            this.BtnImprimir.TabIndex = 8;
            this.BtnImprimir.Text = "IMPRIMIR";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnImprimir, "IMPRIMIR");
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // LblRegistros
            // 
            this.LblRegistros.AutoSize = true;
            this.LblRegistros.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistros.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblRegistros.Location = new System.Drawing.Point(26, 180);
            this.LblRegistros.Name = "LblRegistros";
            this.LblRegistros.Size = new System.Drawing.Size(74, 13);
            this.LblRegistros.TabIndex = 16;
            this.LblRegistros.Text = "REGISTROS:";
            // 
            // GbxOpciones
            // 
            this.GbxOpciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbxOpciones.BackgroundImage = global::SisCons.Properties.Resources.LabelBackgroun;
            this.GbxOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GbxOpciones.Controls.Add(this.CmbPacientes);
            this.GbxOpciones.Controls.Add(this.LblSelectPaciente);
            this.GbxOpciones.Controls.Add(this.BtnMostrar);
            this.GbxOpciones.Controls.Add(this.DtpAl);
            this.GbxOpciones.Controls.Add(this.DtpDel);
            this.GbxOpciones.Controls.Add(this.LblAl);
            this.GbxOpciones.Controls.Add(this.LblDel);
            this.GbxOpciones.Controls.Add(this.RdbMostrarPeriodos);
            this.GbxOpciones.Controls.Add(this.RdbMostrarTodos);
            this.GbxOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxOpciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbxOpciones.Location = new System.Drawing.Point(26, 35);
            this.GbxOpciones.Name = "GbxOpciones";
            this.GbxOpciones.Size = new System.Drawing.Size(408, 130);
            this.GbxOpciones.TabIndex = 0;
            this.GbxOpciones.TabStop = false;
            this.GbxOpciones.Text = "OPCIONES";
            // 
            // CmbPacientes
            // 
            this.CmbPacientes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPacientes.FormattingEnabled = true;
            this.CmbPacientes.Location = new System.Drawing.Point(18, 34);
            this.CmbPacientes.Name = "CmbPacientes";
            this.CmbPacientes.Size = new System.Drawing.Size(164, 21);
            this.CmbPacientes.TabIndex = 2;
            // 
            // LblSelectPaciente
            // 
            this.LblSelectPaciente.AutoSize = true;
            this.LblSelectPaciente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectPaciente.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblSelectPaciente.Location = new System.Drawing.Point(18, 16);
            this.LblSelectPaciente.Name = "LblSelectPaciente";
            this.LblSelectPaciente.Size = new System.Drawing.Size(122, 13);
            this.LblSelectPaciente.TabIndex = 12;
            this.LblSelectPaciente.Text = "SELECCIONAR LAICO:";
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMostrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Image = global::SisCons.Properties.Resources.page_white_magnify;
            this.BtnMostrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMostrar.Location = new System.Drawing.Point(311, 69);
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
            this.DtpAl.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.DtpAl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpAl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpAl.Location = new System.Drawing.Point(198, 87);
            this.DtpAl.Name = "DtpAl";
            this.DtpAl.Size = new System.Drawing.Size(99, 21);
            this.DtpAl.TabIndex = 5;
            this.DtpAl.Visible = false;
            // 
            // DtpDel
            // 
            this.DtpDel.CalendarTitleBackColor = System.Drawing.Color.LightBlue;
            this.DtpDel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDel.Location = new System.Drawing.Point(18, 87);
            this.DtpDel.Name = "DtpDel";
            this.DtpDel.Size = new System.Drawing.Size(97, 21);
            this.DtpDel.TabIndex = 4;
            this.DtpDel.Visible = false;
            // 
            // LblAl
            // 
            this.LblAl.AutoSize = true;
            this.LblAl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAl.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblAl.Location = new System.Drawing.Point(198, 69);
            this.LblAl.Name = "LblAl";
            this.LblAl.Size = new System.Drawing.Size(24, 13);
            this.LblAl.TabIndex = 4;
            this.LblAl.Text = "AL:";
            this.LblAl.Visible = false;
            // 
            // LblDel
            // 
            this.LblDel.AutoSize = true;
            this.LblDel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDel.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblDel.Location = new System.Drawing.Point(18, 69);
            this.LblDel.Name = "LblDel";
            this.LblDel.Size = new System.Drawing.Size(30, 13);
            this.LblDel.TabIndex = 3;
            this.LblDel.Text = "DEL:";
            this.LblDel.Visible = false;
            // 
            // RdbMostrarPeriodos
            // 
            this.RdbMostrarPeriodos.AutoSize = true;
            this.RdbMostrarPeriodos.BackgroundImage = global::SisCons.Properties.Resources.LabelBackgroun;
            this.RdbMostrarPeriodos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbMostrarPeriodos.Location = new System.Drawing.Point(198, 38);
            this.RdbMostrarPeriodos.Name = "RdbMostrarPeriodos";
            this.RdbMostrarPeriodos.Size = new System.Drawing.Size(167, 17);
            this.RdbMostrarPeriodos.TabIndex = 3;
            this.RdbMostrarPeriodos.TabStop = true;
            this.RdbMostrarPeriodos.Text = "MOSTRAR POR PERIODOS";
            this.RdbMostrarPeriodos.UseVisualStyleBackColor = true;
            this.RdbMostrarPeriodos.CheckedChanged += new System.EventHandler(this.RdbMostrarPeriodos_CheckedChanged);
            // 
            // RdbMostrarTodos
            // 
            this.RdbMostrarTodos.AutoSize = true;
            this.RdbMostrarTodos.BackgroundImage = global::SisCons.Properties.Resources.LabelBackgroun;
            this.RdbMostrarTodos.Checked = true;
            this.RdbMostrarTodos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbMostrarTodos.Location = new System.Drawing.Point(198, 14);
            this.RdbMostrarTodos.Name = "RdbMostrarTodos";
            this.RdbMostrarTodos.Size = new System.Drawing.Size(122, 17);
            this.RdbMostrarTodos.TabIndex = 1;
            this.RdbMostrarTodos.TabStop = true;
            this.RdbMostrarTodos.Text = "MOSTRAR TODOS";
            this.RdbMostrarTodos.UseVisualStyleBackColor = true;
            this.RdbMostrarTodos.CheckedChanged += new System.EventHandler(this.RdbMostrarTodos_CheckedChanged);
            // 
            // DgvDatos
            // 
            this.DgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Location = new System.Drawing.Point(29, 206);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.Size = new System.Drawing.Size(405, 136);
            this.DgvDatos.TabIndex = 7;
            // 
            // FrmVerHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 413);
            this.Controls.Add(this.DgvDatos);
            this.Controls.Add(this.GbxOpciones);
            this.Controls.Add(this.LblRegistros);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnImprimir);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVerHistorial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VER EL VER EL HISTORIAL DE VISITAS DE UN LAICO";
            this.Load += new System.EventHandler(this.FrmVerHistorial_Load);
            this.GbxOpciones.ResumeLayout(false);
            this.GbxOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Label LblRegistros;
        private System.Windows.Forms.GroupBox GbxOpciones;
        private System.Windows.Forms.ComboBox CmbPacientes;
        private System.Windows.Forms.Label LblSelectPaciente;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.DateTimePicker DtpAl;
        private System.Windows.Forms.DateTimePicker DtpDel;
        private System.Windows.Forms.Label LblAl;
        private System.Windows.Forms.Label LblDel;
        private System.Windows.Forms.RadioButton RdbMostrarPeriodos;
        private System.Windows.Forms.RadioButton RdbMostrarTodos;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}