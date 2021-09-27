namespace Menu
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.TsbMenu = new System.Windows.Forms.ToolStrip();
            this.TsBtnPacientes = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDoctores = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnCitas = new System.Windows.Forms.ToolStripButton();
            this.TsBtnRegDiagnostico = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnConsultas = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnVerCitasAgendadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBtnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.TsbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsbMenu
            // 
            this.TsbMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnPacientes,
            this.TsBtnDoctores,
            this.toolStripSeparator2,
            this.TsBtnCitas,
            this.TsBtnRegDiagnostico,
            this.toolStripSeparator1,
            this.TsBtnConsultas,
            this.toolStripSeparator4,
            this.TSBtnAbout,
            this.toolStripSeparator5,
            this.TSBtnSalir});
            this.TsbMenu.Location = new System.Drawing.Point(0, 0);
            this.TsbMenu.Name = "TsbMenu";
            this.TsbMenu.Size = new System.Drawing.Size(889, 52);
            this.TsbMenu.TabIndex = 1;
            this.TsbMenu.Text = "toolStrip1";
            // 
            // TsBtnPacientes
            // 
            this.TsBtnPacientes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnPacientes.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnPacientes.Image")));
            this.TsBtnPacientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnPacientes.Name = "TsBtnPacientes";
            this.TsBtnPacientes.Size = new System.Drawing.Size(71, 49);
            this.TsBtnPacientes.Text = "PACIENTES";
            this.TsBtnPacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnPacientes.ToolTipText = "REGISTRAR PACIENTES";
            this.TsBtnPacientes.Click += new System.EventHandler(this.TsBtnPacientes_Click);
            // 
            // TsBtnDoctores
            // 
            this.TsBtnDoctores.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnDoctores.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnDoctores.Image")));
            this.TsBtnDoctores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnDoctores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnDoctores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnDoctores.Name = "TsBtnDoctores";
            this.TsBtnDoctores.Size = new System.Drawing.Size(70, 49);
            this.TsBtnDoctores.Text = "DOCTORES";
            this.TsBtnDoctores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnDoctores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnDoctores.ToolTipText = "REGISTRAR DOCTORES";
            this.TsBtnDoctores.Click += new System.EventHandler(this.TsBtnDoctores_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // TsBtnCitas
            // 
            this.TsBtnCitas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnCitas.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnCitas.Image")));
            this.TsBtnCitas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnCitas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnCitas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnCitas.Name = "TsBtnCitas";
            this.TsBtnCitas.Size = new System.Drawing.Size(45, 49);
            this.TsBtnCitas.Text = "CITAS";
            this.TsBtnCitas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnCitas.ToolTipText = "AGENDAR CITAS";
            this.TsBtnCitas.Click += new System.EventHandler(this.TsBtnCitas_Click);
            // 
            // TsBtnRegDiagnostico
            // 
            this.TsBtnRegDiagnostico.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnRegDiagnostico.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnRegDiagnostico.Image")));
            this.TsBtnRegDiagnostico.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnRegDiagnostico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnRegDiagnostico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnRegDiagnostico.Name = "TsBtnRegDiagnostico";
            this.TsBtnRegDiagnostico.Size = new System.Drawing.Size(89, 49);
            this.TsBtnRegDiagnostico.Text = "DIAGNOSTICO";
            this.TsBtnRegDiagnostico.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnRegDiagnostico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnRegDiagnostico.ToolTipText = "REGISTRAR DIAGNOSTICO DE UN PACIENTE";
            this.TsBtnRegDiagnostico.Click += new System.EventHandler(this.TsBtnRegDiagnostico_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // TsBtnConsultas
            // 
            this.TsBtnConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem,
            this.toolStripSeparator3,
            this.TsBtnVerCitasAgendadasToolStripMenuItem});
            this.TsBtnConsultas.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsBtnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnConsultas.Image")));
            this.TsBtnConsultas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnConsultas.Name = "TsBtnConsultas";
            this.TsBtnConsultas.Size = new System.Drawing.Size(85, 49);
            this.TsBtnConsultas.Text = "CONSULTAS";
            this.TsBtnConsultas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TsBtnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnConsultas.ToolTipText = "CONSULTAR DATOS";
            // 
            // TsBtnVerHistorialDeUnPacienteToolStripMenuItem
            // 
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnVerHistorialDeUnPacienteToolStripMenuItem.Image")));
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.Name = "TsBtnVerHistorialDeUnPacienteToolStripMenuItem";
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.Size = new System.Drawing.Size(278, 38);
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.Text = "VER HISTORIAL DE UN PACIENTE";
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.ToolTipText = "MUESTRA EL HISTORIAL MEDICO DE UN PACIENTE";
            this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem.Click += new System.EventHandler(this.TsBtnVerHistorialDeUnPacienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(275, 6);
            // 
            // TsBtnVerCitasAgendadasToolStripMenuItem
            // 
            this.TsBtnVerCitasAgendadasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnVerCitasAgendadasToolStripMenuItem.Image")));
            this.TsBtnVerCitasAgendadasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TsBtnVerCitasAgendadasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnVerCitasAgendadasToolStripMenuItem.Name = "TsBtnVerCitasAgendadasToolStripMenuItem";
            this.TsBtnVerCitasAgendadasToolStripMenuItem.Size = new System.Drawing.Size(278, 38);
            this.TsBtnVerCitasAgendadasToolStripMenuItem.Text = "VER CITAS AGENDADAS";
            this.TsBtnVerCitasAgendadasToolStripMenuItem.ToolTipText = "MUESTRA LAS CITAS AGENDADAS";
            this.TsBtnVerCitasAgendadasToolStripMenuItem.Click += new System.EventHandler(this.TsBtnVerCitasAgendadasToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // TSBtnAbout
            // 
            this.TSBtnAbout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSBtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("TSBtnAbout.Image")));
            this.TSBtnAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TSBtnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBtnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnAbout.Name = "TSBtnAbout";
            this.TSBtnAbout.Size = new System.Drawing.Size(81, 49);
            this.TSBtnAbout.Text = "ACERCA DE...";
            this.TSBtnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TSBtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnAbout.Click += new System.EventHandler(this.TSBtnAbout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // TSBtnSalir
            // 
            this.TSBtnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSBtnSalir.Image = global::SisCons.Properties.Resources.door_in;
            this.TSBtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TSBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBtnSalir.Name = "TSBtnSalir";
            this.TSBtnSalir.Size = new System.Drawing.Size(45, 49);
            this.TSBtnSalir.Text = "SALIR";
            this.TSBtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TSBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBtnSalir.ToolTipText = "SALIR DE LA APLICACION";
            this.TSBtnSalir.Click += new System.EventHandler(this.TSBtnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.m_head_blend;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 669);
            this.Controls.Add(this.TsbMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE CONSULTAS |MENU PRINCIPAL";
            this.TsbMenu.ResumeLayout(false);
            this.TsbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TsbMenu;
        private System.Windows.Forms.ToolStripButton TsBtnPacientes;
        private System.Windows.Forms.ToolStripButton TsBtnDoctores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TsBtnCitas;
        private System.Windows.Forms.ToolStripButton TsBtnRegDiagnostico;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton TsBtnConsultas;
        private System.Windows.Forms.ToolStripMenuItem TsBtnVerHistorialDeUnPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem TsBtnVerCitasAgendadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton TSBtnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSBtnSalir;
    }
}

