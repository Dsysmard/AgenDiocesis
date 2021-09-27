namespace Menu
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblIntegrantes = new System.Windows.Forms.Label();
            this.LblNombre2 = new System.Windows.Forms.Label();
            this.LblNombre1 = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblDaniel = new System.Windows.Forms.Label();
            this.LblJairo = new System.Windows.Forms.Label();
            this.LblCarlos = new System.Windows.Forms.Label();
            this.LblMario = new System.Windows.Forms.Label();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(286, 287);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(71, 49);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnSalir, "SALIR DE LA VENTANA");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblIntegrantes
            // 
            this.LblIntegrantes.AutoSize = true;
            this.LblIntegrantes.BackColor = System.Drawing.Color.White;
            this.LblIntegrantes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIntegrantes.Location = new System.Drawing.Point(27, 167);
            this.LblIntegrantes.Name = "LblIntegrantes";
            this.LblIntegrantes.Size = new System.Drawing.Size(86, 13);
            this.LblIntegrantes.TabIndex = 15;
            this.LblIntegrantes.Text = "INTEGRANTES:";
            // 
            // LblNombre2
            // 
            this.LblNombre2.AutoSize = true;
            this.LblNombre2.BackColor = System.Drawing.Color.White;
            this.LblNombre2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombre2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre2.Location = new System.Drawing.Point(178, 89);
            this.LblNombre2.Name = "LblNombre2";
            this.LblNombre2.Size = new System.Drawing.Size(164, 15);
            this.LblNombre2.TabIndex = 1;
            this.LblNombre2.Text = "SISTEMA DE CONSULTAS 1.0";
            // 
            // LblNombre1
            // 
            this.LblNombre1.BackColor = System.Drawing.Color.White;
            this.LblNombre1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombre1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre1.Location = new System.Drawing.Point(143, 25);
            this.LblNombre1.Name = "LblNombre1";
            this.LblNombre1.Size = new System.Drawing.Size(214, 52);
            this.LblNombre1.TabIndex = 2;
            this.LblNombre1.Text = "SisCons";
            this.LblNombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.BackColor = System.Drawing.Color.White;
            this.LblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDescripcion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.Location = new System.Drawing.Point(27, 116);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(330, 51);
            this.LblDescripcion.TabIndex = 4;
            this.LblDescripcion.Text = "DESCRIPCION:     Sistema para agendar citas y manejar pacientes, mostrar las cita" +
                "s y generar el historial de enfermedades de un paciente.";
            // 
            // LblDaniel
            // 
            this.LblDaniel.BackColor = System.Drawing.Color.White;
            this.LblDaniel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDaniel.Location = new System.Drawing.Point(27, 192);
            this.LblDaniel.Name = "LblDaniel";
            this.LblDaniel.Size = new System.Drawing.Size(295, 13);
            this.LblDaniel.TabIndex = 11;
            this.LblDaniel.Text = "DANIEL FELIX HERNANDEZ                          2005489";
            // 
            // LblJairo
            // 
            this.LblJairo.BackColor = System.Drawing.Color.White;
            this.LblJairo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblJairo.Location = new System.Drawing.Point(27, 246);
            this.LblJairo.Name = "LblJairo";
            this.LblJairo.Size = new System.Drawing.Size(295, 11);
            this.LblJairo.TabIndex = 12;
            this.LblJairo.Text = "JAIRO ZURIEL HERNANDEZ NAVA             2002042";
            // 
            // LblCarlos
            // 
            this.LblCarlos.BackColor = System.Drawing.Color.White;
            this.LblCarlos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCarlos.Location = new System.Drawing.Point(27, 217);
            this.LblCarlos.Name = "LblCarlos";
            this.LblCarlos.Size = new System.Drawing.Size(295, 11);
            this.LblCarlos.TabIndex = 13;
            this.LblCarlos.Text = "CARLOS JAVIER GARCIA PEREZ                2004440";
            // 
            // LblMario
            // 
            this.LblMario.BackColor = System.Drawing.Color.White;
            this.LblMario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMario.Location = new System.Drawing.Point(27, 273);
            this.LblMario.Name = "LblMario";
            this.LblMario.Size = new System.Drawing.Size(293, 11);
            this.LblMario.TabIndex = 14;
            this.LblMario.Text = "MARIO ALBERTO MORALES SOLIS           2005559";
            // 
            // PtbLogo
            // 
            this.PtbLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PtbLogo.BackgroundImage = global::SisCons.Properties.Resources.symbol1;
            this.PtbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PtbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PtbLogo.Location = new System.Drawing.Point(27, 25);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(95, 79);
            this.PtbLogo.TabIndex = 0;
            this.PtbLogo.TabStop = false;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(377, 349);
            this.Controls.Add(this.LblIntegrantes);
            this.Controls.Add(this.LblMario);
            this.Controls.Add(this.LblCarlos);
            this.Controls.Add(this.LblJairo);
            this.Controls.Add(this.LblDaniel);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.LblNombre1);
            this.Controls.Add(this.LblNombre2);
            this.Controls.Add(this.PtbLogo);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACERCA DE SISCONS...";
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblIntegrantes;
        private System.Windows.Forms.Label LblNombre2;
        private System.Windows.Forms.Label LblNombre1;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblDaniel;
        private System.Windows.Forms.Label LblJairo;
        private System.Windows.Forms.Label LblCarlos;
        private System.Windows.Forms.Label LblMario;
        private System.Windows.Forms.PictureBox PtbLogo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}