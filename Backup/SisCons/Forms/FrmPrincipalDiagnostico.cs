using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;  
namespace Menu
{
    public partial class FrmPrincipalDiagnostico : Form
    {
        public FrmPrincipalDiagnostico()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblPacientes.Clave_Pacientes,dbo.TblPacientes.Nombre,dbo.TblPacientes.ApellidoPat,dbo.TblPacientes.ApellidoMat,dbo.TblPacientes.Domicilio,dbo.TblPacientes.Telefono,TblPacientes.Sexo,TblPacientes.fecha,TblPacientes.email FROM dbo.TblPacientes ", cnn);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblConsultas.Folio,dbo.TblConsultas.Fecha,dbo.TblPacientes.Clave_Pacientes,dbo.TblPacientes.Nombre,dbo.TblPacientes.ApellidoPat,dbo.TblPacientes.ApellidoMat,dbo.TblPacientes.Domicilio,dbo.TblDoctores.Nombre as Doctor,dbo.TblCitas.Hora,dbo.TblCitas.Estatura,dbo.TblCitas.Peso,dbo.TblCitas.Temperatura,dbo.TblCitas.Precion,dbo.TblConsultas.Sintomas,dbo.TblConsultas.Enfermedad FROM TblConsultas INNER JOIN dbo.TblDoctores ON dbo.TblDoctores.Clave_Doctores=dbo.TblCitas.Clave_Doctores INNER JOIN dbo.TblPacientes ON dbo.TblPacientes.Clave_Pacientes=TblConsultas.Clave_Pacientes ", cnn);
           // SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblConsultas.Folio,dbo.TblConsultas.Fecha,dbo.TblConsultas.Clave_Pacientes,dbo.TblCitas.Nombre,dbo.TblCitas.ApellidoPat,dbo.TblCitas.ApellidoMat,dbo.TblPacientes.Domicilio,dbo.TblConsultas.Hora,dbo.TblConsultas.Estatura,dbo.TblConsultas.Peso,dbo.TblConsultas.Temperatura,dbo.TblConsultas.Precion,dbo.TblConsultas.Sintomas,dbo.TblConsultas.Enfermedad FROM TblConsultas,TblCitas,TblPacientes WHERE dbo.TblCitas.Clave_Pacientes =dbo.TblPacientes.Clave_Pacientes ", cnn);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblCitas.Clave_Pacientes, dbo.TblPacientes.Nombre, dbo.TblPacientes.ApellidoPat, dbo.TblPacientes.ApellidoMat, dbo.TblPacientes.Domicilio,dbo.TblCitas.Hora, dbo.TblCitas.Estatura, dbo.TblCitas.Peso, dbo.TblCitas.Temperatura, dbo.TblCitas.Precion FROM dbo.TblCitas,dbo.TblPacientes WHERE(dbo.TblCitas.Clave_Pacientes =dbo.TblPacientes.Clave_Pacientes)", cnn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblConsultas.Folio,dbo.TblConsultas.Fecha,dbo.TblConsultas.Clave_Pacientes,dbo.TblPacientes.Nombre,dbo.TblPacientes.ApellidoPat, dbo.TblPacientes.ApellidoMat, dbo.TblPacientes.Domicilio,dbo.TblDoctores.Nombre as Doctor,dbo.TblConsultas.Hora, dbo.TblConsultas.Estatura, dbo.TblConsultas.Peso, dbo.TblConsultas.Temperatura, dbo.TblConsultas.Precion,dbo.TblConsultas.Sintomas,dbo.TblConsultas.Enfermedad,dbo.TblConsultas.FechaCita FROM dbo.TblConsultas INNER JOIN dbo.TblDoctores ON dbo.TblDoctores.Clave_Doctores=dbo.TblConsultas.Clave_Doctores INNER JOIN dbo.TblPacientes ON dbo.TblPacientes.Clave_Pacientes=dbo.TblConsultas.Clave_Pacientes",cnn);
               DataSet ds = new DataSet();
            da.Fill(ds);
            DgvDatos.DataSource = ds;
            DgvDatos.DataMember = ds.Tables[0].TableName;
        }

        private void TsBtnNuevo_Click(object sender, EventArgs e)
        {
            FrmHistorial frmhistorial = new FrmHistorial();
            frmhistorial.ShowDialog();
            CargarDatos();
            frmhistorial.AutoClave();
        }

        private void TsBtnEditar_Click(object sender, EventArgs e)
        {
            FrmHistorial n = new FrmHistorial();
            n.Text = "EDITAR REGISTRO DE DIAGNOSTICO DE UN PACIENTE";
            n.TipoEstado = false;
            n.Clave = Convert.ToInt32(DgvDatos.SelectedRows[0].Cells[0].Value.ToString());
            n.ShowDialog();
            CargarDatos();
            
            // modifica();
            DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
           
            
        }

        private void TsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            String cad1;
            errorProvider1.Clear();
            try
            {
                //ncol = DgvDatos.SortedColumn.Index;
                foreach (DataGridViewRow fila in DgvDatos.Rows)
                {
                    TxtBuscar.Text = TxtBuscar.Text.ToUpper();
                    cad1 = fila.Cells[3].Value.ToString();
                    if (cad1.StartsWith(TxtBuscar.Text) == true)
                    {
                        fila.Selected = true;
                        break;
                    }
                }
                TxtBuscar.SelectionStart = TxtBuscar.Text.Length;
            }
            catch
            {
                errorProvider1.SetError(TxtBuscar, "NO EXISTE EL NOMBRE...!!");
                TxtBuscar.Focus();
            }
        }

        private void FrmPrincipalDiagnostico_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);

        }

        private void EliminarPaciente()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from TblConsultas where Folio = " + this.DgvDatos.SelectedRows[0].Cells[0].Value, conexion);
            comando.ExecuteNonQuery();

        }
        private void TsBtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Seguro que desea eliminar el Paciente?\n", "Eliminar ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                EliminarPaciente();
                CargarDatos();
                DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);

        }
    }
}