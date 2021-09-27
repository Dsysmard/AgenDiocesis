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
    public partial class FrmPrincipalCitas : Form
    {
        public FrmPrincipalCitas()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblCitas.FolioCitas,dbo.TblCitas.Clave_Pacientes,dbo.TblCitas.Nombre,dbo.TblCitas.ApellidoPat,dbo.TblDoctores.Nombre as Doctor,dbo.TblCitas.Hora,dbo.TblCitas.Estatura,dbo.TblCitas.Peso,dbo.TblCitas.Temperatura,dbo.TblCitas.Precion,dbo.TblCitas.fecha FROM dbo.TblCitas INNER JOIN dbo.TblDoctores ON dbo.TblDoctores.Clave_Doctores=dbo.TblCitas.Clave_Doctores ", cnn);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblCitas.FolioCitas,dbo.TblCitas.Clave_Pacientes,dbo.TblCitas.Nombre,dbo.TblCitas.ApellidoPat,dbo.TblDoctores.Nombre as Doctor,dbo.TblCitas.Hora,dbo.TblCitas.Estatura,dbo.TblCitas.Peso,dbo.TblCitas.Temperatura,dbo.TblCitas.Precion,dbo.TblCitas.fecha FROM dbo.TblCitas INNER JOIN dbo.TblDoctores ON dbo.TblDoctores.Clave_Doctores=dbo.TblCitas.FolioCitas ", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvDatos.DataSource = ds;
            DgvDatos.DataMember = ds.Tables[0].TableName;
            //DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
        }


        private void TsBtnNuevo_Click(object sender, EventArgs e)
        {
            FrmCitas frmcitas = new FrmCitas();
           
            frmcitas.ShowDialog();
            CargarDatos();
        }

        private void TsBtnEditar_Click(object sender, EventArgs e)
        {

            FrmCitas n = new FrmCitas();
            n.Text = "EDITAR REGISTRO DE CITA";
            n.TipoEstado = false;
            n.Clave = Convert.ToInt32(DgvDatos.SelectedRows[0].Cells[0].Value.ToString());
            n.ShowDialog();
            CargarDatos();
            // modifica();
            DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
        }

        private void FrmPrincipalCitas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void EliminarCita()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from TblCitas where FolioCitas = " + this.DgvDatos.SelectedRows[0].Cells[0].Value, conexion);
            comando.ExecuteNonQuery();

        }

        private void TsBtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Seguro que desea eliminar la cita seleccionada?\n", "Eliminar ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                EliminarCita();
                CargarDatos();
                DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
            }

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
                    cad1 = fila.Cells[2].Value.ToString();
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