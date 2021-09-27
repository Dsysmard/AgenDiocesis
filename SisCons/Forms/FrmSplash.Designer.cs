namespace Menu
{
    partial class FrmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.LblNombre1 = new System.Windows.Forms.Label();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            this.PgbCargando = new System.Windows.Forms.ProgressBar();
            this.TmrProgreso = new System.Windows.Forms.Timer(this.components);
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblNombre2 = new System.Windows.Forms.Label();
            this.LblCargando = new System.Windows.Forms.Label();
            this.LblPorcentaje = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre1
            // 
            this.LblNombre1.AutoSize = true;
            this.LblNombre1.BackColor = System.Drawing.Color.White;
            this.LblNombre1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre1.Location = new System.Drawing.Point(112, 77);
            this.LblNombre1.Name = "LblNombre1";
            this.LblNombre1.Size = new System.Drawing.Size(190, 48);
            this.LblNombre1.TabIndex = 0;
            this.LblNombre1.Text = "AGENDA";
            // 
            // PtbLogo
            // 
            this.PtbLogo.BackColor = System.Drawing.SystemColors.Window;
            this.PtbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PtbLogo.BackgroundImage")));
            this.PtbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PtbLogo.Location = new System.Drawing.Point(22, 61);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(89, 84);
            this.PtbLogo.TabIndex = 1;
            this.PtbLogo.TabStop = false;
            // 
            // PgbCargando
            // 
            this.PgbCargando.BackColor = System.Drawing.Color.White;
            this.PgbCargando.Location = new System.Drawing.Point(22, 151);
            this.PgbCargando.Name = "PgbCargando";
            this.PgbCargando.Size = new System.Drawing.Size(374, 23);
            this.PgbCargando.TabIndex = 2;
            // 
            // TmrProgreso
            // 
            this.TmrProgreso.Tick += new System.EventHandler(this.TmrProgreso_Tick);
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.BackColor = System.Drawing.Color.White;
            this.LblProducto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(117, 61);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(71, 13);
            this.LblProducto.TabIndex = 3;
            this.LblProducto.Text = "PRODUCTO:";
            // 
            // LblNombre2
            // 
            this.LblNombre2.AutoSize = true;
            this.LblNombre2.BackColor = System.Drawing.Color.White;
            this.LblNombre2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre2.Location = new System.Drawing.Point(215, 125);
            this.LblNombre2.Name = "LblNombre2";
            this.LblNombre2.Size = new System.Drawing.Size(126, 16);
            this.LblNombre2.TabIndex = 4;
            this.LblNombre2.Text = "SISTEMA DE CITAS";
            // 
            // LblCargando
            // 
            this.LblCargando.AutoSize = true;
            this.LblCargando.BackColor = System.Drawing.Color.White;
            this.LblCargando.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargando.Location = new System.Drawing.Point(141, 191);
            this.LblCargando.Name = "LblCargando";
            this.LblCargando.Size = new System.Drawing.Size(84, 16);
            this.LblCargando.TabIndex = 5;
            this.LblCargando.Text = "CARGANDO:";
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.AutoSize = true;
            this.LblPorcentaje.BackColor = System.Drawing.Color.White;
            this.LblPorcentaje.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPorcentaje.Location = new System.Drawing.Point(251, 191);
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(22, 16);
            this.LblPorcentaje.TabIndex = 6;
            this.LblPorcentaje.Text = "%";
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.BackColor = System.Drawing.Color.White;
            this.LblNumero.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumero.Location = new System.Drawing.Point(222, 191);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(32, 16);
            this.LblNumero.TabIndex = 7;
            this.LblNumero.Text = "100";
            // 
            // LblAdvertencia
            // 
            this.LblAdvertencia.BackColor = System.Drawing.Color.White;
            this.LblAdvertencia.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdvertencia.Location = new System.Drawing.Point(19, 207);
            this.LblAdvertencia.Name = "LblAdvertencia";
            this.LblAdvertencia.Size = new System.Drawing.Size(377, 32);
            this.LblAdvertencia.TabIndex = 8;
            this.LblAdvertencia.Text = "Desarrollado por Departamento de Sistemas © Copyright 2013 Obispado de Piedras Ne" +
    "gras Todos los Derechos Reservados";
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SisCons.Properties.Resources.header_bkg_wol2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(417, 295);
            this.Controls.Add(this.LblAdvertencia);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblPorcentaje);
            this.Controls.Add(this.LblCargando);
            this.Controls.Add(this.LblNombre2);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.PgbCargando);
            this.Controls.Add(this.PtbLogo);
            this.Controls.Add(this.LblNombre1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre1;
        private System.Windows.Forms.PictureBox PtbLogo;
        private System.Windows.Forms.ProgressBar PgbCargando;
        private System.Windows.Forms.Timer TmrProgreso;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblNombre2;
        private System.Windows.Forms.Label LblCargando;
        private System.Windows.Forms.Label LblPorcentaje;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblAdvertencia;

    }
}