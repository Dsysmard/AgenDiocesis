namespace Menu
{
    partial class FrmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial));
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.LblFolio = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblClvPaciente = new System.Windows.Forms.Label();
            this.TxtApMat = new System.Windows.Forms.TextBox();
            this.TxtApPat = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblApMat = new System.Windows.Forms.Label();
            this.LblApPat = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtPresion = new System.Windows.Forms.TextBox();
            this.LblPresion = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.LblTemperatura = new System.Windows.Forms.Label();
            this.TxtTemperatura = new System.Windows.Forms.TextBox();
            this.LblPeso = new System.Windows.Forms.Label();
            this.TxtEstatura = new System.Windows.Forms.TextBox();
            this.LblEstatura = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblDoctor = new System.Windows.Forms.Label();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.LblDomicilio = new System.Windows.Forms.Label();
            this.TxtSintomas = new System.Windows.Forms.TextBox();
            this.LblSintomas = new System.Windows.Forms.Label();
            this.LblEnfermedad = new System.Windows.Forms.Label();
            this.TxtEnfermedad = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnBuscarReg = new System.Windows.Forms.Button();
            this.TxtFolio = new System.Windows.Forms.TextBox();
            this.LblFechaCita = new System.Windows.Forms.Label();
            this.DtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaCita = new System.Windows.Forms.TextBox();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.BtnVerCitas = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDomicilio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilio.Location = new System.Drawing.Point(27, 249);
            this.TxtDomicilio.MaxLength = 20;
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(128, 21);
            this.TxtDomicilio.TabIndex = 8;
            this.TxtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDomicilio_KeyPress);
            // 
            // TxtClave
            // 
            this.TxtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtClave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(165, 84);
            this.TxtClave.MaxLength = 4;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(132, 21);
            this.TxtClave.TabIndex = 1;
            this.TxtClave.TextChanged += new System.EventHandler(this.TxtClave_TextChanged);
            this.TxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClave_KeyPress);
            // 
            // LblFolio
            // 
            this.LblFolio.AutoSize = true;
            this.LblFolio.BackColor = System.Drawing.SystemColors.Menu;
            this.LblFolio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFolio.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblFolio.Location = new System.Drawing.Point(25, 43);
            this.LblFolio.Name = "LblFolio";
            this.LblFolio.Size = new System.Drawing.Size(43, 13);
            this.LblFolio.TabIndex = 101;
            this.LblFolio.Text = "FOLIO:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.SystemColors.Menu;
            this.LblFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblFecha.Location = new System.Drawing.Point(322, 24);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(92, 13);
            this.LblFecha.TabIndex = 114;
            this.LblFecha.Text = "FECHA ACTUAL:";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(318, 40);
            this.DtpFecha.MinDate = new System.DateTime(2009, 11, 9, 0, 0, 0, 0);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(132, 21);
            this.DtpFecha.TabIndex = 4;
            // 
            // LblClvPaciente
            // 
            this.LblClvPaciente.AutoSize = true;
            this.LblClvPaciente.BackColor = System.Drawing.SystemColors.Menu;
            this.LblClvPaciente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClvPaciente.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblClvPaciente.Location = new System.Drawing.Point(24, 87);
            this.LblClvPaciente.Name = "LblClvPaciente";
            this.LblClvPaciente.Size = new System.Drawing.Size(81, 13);
            this.LblClvPaciente.TabIndex = 115;
            this.LblClvPaciente.Text = "CLAVE LAICO:";
            // 
            // TxtApMat
            // 
            this.TxtApMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApMat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMat.Location = new System.Drawing.Point(315, 189);
            this.TxtApMat.MaxLength = 20;
            this.TxtApMat.Name = "TxtApMat";
            this.TxtApMat.Size = new System.Drawing.Size(128, 21);
            this.TxtApMat.TabIndex = 7;
            this.TxtApMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApMat_KeyPress);
            // 
            // TxtApPat
            // 
            this.TxtApPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApPat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPat.Location = new System.Drawing.Point(171, 189);
            this.TxtApPat.MaxLength = 20;
            this.TxtApPat.Name = "TxtApPat";
            this.TxtApPat.Size = new System.Drawing.Size(128, 21);
            this.TxtApPat.TabIndex = 6;
            this.TxtApPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApPat_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(27, 189);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(128, 21);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblApMat
            // 
            this.LblApMat.AutoSize = true;
            this.LblApMat.BackColor = System.Drawing.SystemColors.Menu;
            this.LblApMat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApMat.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblApMat.Location = new System.Drawing.Point(316, 161);
            this.LblApMat.Name = "LblApMat";
            this.LblApMat.Size = new System.Drawing.Size(85, 13);
            this.LblApMat.TabIndex = 122;
            this.LblApMat.Text = "AP. MATERNO:";
            // 
            // LblApPat
            // 
            this.LblApPat.AutoSize = true;
            this.LblApPat.BackColor = System.Drawing.SystemColors.Menu;
            this.LblApPat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApPat.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblApPat.Location = new System.Drawing.Point(171, 161);
            this.LblApPat.Name = "LblApPat";
            this.LblApPat.Size = new System.Drawing.Size(82, 13);
            this.LblApPat.TabIndex = 121;
            this.LblApPat.Text = "AP. PATERNO:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblNombre.Location = new System.Drawing.Point(27, 161);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 13);
            this.LblNombre.TabIndex = 120;
            this.LblNombre.Text = "NOMBRE:";
            // 
            // TxtPresion
            // 
            this.TxtPresion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPresion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPresion.Location = new System.Drawing.Point(221, 317);
            this.TxtPresion.MaxLength = 8;
            this.TxtPresion.Name = "TxtPresion";
            this.TxtPresion.Size = new System.Drawing.Size(78, 21);
            this.TxtPresion.TabIndex = 13;
            this.TxtPresion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPresion_KeyPress);
            // 
            // LblPresion
            // 
            this.LblPresion.AutoSize = true;
            this.LblPresion.BackColor = System.Drawing.SystemColors.Menu;
            this.LblPresion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPresion.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblPresion.Location = new System.Drawing.Point(231, 287);
            this.LblPresion.Name = "LblPresion";
            this.LblPresion.Size = new System.Drawing.Size(58, 13);
            this.LblPresion.TabIndex = 140;
            this.LblPresion.Text = "PRESION:";
            // 
            // TxtPeso
            // 
            this.TxtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPeso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeso.Location = new System.Drawing.Point(139, 317);
            this.TxtPeso.MaxLength = 8;
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(46, 21);
            this.TxtPeso.TabIndex = 12;
            this.TxtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPeso_KeyPress);
            // 
            // LblTemperatura
            // 
            this.LblTemperatura.AutoSize = true;
            this.LblTemperatura.BackColor = System.Drawing.SystemColors.Menu;
            this.LblTemperatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemperatura.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblTemperatura.Location = new System.Drawing.Point(315, 290);
            this.LblTemperatura.Name = "LblTemperatura";
            this.LblTemperatura.Size = new System.Drawing.Size(93, 13);
            this.LblTemperatura.TabIndex = 139;
            this.LblTemperatura.Text = "TEMPERATURA:";
            // 
            // TxtTemperatura
            // 
            this.TxtTemperatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTemperatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTemperatura.Location = new System.Drawing.Point(315, 317);
            this.TxtTemperatura.MaxLength = 8;
            this.TxtTemperatura.Name = "TxtTemperatura";
            this.TxtTemperatura.Size = new System.Drawing.Size(128, 21);
            this.TxtTemperatura.TabIndex = 14;
            this.TxtTemperatura.TextChanged += new System.EventHandler(this.TxtTemperatura_TextChanged);
            this.TxtTemperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTemperatura_KeyPress);
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.BackColor = System.Drawing.SystemColors.Menu;
            this.LblPeso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblPeso.Location = new System.Drawing.Point(139, 287);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(38, 13);
            this.LblPeso.TabIndex = 138;
            this.LblPeso.Text = "PESO:";
            // 
            // TxtEstatura
            // 
            this.TxtEstatura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEstatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstatura.Location = new System.Drawing.Point(27, 317);
            this.TxtEstatura.MaxLength = 8;
            this.TxtEstatura.Name = "TxtEstatura";
            this.TxtEstatura.Size = new System.Drawing.Size(77, 21);
            this.TxtEstatura.TabIndex = 11;
            this.TxtEstatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEstatura_KeyPress);
            // 
            // LblEstatura
            // 
            this.LblEstatura.AutoSize = true;
            this.LblEstatura.BackColor = System.Drawing.SystemColors.Menu;
            this.LblEstatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstatura.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblEstatura.Location = new System.Drawing.Point(25, 287);
            this.LblEstatura.Name = "LblEstatura";
            this.LblEstatura.Size = new System.Drawing.Size(69, 13);
            this.LblEstatura.TabIndex = 137;
            this.LblEstatura.Text = "ESTATURA:";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.SystemColors.Menu;
            this.LblHora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblHora.Location = new System.Drawing.Point(316, 223);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(42, 13);
            this.LblHora.TabIndex = 136;
            this.LblHora.Text = "HORA:";
            // 
            // LblDoctor
            // 
            this.LblDoctor.AutoSize = true;
            this.LblDoctor.BackColor = System.Drawing.SystemColors.Menu;
            this.LblDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctor.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblDoctor.Location = new System.Drawing.Point(171, 222);
            this.LblDoctor.Name = "LblDoctor";
            this.LblDoctor.Size = new System.Drawing.Size(56, 13);
            this.LblDoctor.TabIndex = 135;
            this.LblDoctor.Text = "DOCTOR:";
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(171, 249);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(128, 21);
            this.CmbDoctor.TabIndex = 9;
            // 
            // LblDomicilio
            // 
            this.LblDomicilio.AutoSize = true;
            this.LblDomicilio.BackColor = System.Drawing.SystemColors.Menu;
            this.LblDomicilio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDomicilio.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblDomicilio.Location = new System.Drawing.Point(27, 222);
            this.LblDomicilio.Name = "LblDomicilio";
            this.LblDomicilio.Size = new System.Drawing.Size(72, 13);
            this.LblDomicilio.TabIndex = 141;
            this.LblDomicilio.Text = "DOMICILIO:";
            // 
            // TxtSintomas
            // 
            this.TxtSintomas.AcceptsReturn = true;
            this.TxtSintomas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtSintomas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSintomas.Location = new System.Drawing.Point(139, 359);
            this.TxtSintomas.MaxLength = 50;
            this.TxtSintomas.Multiline = true;
            this.TxtSintomas.Name = "TxtSintomas";
            this.TxtSintomas.Size = new System.Drawing.Size(304, 43);
            this.TxtSintomas.TabIndex = 15;
            this.TxtSintomas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSintomas_KeyPress);
            // 
            // LblSintomas
            // 
            this.LblSintomas.AutoSize = true;
            this.LblSintomas.BackColor = System.Drawing.SystemColors.Menu;
            this.LblSintomas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSintomas.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblSintomas.Location = new System.Drawing.Point(27, 359);
            this.LblSintomas.Name = "LblSintomas";
            this.LblSintomas.Size = new System.Drawing.Size(69, 13);
            this.LblSintomas.TabIndex = 143;
            this.LblSintomas.Text = "SINTOMAS:";
            // 
            // LblEnfermedad
            // 
            this.LblEnfermedad.AutoSize = true;
            this.LblEnfermedad.BackColor = System.Drawing.SystemColors.Menu;
            this.LblEnfermedad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnfermedad.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblEnfermedad.Location = new System.Drawing.Point(25, 413);
            this.LblEnfermedad.Name = "LblEnfermedad";
            this.LblEnfermedad.Size = new System.Drawing.Size(83, 13);
            this.LblEnfermedad.TabIndex = 144;
            this.LblEnfermedad.Text = "ENFERMEDAD:";
            // 
            // TxtEnfermedad
            // 
            this.TxtEnfermedad.AcceptsReturn = true;
            this.TxtEnfermedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEnfermedad.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEnfermedad.Location = new System.Drawing.Point(139, 410);
            this.TxtEnfermedad.MaxLength = 50;
            this.TxtEnfermedad.Multiline = true;
            this.TxtEnfermedad.Name = "TxtEnfermedad";
            this.TxtEnfermedad.Size = new System.Drawing.Size(304, 43);
            this.TxtEnfermedad.TabIndex = 16;
            this.TxtEnfermedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEnfermedad_KeyPress);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::SisCons.Properties.Resources.door_in;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(248, 469);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 51);
            this.BtnSalir.TabIndex = 18;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnSalir, "SALIR DE VENTANA");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::SisCons.Properties.Resources.disk;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(169, 469);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(71, 51);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnGuardar, "GUARDAR REGISTROS");
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnBuscarReg
            // 
            this.BtnBuscarReg.AccessibleDescription = "Buscar Registro";
            this.BtnBuscarReg.Enabled = false;
            this.BtnBuscarReg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarReg.Image = global::SisCons.Properties.Resources.folder_explore;
            this.BtnBuscarReg.Location = new System.Drawing.Point(325, 87);
            this.BtnBuscarReg.Name = "BtnBuscarReg";
            this.BtnBuscarReg.Size = new System.Drawing.Size(40, 40);
            this.BtnBuscarReg.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BtnBuscarReg, "BUSCAR REGISTROS");
            this.BtnBuscarReg.UseVisualStyleBackColor = true;
            this.BtnBuscarReg.Click += new System.EventHandler(this.BtnBuscarReg_Click);
            this.BtnBuscarReg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnBuscarReg_MouseMove);
            // 
            // TxtFolio
            // 
            this.TxtFolio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFolio.Enabled = false;
            this.TxtFolio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFolio.Location = new System.Drawing.Point(78, 40);
            this.TxtFolio.MaxLength = 4;
            this.TxtFolio.Name = "TxtFolio";
            this.TxtFolio.Size = new System.Drawing.Size(77, 21);
            this.TxtFolio.TabIndex = 145;
            // 
            // LblFechaCita
            // 
            this.LblFechaCita.AutoSize = true;
            this.LblFechaCita.BackColor = System.Drawing.SystemColors.Menu;
            this.LblFechaCita.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaCita.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblFechaCita.Location = new System.Drawing.Point(24, 125);
            this.LblFechaCita.Name = "LblFechaCita";
            this.LblFechaCita.Size = new System.Drawing.Size(92, 13);
            this.LblFechaCita.TabIndex = 146;
            this.LblFechaCita.Text = "FECHA DE CITA:";
            // 
            // DtpFechaCita
            // 
            this.DtpFechaCita.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DtpFechaCita.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaCita.Location = new System.Drawing.Point(135, 121);
            this.DtpFechaCita.MinDate = new System.DateTime(2009, 11, 9, 0, 0, 0, 0);
            this.DtpFechaCita.Name = "DtpFechaCita";
            this.DtpFechaCita.Size = new System.Drawing.Size(20, 21);
            this.DtpFechaCita.TabIndex = 2;
            this.DtpFechaCita.ValueChanged += new System.EventHandler(this.DtpFechaCita_ValueChanged);
            // 
            // TxtFechaCita
            // 
            this.TxtFechaCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFechaCita.Enabled = false;
            this.TxtFechaCita.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaCita.Location = new System.Drawing.Point(165, 121);
            this.TxtFechaCita.MaxLength = 4;
            this.TxtFechaCita.Name = "TxtFechaCita";
            this.TxtFechaCita.Size = new System.Drawing.Size(132, 21);
            this.TxtFechaCita.TabIndex = 3;
            this.TxtFechaCita.Text = "__/__/____";
            this.TxtFechaCita.TextChanged += new System.EventHandler(this.TxtFechaCita_TextChanged);
            // 
            // TxtHora
            // 
            this.TxtHora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtHora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHora.Location = new System.Drawing.Point(315, 249);
            this.TxtHora.MaxLength = 20;
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(128, 21);
            this.TxtHora.TabIndex = 10;
            this.TxtHora.Text = "__:__";
            this.TxtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHora_KeyPress);
            // 
            // BtnVerCitas
            // 
            this.BtnVerCitas.AccessibleDescription = "Buscar Registro";
            this.BtnVerCitas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerCitas.Image = global::SisCons.Properties.Resources.book_open;
            this.BtnVerCitas.Location = new System.Drawing.Point(371, 87);
            this.BtnVerCitas.Name = "BtnVerCitas";
            this.BtnVerCitas.Size = new System.Drawing.Size(40, 40);
            this.BtnVerCitas.TabIndex = 147;
            this.toolTip1.SetToolTip(this.BtnVerCitas, "VER CITAS");
            this.BtnVerCitas.UseVisualStyleBackColor = true;
            this.BtnVerCitas.Click += new System.EventHandler(this.BtnVerCitas_Click);
            // 
            // FrmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 532);
            this.Controls.Add(this.BtnVerCitas);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.TxtFechaCita);
            this.Controls.Add(this.DtpFechaCita);
            this.Controls.Add(this.LblFechaCita);
            this.Controls.Add(this.TxtFolio);
            this.Controls.Add(this.BtnBuscarReg);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtEnfermedad);
            this.Controls.Add(this.LblEnfermedad);
            this.Controls.Add(this.LblSintomas);
            this.Controls.Add(this.TxtSintomas);
            this.Controls.Add(this.LblDomicilio);
            this.Controls.Add(this.TxtPresion);
            this.Controls.Add(this.LblPresion);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.LblTemperatura);
            this.Controls.Add(this.TxtTemperatura);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.TxtEstatura);
            this.Controls.Add(this.LblEstatura);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblDoctor);
            this.Controls.Add(this.CmbDoctor);
            this.Controls.Add(this.TxtApMat);
            this.Controls.Add(this.TxtApPat);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblApMat);
            this.Controls.Add(this.LblApPat);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblClvPaciente);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.LblFolio);
            this.Controls.Add(this.TxtDomicilio);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHistorial";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HISTORIAL DE CITAS DE LICO";
            this.Load += new System.EventHandler(this.FrmHistorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label LblFolio;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label LblClvPaciente;
        private System.Windows.Forms.TextBox TxtApMat;
        private System.Windows.Forms.TextBox TxtApPat;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblApMat;
        private System.Windows.Forms.Label LblApPat;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtPresion;
        private System.Windows.Forms.Label LblPresion;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Label LblTemperatura;
        private System.Windows.Forms.TextBox TxtTemperatura;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.TextBox TxtEstatura;
        private System.Windows.Forms.Label LblEstatura;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblDoctor;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.Label LblDomicilio;
        private System.Windows.Forms.TextBox TxtSintomas;
        private System.Windows.Forms.Label LblSintomas;
        private System.Windows.Forms.Label LblEnfermedad;
        private System.Windows.Forms.TextBox TxtEnfermedad;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBuscarReg;
        private System.Windows.Forms.TextBox TxtFolio;
        private System.Windows.Forms.Label LblFechaCita;
        private System.Windows.Forms.DateTimePicker DtpFechaCita;
        private System.Windows.Forms.TextBox TxtFechaCita;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.Button BtnVerCitas;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}