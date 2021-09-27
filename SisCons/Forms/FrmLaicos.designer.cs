namespace Menu
{
    partial class FrmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.LblDomicilio = new System.Windows.Forms.Label();
            this.TxtApMat = new System.Windows.Forms.TextBox();
            this.TxtApPat = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblApMat = new System.Windows.Forms.Label();
            this.LblApPat = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.TxtClvPaciente = new System.Windows.Forms.TextBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.LblFormatoFecha = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.TxtFechaNac = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TxtEmail
            // 
            this.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(276, 272);
            this.TxtEmail.MaxLength = 30;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(142, 21);
            this.TxtEmail.TabIndex = 9;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.SystemColors.Menu;
            this.LblEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblEmail.Location = new System.Drawing.Point(276, 242);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(50, 13);
            this.LblEmail.TabIndex = 159;
            this.LblEmail.Text = "E-MAIL:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.BackColor = System.Drawing.SystemColors.Menu;
            this.LblTelefono.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblTelefono.Location = new System.Drawing.Point(37, 212);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(64, 13);
            this.LblTelefono.TabIndex = 158;
            this.LblTelefono.Text = "TELEFONO:";
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtDomicilio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilio.Location = new System.Drawing.Point(169, 174);
            this.TxtDomicilio.MaxLength = 20;
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(249, 21);
            this.TxtDomicilio.TabIndex = 5;
            this.TxtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDomicilio_KeyPress);
            // 
            // LblDomicilio
            // 
            this.LblDomicilio.AutoSize = true;
            this.LblDomicilio.BackColor = System.Drawing.SystemColors.Menu;
            this.LblDomicilio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDomicilio.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblDomicilio.Location = new System.Drawing.Point(37, 174);
            this.LblDomicilio.Name = "LblDomicilio";
            this.LblDomicilio.Size = new System.Drawing.Size(72, 13);
            this.LblDomicilio.TabIndex = 157;
            this.LblDomicilio.Text = "DOMICILIO:";
            // 
            // TxtApMat
            // 
            this.TxtApMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApMat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApMat.Location = new System.Drawing.Point(169, 137);
            this.TxtApMat.MaxLength = 20;
            this.TxtApMat.Name = "TxtApMat";
            this.TxtApMat.Size = new System.Drawing.Size(249, 21);
            this.TxtApMat.TabIndex = 4;
            this.TxtApMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApMat_KeyPress);
            // 
            // TxtApPat
            // 
            this.TxtApPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtApPat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApPat.Location = new System.Drawing.Point(169, 103);
            this.TxtApPat.MaxLength = 20;
            this.TxtApPat.Name = "TxtApPat";
            this.TxtApPat.Size = new System.Drawing.Size(249, 21);
            this.TxtApPat.TabIndex = 3;
            this.TxtApPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApPat_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(169, 67);
            this.TxtNombre.MaxLength = 20;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(249, 21);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // LblApMat
            // 
            this.LblApMat.AutoSize = true;
            this.LblApMat.BackColor = System.Drawing.SystemColors.Menu;
            this.LblApMat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApMat.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblApMat.Location = new System.Drawing.Point(37, 140);
            this.LblApMat.Name = "LblApMat";
            this.LblApMat.Size = new System.Drawing.Size(85, 13);
            this.LblApMat.TabIndex = 154;
            this.LblApMat.Text = "AP. MATERNO:";
            // 
            // LblApPat
            // 
            this.LblApPat.AutoSize = true;
            this.LblApPat.BackColor = System.Drawing.SystemColors.Menu;
            this.LblApPat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApPat.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblApPat.Location = new System.Drawing.Point(37, 106);
            this.LblApPat.Name = "LblApPat";
            this.LblApPat.Size = new System.Drawing.Size(82, 13);
            this.LblApPat.TabIndex = 153;
            this.LblApPat.Text = "AP. PATERNO:";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.BackColor = System.Drawing.SystemColors.Menu;
            this.LblSexo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblSexo.Location = new System.Drawing.Point(169, 242);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(38, 13);
            this.LblSexo.TabIndex = 151;
            this.LblSexo.Text = "SEXO:";
            // 
            // TxtClvPaciente
            // 
            this.TxtClvPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtClvPaciente.Enabled = false;
            this.TxtClvPaciente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClvPaciente.Location = new System.Drawing.Point(169, 33);
            this.TxtClvPaciente.Name = "TxtClvPaciente";
            this.TxtClvPaciente.Size = new System.Drawing.Size(117, 21);
            this.TxtClvPaciente.TabIndex = 1;
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.BackColor = System.Drawing.SystemColors.Menu;
            this.LblClave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblClave.Location = new System.Drawing.Point(37, 33);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(81, 13);
            this.LblClave.TabIndex = 149;
            this.LblClave.Text = "CLAVE LAICO:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.SystemColors.Menu;
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblNombre.Location = new System.Drawing.Point(37, 70);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(56, 13);
            this.LblNombre.TabIndex = 161;
            this.LblNombre.Text = "NOMBRE:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTelefono.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(169, 212);
            this.TxtTelefono.MaxLength = 12;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(249, 21);
            this.TxtTelefono.TabIndex = 6;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = global::SisCons.Properties.Resources.door_in;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(237, 337);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 51);
            this.BtnSalir.TabIndex = 11;
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
            this.BtnGuardar.Location = new System.Drawing.Point(160, 337);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(71, 51);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.BtnGuardar, "GUARDAR REGISTRO");
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CmbSexo
            // 
            this.CmbSexo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.CmbSexo.Location = new System.Drawing.Point(169, 271);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(78, 21);
            this.CmbSexo.TabIndex = 8;
            // 
            // LblFormatoFecha
            // 
            this.LblFormatoFecha.AutoSize = true;
            this.LblFormatoFecha.BackColor = System.Drawing.SystemColors.Menu;
            this.LblFormatoFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormatoFecha.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblFormatoFecha.Location = new System.Drawing.Point(46, 295);
            this.LblFormatoFecha.Name = "LblFormatoFecha";
            this.LblFormatoFecha.Size = new System.Drawing.Size(86, 13);
            this.LblFormatoFecha.TabIndex = 166;
            this.LblFormatoFecha.Text = "DIA/MES/AÑO";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.SystemColors.Menu;
            this.LblFecha.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Image = global::SisCons.Properties.Resources.LabelBackgroun;
            this.LblFecha.Location = new System.Drawing.Point(37, 242);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(73, 13);
            this.LblFecha.TabIndex = 165;
            this.LblFecha.Text = "FECHA NAC.:";
            // 
            // DtpFechaNac
            // 
            this.DtpFechaNac.CalendarTitleBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DtpFechaNac.CustomFormat = "DD/MM/YYYY";
            this.DtpFechaNac.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaNac.Location = new System.Drawing.Point(40, 270);
            this.DtpFechaNac.Name = "DtpFechaNac";
            this.DtpFechaNac.Size = new System.Drawing.Size(20, 21);
            this.DtpFechaNac.TabIndex = 7;
            this.DtpFechaNac.Value = new System.DateTime(2009, 11, 26, 0, 0, 0, 0);
            this.DtpFechaNac.ValueChanged += new System.EventHandler(this.DtpFechaNac_ValueChanged);
            // 
            // TxtFechaNac
            // 
            this.TxtFechaNac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFechaNac.Enabled = false;
            this.TxtFechaNac.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaNac.Location = new System.Drawing.Point(66, 270);
            this.TxtFechaNac.MaxLength = 30;
            this.TxtFechaNac.Name = "TxtFechaNac";
            this.TxtFechaNac.Size = new System.Drawing.Size(86, 21);
            this.TxtFechaNac.TabIndex = 168;
            this.TxtFechaNac.Text = "__/__/____";
            this.TxtFechaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 400);
            this.Controls.Add(this.TxtFechaNac);
            this.Controls.Add(this.DtpFechaNac);
            this.Controls.Add(this.LblFormatoFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.LblDomicilio);
            this.Controls.Add(this.TxtApMat);
            this.Controls.Add(this.TxtApPat);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblApMat);
            this.Controls.Add(this.LblApPat);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.TxtClvPaciente);
            this.Controls.Add(this.LblClave);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPacientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE LAICOS";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label LblDomicilio;
        private System.Windows.Forms.TextBox TxtApMat;
        private System.Windows.Forms.TextBox TxtApPat;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblApMat;
        private System.Windows.Forms.Label LblApPat;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Label LblFormatoFecha;
        private System.Windows.Forms.Label LblFecha;
        public System.Windows.Forms.TextBox TxtClvPaciente;
        private System.Windows.Forms.DateTimePicker DtpFechaNac;
        private System.Windows.Forms.TextBox TxtFechaNac;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}