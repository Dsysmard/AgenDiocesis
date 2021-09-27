using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Menu
{
    public partial class FrmPacientes : Form
    {
        public FrmPacientes()
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
       
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("FALTA EL NOMBRE", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombre.Focus();
            }
            else if (TxtApPat.Text == "")
            {
                MessageBox.Show("FALTA EL APELLIDO PATERNO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtApPat.Focus();
            }
            else if (TxtApMat.Text == "")
            {
                MessageBox.Show("FALTA EL APELLIDO MATERNO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtApMat.Focus();
            }
            else if (TxtDomicilio.Text == "")
            {
                MessageBox.Show("FALTA EL DOMICILIO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDomicilio.Focus();
            }
            else if (TxtTelefono.Text == "")
            {
                MessageBox.Show("FALTA EL TELEFONO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTelefono.Focus();
            }
            else if (TxtFechaNac.Text == "/" || TxtFechaNac.Text == "__/__/____")
            {
                MessageBox.Show("FALTA LA FECHA DE NACIMIENTO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DtpFechaNac.Focus();
            }
            else if (CmbSexo.Text == "")
            {
                MessageBox.Show("FALTA ELEGIR EL SEXO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbSexo.Focus();
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("FALTA EL CORREO ELECTRONICO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEmail.Focus();
            }
            else
            {
                try
                {
                    
                    if (Estado == true)
                    {
                        GuardaNuevo();
                        MessageBox.Show("REGISTRO GUARDADO", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnGuardar.Enabled = false;
                        //  x.CargarDatos();
                    }
                    else
                    {
                        modifica();
                        MessageBox.Show("LOS CAMBIAS SE GUARDARON CORRECTAMENTE", "PACIENTES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnGuardar.Enabled = false;
                    }
                }
                catch 
                {
                    MessageBox.Show("ERROR!!", "PACIENTES");
                }
                
            }
             
        }
        public int estado;

        public void GuardaNuevo()
        {
            
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();                                                   //le
            SqlCommand comando = new SqlCommand("insert into TblPacientes (Clave_Pacientes,Nombre,ApellidoPat,ApellidoMat,Domicilio,Telefono,Sexo,fecha,email)values ('" + TxtClvPaciente.Text + "','" + TxtNombre.Text + "','" + TxtApPat.Text + "','" + TxtApMat.Text + "','" + TxtDomicilio.Text + "','" + TxtTelefono.Text + "','" + CmbSexo.Text + "','" + TxtFechaNac.Text + "','" + TxtEmail.Text + "')", cnn);
            // DataSet ds = new DataSet();
            comando.ExecuteNonQuery();
            cnn.Close();
        }
       

        private void CargaEditar()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            SqlDataAdapter da = new SqlDataAdapter("select * from TblPacientes where Clave_Pacientes=" + clv , conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.TxtClvPaciente.Text =  ds.Tables[0].Rows[0].ItemArray[0].ToString();
            this.TxtNombre.Text  = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            this.TxtApPat.Text   = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            this.TxtApMat.Text   = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            this.TxtDomicilio.Text  = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            this.TxtTelefono.Text   = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            this.TxtFechaNac.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();  
            this.CmbSexo.Text  = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            this.TxtEmail.Text  = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            
           
        }
        public void modifica()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update TblPacientes set Clave_Pacientes='" + TxtClvPaciente.Text + "',Nombre='" + TxtNombre.Text + "',ApellidoPat='" + TxtApPat.Text + "',ApellidoMat='" + TxtApMat.Text + "',Domicilio='" + TxtDomicilio.Text + "',Telefono='" + TxtTelefono.Text + "',Sexo='" + CmbSexo.Text + "',fecha='" + TxtFechaNac.Text + "',email='" + TxtEmail.Text + "' where Clave_Pacientes=" + clv, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public  void AutoClave()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();
            
            SqlDataAdapter da = new SqlDataAdapter("select Clave_Pacientes from TblPacientes ", cnn);
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
                TxtClvPaciente.Text = t.ToString();
                
            }
            
        }
       
        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            AutoClave();
            if (Estado == false)
            {
                CargaEditar();
            }  
        }

        private void TxtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            TxtFechaNac.Text= DtpFechaNac.Value.ToShortDateString();
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

        private void TxtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

       
   }
}
    

