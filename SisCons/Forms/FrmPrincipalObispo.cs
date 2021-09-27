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
    public partial class FrmPrincipalDoctores : Form
    {
        public FrmPrincipalDoctores()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {

            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblObispo.Clave_Obispo, dbo.TblObispo.Nombre, dbo.TblObispo.ApellidoPat, dbo.TblObispo.ApellidoMat, dbo.TblObispo.Domicilio, dbo.TblObispo.Telefono, dbo.TblObispo.Sexo, dbo.TblObispo.fecha, dbo.TblObispo.Cedula, dbo.TblObispo.Especialidad FROM dbo.TblObispo", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DgvDatos.DataSource = ds;
            DgvDatos.DataMember = ds.Tables[0].TableName;
        }
        private void TsBtnNuevo_Click(object sender, EventArgs e)
        {
            /*FrmDoctores frmdoctores = new FrmDoctores();
            frmdoctores.ShowDialog();*/
            FrmDoctores frmdoctores = new FrmDoctores();
            frmdoctores.ShowDialog();
            CargarDatos();
            frmdoctores.AutoClave();
        }

        private void TsBtnEditar_Click(object sender, EventArgs e)
        {

            FrmDoctores n = new FrmDoctores();
            n.Text = "EDITAR REGISTRO DE DOCTOR";
            n.TipoEstado = false;
            n.Clave = Convert.ToInt32(DgvDatos.SelectedRows[0].Cells[0].Value.ToString());
            n.ShowDialog();
            CargarDatos();
            //  modifica();

            DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
        }

        private void FrmPrincipalDoctores_Load(object sender, EventArgs e)
        {
            CargarDatos();
            DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
        }

        private void EliminarDoctor()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            conexion.Open();
            SqlCommand comando = new SqlCommand("delete from TblObispo where Clave_Obispo = " + this.DgvDatos.SelectedRows[0].Cells[0].Value, conexion);
            comando.ExecuteNonQuery();

        }

        private void TsBtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Seguro que desea eliminar al Obispo?\n", "Eliminar ...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                EliminarDoctor();
                CargarDatos();
                DgvDatos.Sort(DgvDatos.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void TsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void TxtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            String cad1;
            errorProvider1.Clear();
            try
            {
                //ncol = DgvDatos.SortedColumn.Index;
                foreach (DataGridViewRow fila in DgvDatos.Rows)
                {
                    TxtBuscar.Text = TxtBuscar.Text.ToUpper();
                    cad1 = fila.Cells[1].Value.ToString();
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

