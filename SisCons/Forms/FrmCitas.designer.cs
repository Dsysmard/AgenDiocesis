namespace Menu
{
    partial class FrmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            this.BtnBuscarReg = new System.Windows.Forms.Button();
            this.TxtClvPaciente = new System.Windows.Forms.TextBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDoctor = new System.Windows.Forms.Label();
            this.LblEstatura = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblApMat = new System.Windows.Forms.Label();
            this.LblApPat = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApPat = new System.Windows.Forms.TextBox();
            this.TxtApMat = new System.Windows.Forms.TextBox();
            this.TxtEstatura = new System.Windows.Forms.TextBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.LblTemperatura = new System.Windows.Forms.Label();
            this.TxtTemperatura = new System.Windows.Forms.TextBox();
            this.LblPresion = new System.Windows.Forms.Label();
            this.TxtPresion = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TxtFolioCitas = new System.Windows.Forms.TextBox();
            this.LblFolioCitas = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnBuscarReg
            // 
            this.BtnBuscarReg.AccessibleDescription = "Buscar Registro";
            this.BtnBuscarReg.AccessibleName = "Buscar Registro";
            this.BtnBuscarReg.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.BtnBuscarReg.Enabled = false;
            this.BtnBuscarReg.Image = global::SisCons.Properties.Resources.folder_explore;
            this.BtnBuscarReg.Location = new System.Drawing.Point(168, 73);
            this.BtnBuscarReg.Name = "BtnBuscarReg";
            this.BtnBuscarReg.Size = new System.Drawing.Size(40, 40);
            this.BtnBuscarReg.TabIndex = 2;
            this.BtnBuscarReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnBuscarReg, "BUSCAR REGISTRO");
            this.BtnBuscarReg.UseVisualStyleBackColor = true;
            this.BtnBuscarReg.Click += new System.EventHandler(this.BtnBuscarReg_Click);
            // 
            // TxtClvPaciente
            // 
            this.TxtClvPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtClvPaciente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClvPaciente.Location = new System.Drawing.Point(28, 93);
            this.TxtClvPaciente.MaxLength = 4;
            this.TxtClvPaciente.Name = "TxtClvPaciente";
            this.TxtClvPaciente.Size = new System.Drawing.Size(117, 21);
            this.TxtClvPaciente.TabIndex = 1;
            this.TxtClvPaciente.TextChanged += new System.EventHandler(this.TxtClvPaciente_TextChanged);
            this.TxtClvPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClvPaciente_KeyPress);
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.BackColor = System.Drawing.SystemColors.Menu;
            this.LblClave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblClave.Location = new System.Drawing.Point(28, 75);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(81, 13);
            this.LblClave.TabIndex = 25;
            this.LblClave.Text = "CLAVE LAICO:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(277, 93);
            this.DtpFecha.MinDate = new System.DateTime(2009, 11, 9, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(23, 21);
            this.DtpFecha.TabIndex = 4;
            this.DtpFecha.ValueChanged += new System.EventHandler(this.DtpFecha_ValueChanged);
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(143, 230);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(78, 21);
            this.CmbDoctor.TabIndex = 8;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::SisCons.Properties.Resources.door_in;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(223, 334);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 51);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnSalir, "SALIR DE LA VENTANA");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::SisCons.Properties.Resources.disk;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(146, 334);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(71, 51);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnGuardar, "GUARDAR REGISTRO");
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.SystemColors.Menu;
            this.LblFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblFecha.Location = new System.Drawing.Point(274, 73);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(45, 13);
            this.LblFecha.TabIndex = 112;
            this.LblFecha.Text = "FECHA:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblNombre.Location = new System.Drawing.Point(28, 128);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 13);
            this.LblNombre.TabIndex = 113;
            this.LblNombre.Text = "NOMBRE:";
            // 
            // LblDoctor
            // 
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.BackColor = System.Drawing.SystemColors.Menu;
            this.LblDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctor.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblDoctor.Location = new System.Drawing.Point(28, 233);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(52, 13);
            this.LblDoctor.TabIndex = 114;
            this.LblDoctor.Text = "OBISPO:";
            // 
            // LblEstatura
            // 
            this.LblEstatura.AutoSize = true;
            this.LblEstatura.BackColor = System.Drawing.SystemColors.Menu;
            this.LblEstatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstatura.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblEstatura.Location = new System.Drawing.Point(28, 264);
            this.LblEstatura.Name = "LblEstatura";
            this.LblEstatura.Size = new System.Drawing.Size(69, 13);
            this.LblEstatura.TabIndex = 118;
            this.LblEstatura.Text = "ESTATURA:";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.SystemColors.Menu;
            this.LblHora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblHora.Location = new System.Drawing.Point(237, 233);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(42, 13);
            this.LblHora.TabIndex = 117;
            this.LblHora.Text = "HORA:";
            // 
            // LblApMat
            // 
            this.LblApMat.AutoSize = true;
            this.LblApMat.BackColor = System.Drawing.SystemColors.Menu;
            this.LblApMat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApMat.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblApMat.Location = new System.Drawing.Point(28, 198);
            this.LblApMat.Name = "LblApMat";
            this.LblApMat.Size = new System.Drawing.Size(85, 13);
            this.LblApMat.TabIndex = 116;
            this.LblApMat.Text = "AP. MATERNO:";
            // 
            // LblApPat
            // 
            this.LblApPat.AutoSize = true;
            this.LblApPat.BackColor = System.Drawing.SystemColors.Menu;
            this.LblApPat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApPat.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblApPat.Location = new System.Drawing.Point(28, 164);
            this.LblApPat.Name = "LblApPat";
            this.LblApPat.Size = new System.Drawing.Size(82, 13);
            this.LblApPat.TabIndex = 115;
            this.LblApPat.Text = "AP. PATERNO:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(143, 125);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(249, 21);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // TxtApPat
            // 
            this.TxtApPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApPat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPat.Location = new System.Drawing.Point(143, 161);
            this.TxtApPat.MaxLength = 20;
            this.TxtApPat.Name = "TxtApPat";
            this.TxtApPat.Size = new System.Drawing.Size(249, 21);
            this.TxtApPat.TabIndex = 6;
            this.TxtApPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApPat_KeyPress);
            // 
            // TxtApMat
            // 
            this.TxtApMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApMat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMat.Location = new System.Drawing.Point(143, 195);
            this.TxtApMat.MaxLength = 20;
            this.TxtApMat.Name = "TxtApMat";
            this.TxtApMat.Size = new System.Drawing.Size(249, 21);
            this.TxtApMat.TabIndex = 7;
            this.TxtApMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApMat_KeyPress);
            // 
            // TxtEstatura
            // 
            this.TxtEstatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEstatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstatura.Location = new System.Drawing.Point(143, 264);
            this.TxtEstatura.MaxLength = 8;
            this.TxtEstatura.Name = "TxtEstatura";
            this.TxtEstatura.Size = new System.Drawing.Size(78, 21);
            this.TxtEstatura.TabIndex = 10;
            this.TxtEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEstatura_KeyPress);
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.BackColor = System.Drawing.SystemColors.Menu;
            this.LblPeso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblPeso.Location = new System.Drawing.Point(237, 264);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(38, 13);
            this.LblPeso.TabIndex = 124;
            this.LblPeso.Text = "PESO:";
            // 
            // TxtPeso
            // 
            this.TxtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPeso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeso.Location = new System.Drawing.Point(314, 264);
            this.TxtPeso.MaxLength = 8;
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(78, 21);
            this.TxtPeso.TabIndex = 11;
            this.TxtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPeso_KeyPress);
            // 
            // LblTemperatura
            // 
            this.LblTemperatura.AutoSize = true;
            this.LblTemperatura.BackColor = System.Drawing.SystemColors.Menu;
            this.LblTemperatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemperatura.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblTemperatura.Location = new System.Drawing.Point(28, 301);
            this.LblTemperatura.Name = "LblTemperatura";
            this.LblTemperatura.Size = new System.Drawing.Size(93, 13);
            this.LblTemperatura.TabIndex = 126;
            this.LblTemperatura.Text = "TEMPERATURA:";
            // 
            // TxtTemperatura
            // 
            this.TxtTemperatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTemperatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTemperatura.Location = new System.Drawing.Point(143, 298);
            this.TxtTemperatura.MaxLength = 8;
            this.TxtTemperatura.Name = "TxtTemperatura";
            this.TxtTemperatura.Size = new System.Drawing.Size(78, 21);
            this.TxtTemperatura.TabIndex = 12;
            this.TxtTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTemperatura_KeyPress);
            // 
            // LblPresion
            // 
            this.LblPresion.AutoSize = true;
            this.LblPresion.BackColor = System.Drawing.SystemColors.Menu;
            this.LblPresion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPresion.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblPresion.Location = new System.Drawing.Point(237, 301);
            this.LblPresion.Name = "LblPresion";
            this.LblPresion.Size = new System.Drawing.Size(58, 13);
            this.LblPresion.TabIndex = 128;
            this.LblPresion.Text = "PRESION:";
            // 
            // TxtPresion
            // 
            this.TxtPresion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPresion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPresion.Location = new System.Drawing.Point(314, 298);
            this.TxtPresion.MaxLength = 8;
            this.TxtPresion.Name = "TxtPresion";
            this.TxtPresion.Size = new System.Drawing.Size(78, 21);
            this.TxtPresion.TabIndex = 13;
            this.TxtPresion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPresion_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.AccessibleDescription = "Registrar un Paciente";
            this.BtnAgregar.AccessibleName = "Registrar un Paciente";
            this.BtnAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip;
            this.BtnAgregar.Enabled = false;
            this.BtnAgregar.Image = global::SisCons.Properties.Resources.group_add;
            this.BtnAgregar.Location = new System.Drawing.Point(214, 73);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(40, 40);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnAgregar, "AGREGAR NUEVO PACIENTE");
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TxtFolioCitas
            // 
            this.TxtFolioCitas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFolioCitas.Enabled = false;
            this.TxtFolioCitas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFolioCitas.Location = new System.Drawing.Point(146, 47);
            this.TxtFolioCitas.MaxLength = 4;
            this.TxtFolioCitas.Name = "TxtFolioCitas";
            this.TxtFolioCitas.Size = new System.Drawing.Size(62, 21);
            this.TxtFolioCitas.TabIndex = 129;
            // 
            // LblFolioCitas
            // 
            this.LblFolioCitas.AutoSize = true;
            this.LblFolioCitas.BackColor = System.Drawing.SystemColors.Menu;
            this.LblFolioCitas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFolioCitas.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblFolioCitas.Location = new System.Drawing.Point(28, 47);
            this.LblFolioCitas.Name = "LblFolioCitas";
            this.LblFolioCitas.Size = new System.Drawing.Size(43, 13);
            this.LblFolioCitas.TabIndex = 130;
            this.LblFolioCitas.Text = "FOLIO:";
            // 
            // TxtFecha
            // 
            this.TxtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(306, 94);
            this.TxtFecha.MaxLength = 30;
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(86, 20);
            this.TxtFecha.TabIndex = 169;
            this.TxtFecha.Text = "__/__/____";
            this.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtHora
            // 
            this.TxtHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHora.Location = new System.Drawing.Point(314, 230);
            this.TxtHora.MaxLength = 8;
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(78, 21);
            this.TxtHora.TabIndex = 9;
            this.TxtHora.Text = "__:__";
            this.TxtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHora_KeyPress);
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(420, 405);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtFolioCitas);
            this.Controls.Add(this.LblFolioCitas);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscarReg);
            this.Controls.Add(this.TxtPresion);
            this.Controls.Add(this.LblPresion);
            this.Controls.Add(this.TxtTemperatura);
            this.Controls.Add(this.LblTemperatura);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.TxtEstatura);
            this.Controls.Add(this.TxtApMat);
            this.Controls.Add(this.TxtApPat);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblEstatura);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblApMat);
            this.Controls.Add(this.LblApPat);
            this.Controls.Add(this.LblDoctor);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.CmbDoctor);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtClvPaciente);
            this.Controls.Add(this.LblClave);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCitas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE CITAS";
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClvPaciente;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.Label LblEstatura;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblApMat;
        private System.Windows.Forms.Label LblApPat;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApPat;
        private System.Windows.Forms.TextBox TxtApMat;
        private System.Windows.Forms.TextBox TxtEstatura;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label LblTemperatura;
        private System.Windows.Forms.TextBox TxtTemperatura;
        private System.Windows.Forms.Label LblPresion;
        private System.Windows.Forms.TextBox TxtPresion;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtFolioCitas;
        private System.Windows.Forms.Label LblFolioCitas;
        private System.Windows.Forms.Button BtnBuscarReg;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}