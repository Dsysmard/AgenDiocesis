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
    public partial class FrmCitas : Form
    {
        public FrmCitas()
        {
            InitializeComponent();
        }
       
        public String clave;
        private int clv;
        private bool Estado = true;

        public int Clave
        {
            set { clv = value; }
            get { return clv; }
        }
        public bool TipoEstado
        {
            set { Estado = value; }
            get { return Estado; }
        }
        
        public int estado;

        public void GuardaNuevo()
        {

            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();                                                   //le
            SqlCommand comando = new SqlCommand("insert into TblCitas (FolioCitas,Clave_Pacientes,Nombre,ApellidoPat,ApellidoMat,Clave_Doctores,Hora,Estatura,Peso,Temperatura,Precion,fecha)values ('" + TxtFolioCitas.Text + "','" + TxtClvPaciente.Text + "','" + TxtNombre.Text + "','" + TxtApPat.Text + "','" + TxtApMat.Text + "','" + CmbDoctor.SelectedValue.ToString() + "','" + TxtHora.Text + "','" + TxtEstatura.Text + "','" + TxtPeso.Text + "','" + TxtTemperatura.Text + "','" + TxtPresion.Text + "','" + TxtFecha.Text + "')", cnn);
            // DataSet ds = new DataSet();
            comando.ExecuteNonQuery();
            cnn.Close();

        }
        private void CargaEditar()
        {
           // CargaClasificacion();
          //  this.txtNumHab.Enabled = false;
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("select *from TblCitas where FolioCitas=" + clv, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.TxtFolioCitas.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            this.TxtClvPaciente.Text  = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            this.TxtNombre.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            this.TxtApPat.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            this.TxtApMat.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            this.CmbDoctor.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            this.TxtHora.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            this.TxtEstatura.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            this.TxtPeso.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            this.TxtTemperatura.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();
            this.TxtPresion.Text = ds.Tables[0].Rows[0].ItemArray[10].ToString();
            this.TxtFecha.Text = ds.Tables[0].Rows[0].ItemArray[11].ToString();
            BtnBuscarReg.Enabled = false;
            BtnAgregar.Enabled = false;

                       // seleccionarClasificacion();
        }
        public void modifica()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update TblCitas set FolioCitas='" + TxtFolioCitas.Text + "',Clave_Pacientes='" + TxtClvPaciente.Text + "',Nombre='" + TxtNombre.Text + "',ApellidoPat='" + TxtApPat.Text + "',ApellidoMat='" + TxtApMat.Text + "',Clave_Doctores='" + CmbDoctor.SelectedValue.ToString() + "',Hora='" + TxtHora.Text + "',Estatura='" + TxtEstatura.Text + "',Peso='" + TxtPeso.Text + "',Temperatura='" + TxtTemperatura.Text + "',Precion='" + TxtPresion.Text + "',fecha='" + TxtFecha.Text + "' where FolioCitas=" + clv, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        private void CargaDoctores()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("select  Clave_Doctores,Nombre from TblDoctores", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            CmbDoctor.DataSource = ds.Tables[0];
            CmbDoctor.DisplayMember = "Nombre";
            CmbDoctor.ValueMember = "Clave_Doctores";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmPacientes addpaciente = new FrmPacientes();
            addpaciente.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtClvPaciente.Text == "")
            {
                MessageBox.Show("FALTA LA CLAVE DEL PACIENTE", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtClvPaciente.Focus();
            }
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("FALTA EL NOMBRE", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombre.Focus();
            }
            else if (TxtApPat.Text == "")
            {
                MessageBox.Show("FALTA EL APELLIDO PATERNO", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtApPat.Focus();
            }
            else if (TxtApMat.Text == "")
            {
                MessageBox.Show("FALTA EL APELLIDO MATERNO", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtApMat.Focus();
            }
            else if (CmbDoctor.Text == "")
            {
                MessageBox.Show("FALTA ELEGIR EL DOCTOR", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbDoctor.Focus();
            }
            else if (TxtHora.Text == "__:__")
            {
                MessageBox.Show("FALTA ESPECIFICAR LA HORA", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtHora.Focus();
            }
            else if (TxtEstatura.Text == "")
            {
                MessageBox.Show("FALTA LA ESTATURA", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEstatura.Focus();
            }
            else if (TxtFecha.Text == "/" || TxtFecha.Text == "__/__/____")
            {
                MessageBox.Show("FALTA LA FECHA DE LA CITA", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtFecha.Focus();
            }
            else if (TxtPeso.Text == "")
            {
                MessageBox.Show("FALTA EL PESO", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPeso.Focus();
            }
            else if (TxtTemperatura.Text == "")
            {
                MessageBox.Show("FALTA LA TEMPERATURA", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTemperatura.Focus();
            }
            else if (TxtPresion.Text == "")
            {
                MessageBox.Show("FALTA LA PRESION", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPresion.Focus();
            }
            else
            {
                try
                {
                    //if (CompruebaCampos() == true)
                    //{

                    if (Estado == true)
                    {
                        GuardaNuevo();
                        MessageBox.Show("REGISTRO GUARDADO", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnGuardar.Enabled = false;
                        BtnBuscarReg.Enabled = false;
                        BtnAgregar.Enabled = false;
                        //  x.CargarDatos();
                    }
                    else
                    {
                        modifica();
                        MessageBox.Show("LOS CAMBIAS SE GUARDARON CORRECTAMENTE", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnGuardar.Enabled = false;
                        BtnBuscarReg.Enabled = false;
                        BtnAgregar.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR!!", "CITAS");
                }
                //BtnGuardar.Enabled = false;

                //Close();
                //}
            }
        }

        private void FrmCitas_Load(object sender, EventArgs e)
        {
            this.AutoClave();
           // CargaClass();
            //CargaClasificacion();
            //seleccionarClasificacion();
            if (Estado == false)
            {
                CargaEditar();
            }
            CargaDoctores();
        }

        private void obtiene_datos()
        {

            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();
            // SqlCommand comando = new SqlCommand("select Clave_Pacientes from TblPacientes ", cnn);
            // SqlDataAdapter da = new SqlDataAdapter(comando, cnn);
            SqlDataAdapter da = new SqlDataAdapter("select Clave_Pacientes,Nombre,ApellidoPat,ApellidoMat from TblPacientes where Clave_Pacientes =" + TxtClvPaciente.Text, cnn);
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                TxtNombre.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                TxtApPat.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                TxtApMat.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            }
            else
            {
                MessageBox.Show("LA CLAVE DEL PACIENTE NO EXISTE, DEBE AGREGARLA", "CITAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnAgregar.Enabled = true;
            }
        }
        public void AutoClave()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select FolioCitas from TblCitas ", cnn);
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);

            string s;

            int t = 0;
            int recordsAffected = da.Fill(dataTable);

            if (recordsAffected > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    s = dr[0].ToString();
                    t = Convert.ToInt32(s) + 1;
                }
                TxtFolioCitas.Text  = t.ToString();

            }
            //Close();
        }
        private void BtnBuscarReg_Click(object sender, EventArgs e)
        {
            
           obtiene_datos();
        }

        private void TxtClvPaciente_TextChanged(object sender, EventArgs e)
        {
            if(TxtClvPaciente.Text=="")
                BtnBuscarReg.Enabled = false;
            else
            BtnBuscarReg.Enabled = true;

        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            TxtFecha.Text=DtpFecha.Value.ToShortDateString();
        }

        private void TxtClvPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtApPat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtApMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void MskHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtPresion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        
    }
}