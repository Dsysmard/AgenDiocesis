using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Drawing.Printing;
namespace Menu
{
    public partial class FrmVerCitas : Form
    {
        public FrmVerCitas()
        {
            InitializeComponent();
        }
  //      DataGridViewPrinter MyDataGridViewPrinter;
        private void RdbMostrarTodo_CheckedChanged(object sender, EventArgs e)
        {
            
            LblSelectDoctor.Visible = false;
            CmbDoctores.Visible = false;
        }

        private void RdbMostraPorDoctor_CheckedChanged(object sender, EventArgs e)
        {
            LblSelectDoctor.Visible = true;
            CmbDoctores.Visible = true;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargaDoctores()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("select  Clave_Obispo,Nombre from TblObispo", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CmbDoctores.DataSource = ds.Tables[0];
            CmbDoctores.DisplayMember = "Nombre";
            CmbDoctores.ValueMember = "Clave_Obispo";
        }
        private void CargarDatos()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblCitas.FolioCitas,dbo.TblCitas.Clave_Laicos,dbo.TblCitas.Nombre,dbo.TblCitas.ApellidoPat,dbo.TblObispo.Nombre as Doctor,dbo.TblCitas.Hora,dbo.TblCitas.Estatura,dbo.TblCitas.Peso,dbo.TblCitas.Temperatura,dbo.TblCitas.Precion,dbo.TblCitas.fecha FROM dbo.TblCitas INNER JOIN dbo.TblObispo ON dbo.TblObispo.Clave_Obispo=dbo.TblCitas.Clave_Obispo WHERE TblCitas.fecha BETWEEN '" + DtpDel.Text + "' AND '" + DtpAl.Text + "'", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvDatos.DataSource = ds;
            DgvDatos.DataMember = ds.Tables[0].TableName;
            //DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
        }
        private void CargarDatos2()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblCitas.FolioCitas,dbo.TblCitas.Clave_Laicos,dbo.TblCitas.Nombre,dbo.TblCitas.ApellidoPat,dbo.TblObispo.Nombre as Doctor,dbo.TblCitas.Hora,dbo.TblCitas.Estatura,dbo.TblCitas.Peso,dbo.TblCitas.Temperatura,dbo.TblCitas.Precion,dbo.TblCitas.fecha FROM dbo.TblCitas INNER JOIN dbo.TblObispo ON dbo.TblObispo.Clave_Obispo=dbo.TblCitas.Clave_Obispo WHERE TblCitas.Clave_Obispo='" + CmbDoctores.SelectedValue.ToString() + "'and TblCitas.fecha BETWEEN '" + DtpDel.Text + "' AND '" + DtpAl.Text + "'", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvDatos.DataSource = ds;
            DgvDatos.DataMember = ds.Tables[0].TableName;
            //DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
        }
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
           
                if (DtpDel.Value <= DtpAl.Value)
            {

                if (RdbMostrarTodo.Checked == true)
                    CargarDatos();
                else
                    CargarDatos2();
            }
            else
            {
                MessageBox.Show("LA FECHA INICIAL DEBE SER MENOR O IGUAL A LA FECHA FINAL", "VER CITAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmVerCitas_Load(object sender, EventArgs e)
        {
            CargaDoctores();
           // CargarDatos();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO HAY IMPRESORAS INSTALADAS", "VER CITAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

       
    }
}