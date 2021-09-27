using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace Menu
{
    public partial class FrmVerHistorial : Form
    {
        public FrmVerHistorial()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblConsultas.Folio,dbo.TblConsultas.Fecha,dbo.TblConsultas.Clave_Pacientes,dbo.TblPacientes.Nombre,dbo.TblPacientes.ApellidoPat, dbo.TblPacientes.ApellidoMat, dbo.TblPacientes.Domicilio,dbo.TblDoctores.Nombre as Doctor,dbo.TblConsultas.Hora, dbo.TblConsultas.Estatura, dbo.TblConsultas.Peso, dbo.TblConsultas.Temperatura, dbo.TblConsultas.Precion,dbo.TblConsultas.Sintomas,dbo.TblConsultas.Enfermedad FROM dbo.TblConsultas INNER JOIN dbo.TblDoctores ON dbo.TblDoctores.Clave_Doctores=dbo.TblConsultas.Clave_Doctores INNER JOIN dbo.TblPacientes ON dbo.TblPacientes.Clave_Pacientes=dbo.TblConsultas.Clave_Pacientes WHERE TblConsultas.Clave_Pacientes='" + CmbPacientes.SelectedValue.ToString() + "'" , cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvDatos.DataSource = ds;
            DgvDatos.DataMember = ds.Tables[0].TableName;
        }

        public void CargarDatos2()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblConsultas.Folio,dbo.TblConsultas.Fecha,dbo.TblConsultas.Clave_Pacientes,dbo.TblPacientes.Nombre,dbo.TblPacientes.ApellidoPat, dbo.TblPacientes.ApellidoMat, dbo.TblPacientes.Domicilio,dbo.TblDoctores.Nombre as Doctor,dbo.TblConsultas.Hora, dbo.TblConsultas.Estatura, dbo.TblConsultas.Peso, dbo.TblConsultas.Temperatura, dbo.TblConsultas.Precion,dbo.TblConsultas.Sintomas,dbo.TblConsultas.Enfermedad FROM dbo.TblConsultas INNER JOIN dbo.TblDoctores ON dbo.TblDoctores.Clave_Doctores=dbo.TblConsultas.Clave_Doctores INNER JOIN dbo.TblPacientes ON dbo.TblPacientes.Clave_Pacientes=dbo.TblConsultas.Clave_Pacientes WHERE TblConsultas.Clave_Pacientes='" + CmbPacientes.SelectedValue.ToString() + "'and TblConsultas.fecha BETWEEN '" + DtpDel.Text + "' AND '" + DtpAl.Text + "'", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvDatos.DataSource = ds;
            DgvDatos.DataMember = ds.Tables[0].TableName;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RdbMostrarPeriodos_CheckedChanged(object sender, EventArgs e)
        {
            this.LblAl.Visible = true;
            this.LblDel.Visible = true;
            this.DtpDel.Visible = true;
            this.DtpAl.Visible = true;
        }

        private void RdbMostrarTodos_CheckedChanged(object sender, EventArgs e)
        {
            this.LblAl.Visible = false;
            this.LblDel.Visible = false;
            this.DtpDel.Visible = false;
            this.DtpAl.Visible = false;
        }

        private void CargaPacientes()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("select  Clave_Pacientes,Nombre from TblPacientes", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CmbPacientes.DataSource = ds.Tables[0];
            CmbPacientes.DisplayMember = "Nombre";
            CmbPacientes.ValueMember = "Clave_Pacientes";
        }


        private void FrmVerHistorial_Load(object sender, EventArgs e)
        {
            CargaPacientes();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
             if (RdbMostrarTodos.Checked == true)
            {
                 CargarDatos();
            }
          
            else 
            {
                if (DtpDel.Value <= DtpAl.Value)
                {
              
                    CargarDatos2();
                }
                else
                {
                    MessageBox.Show("LA FECHA INICIAL DEBE SER MENOR O IGUAL A LA FECHA FINAL", "VER HISTORIAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO HAY IMPRESORAS INSTALADAS", "VER HISTORIAL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}