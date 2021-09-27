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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
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
        public void AutoClave()
        {
            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select Folio from TblConsultas ", cnn);
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
                TxtFolio.Text = t.ToString();

            }
           
        }
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            AutoClave();
            if (Estado == false)
            {
                CargaEditar();
            }
            CargaDoctores();
            //ToolTip.SetToolTip(BtnBuscarReg, "BUSCA REGISTROS");
          //  ToolTip.SetToolTip(BtnVerCitas, "Boton Cancelar");

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtClave.Text == "")
            {
                MessageBox.Show("FALTA LA CLAVE DEL PACIENTE", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtClave.Focus();
            }
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("FALTA EL NOMBRE", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNombre.Focus();
            }
            else if (TxtApPat.Text == "")
            {
                MessageBox.Show("FALTA EL APELLIDO PATERNO", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtApPat.Focus();
            }
            else if (TxtApMat.Text == "")
            {
                MessageBox.Show("FALTA EL APELLIDO MATERNO", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtApMat.Focus();
            }
            else if (TxtDomicilio.Text == "")
            {
                MessageBox.Show("FALTA EL DOMICILIO", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDomicilio.Focus();
            }
            else if (CmbDoctor.Text == "")
            {
                MessageBox.Show("FALTA ELEGIR EL DOCTOR", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbDoctor.Focus();
            }
            else if (TxtHora.Text == "__:__")
            {
                MessageBox.Show("FALTA ESPECIFICAR LA HORA", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtHora.Focus();
            }
            else if (TxtEstatura.Text == "")
            {
                MessageBox.Show("FALTA LA ESTATURA", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEstatura.Focus();
            }
            else if (TxtFechaCita.Text == "/" || TxtFechaCita.Text == "__/__/____")
            {
                MessageBox.Show("FALTA LA FECHA DE LA CITA", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtFechaCita.Focus();
            }
            else if (TxtPeso.Text == "")
            {
                MessageBox.Show("FALTA EL PESO", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPeso.Focus();
            }
            else if (TxtTemperatura.Text == "")
            {
                MessageBox.Show("FALTA LA TEMPERATURA", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtTemperatura.Focus();
            }
            else if (TxtPresion.Text == "")
            {
                MessageBox.Show("FALTA LA PRESION", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPresion.Focus();
            }
            else if (TxtSintomas.Text == "")
            {
                MessageBox.Show("FALTAN LOS SINTOMAS", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtSintomas.Focus();
            }
            else if (TxtEnfermedad.Text == "")
            {
                MessageBox.Show("FALTA LA ENFERMEDAD", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtEnfermedad.Focus();
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
                        MessageBox.Show("REGISTRO GUARDADO", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnGuardar.Enabled = false;
                        BtnBuscarReg.Enabled = false;
                        //  x.CargarDatos();
                    }
                    else
                    {
                        modifica();
                        MessageBox.Show("LOS CAMBIAS SE GUARDARON CORRECTAMENTE", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnGuardar.Enabled = false;
                        BtnBuscarReg.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR!!", "DIAGNOSTICO");
                }
                //BtnGuardar.Enabled = false;

                //Close();
                //}
            }

        }

        public int estado;
        public void GuardaNuevo()
        {

            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();                                                   //le
            SqlCommand comando = new SqlCommand("insert into TblConsultas (Folio,Fecha,Clave_Pacientes,Clave_Doctores,Hora,Estatura,Peso,Temperatura,Precion,Sintomas,Enfermedad,FechaCita)values ('" + TxtFolio.Text + "','" + DtpFecha.Text + "','" + TxtClave.Text + "','" + CmbDoctor.SelectedValue.ToString() + "','" + TxtHora.Text + "','" + TxtEstatura.Text + "','" + TxtPeso.Text + "','" + TxtTemperatura.Text + "','" + TxtPresion.Text + "','" + TxtSintomas.Text + "','" + TxtEnfermedad.Text + "','" + TxtFechaCita.Text + "')", cnn);
            // DataSet ds = new DataSet();
            comando.ExecuteNonQuery();
            cnn.Close();
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
        private void CargaEditar()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            //SqlDataAdapter da = new SqlDataAdapter("select * from TblConsultas where Folio=" + clv, conexion);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblConsultas.Folio,dbo.TblConsultas.Fecha,dbo.TblConsultas.Clave_Pacientes,dbo.TblPacientes.Nombre,dbo.TblPacientes.ApellidoPat, dbo.TblPacientes.ApellidoMat, dbo.TblPacientes.Domicilio,dbo.TblDoctores.Nombre as Doctor,dbo.TblConsultas.Hora, dbo.TblConsultas.Estatura, dbo.TblConsultas.Peso, dbo.TblConsultas.Temperatura, dbo.TblConsultas.Precion,dbo.TblConsultas.Sintomas,dbo.TblConsultas.Enfermedad,dbo.TblConsultas.FechaCita FROM dbo.TblConsultas INNER JOIN dbo.TblDoctores ON dbo.TblDoctores.Clave_Doctores=dbo.TblConsultas.Clave_Doctores INNER JOIN dbo.TblPacientes ON dbo.TblPacientes.Clave_Pacientes=dbo.TblConsultas.Clave_Pacientes where Folio=" + clv, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.TxtFolio.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            this.DtpFecha.Text= ds.Tables[0].Rows[0].ItemArray[1].ToString();
            this.TxtClave.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            this.TxtNombre.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            this.TxtApPat.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            this.TxtApMat.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            this.TxtDomicilio.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            this.CmbDoctor.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
            this.TxtHora.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
            this.TxtEstatura.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();
            this.TxtPeso.Text = ds.Tables[0].Rows[0].ItemArray[10].ToString();
            this.TxtTemperatura.Text = ds.Tables[0].Rows[0].ItemArray[11].ToString();
            this.TxtPresion.Text = ds.Tables[0].Rows[0].ItemArray[12].ToString();
            this.TxtSintomas.Text = ds.Tables[0].Rows[0].ItemArray[13].ToString();
            this.TxtEnfermedad.Text = ds.Tables[0].Rows[0].ItemArray[14].ToString();
            this.TxtFechaCita.Text = ds.Tables[0].Rows[0].ItemArray[15].ToString();
            BtnBuscarReg.Enabled = false;
            BtnVerCitas.Enabled = false;
        }

        public void modifica()
        {
            SqlConnection conexion = new SqlConnection(Conexion.cad);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("update TblConsultas set Folio='" + TxtFolio.Text + "',Fecha='" + DtpFecha.Text + "',Clave_Pacientes='" + TxtClave.Text + "',Clave_Doctores='" + CmbDoctor.SelectedValue.ToString() + "',Hora='" + TxtHora.Text + "',Estatura='" + TxtEstatura.Text + "',Peso='" + TxtPeso.Text + "',Temperatura='" + TxtTemperatura.Text + "',Precion='" + TxtPresion.Text + "',Sintomas='" + TxtSintomas.Text + "',Enfermedad='" + TxtEnfermedad.Text + "',FechaCita='" + TxtFechaCita.Text + "' where Folio=" + clv, conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

       
        private void obtiene_datos()
        {




            SqlConnection cnn = new SqlConnection(Conexion.cad);
            cnn.Open();
            
            //SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblCitas.Clave_Pacientes, dbo.TblPacientes.Nombre, dbo.TblPacientes.ApellidoPat, dbo.TblPacientes.ApellidoMat, dbo.TblPacientes.Domicilio,dbo.TblCitas.Hora, dbo.TblCitas.Estatura, dbo.TblCitas.Peso, dbo.TblCitas.Temperatura, dbo.TblCitas.Precion FROM dbo.TblCitas,dbo.TblPacientes WHERE dbo.TblPacientes.Clave_Pacientes =" + TxtClave.Text, cnn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT dbo.TblCitas.Clave_Pacientes, dbo.TblPacientes.Nombre, dbo.TblPacientes.ApellidoPat, dbo.TblPacientes.ApellidoMat, dbo.TblPacientes.Domicilio,dbo.TblCitas.Hora, dbo.TblCitas.Estatura, dbo.TblCitas.Peso, dbo.TblCitas.Temperatura, dbo.TblCitas.Precion FROM dbo.TblCitas,dbo.TblPacientes WHERE TblCitas.Fecha='" + TxtFechaCita.Text + "'AND dbo.TblPacientes.Clave_Pacientes =" + TxtClave.Text, cnn);
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                TxtNombre.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                TxtApPat.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                TxtApMat.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                TxtDomicilio.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
               // CmbDoctor.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                TxtHora.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                TxtEstatura.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
                TxtPeso.Text = ds.Tables[0].Rows[0].ItemArray[7].ToString();
                TxtTemperatura.Text = ds.Tables[0].Rows[0].ItemArray[8].ToString();
                TxtPresion.Text = ds.Tables[0].Rows[0].ItemArray[9].ToString();

            }
        }
        //public  void AutoClave()
        //{
        //    SqlConnection cnn = new SqlConnection(Conexion.cad);
        //    cnn.Open();
            
        //    SqlDataAdapter da = new SqlDataAdapter("select Clave_Pacientes from TblPacientes ", cnn);
        //    DataTable dataTable = new DataTable();
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);

        //    string s;

        //    int t = 0;
        //    int recordsAffected = da.Fill(dataTable);

        //    if (recordsAffected > 0)
        //    {
        //        foreach (DataRow dr in dataTable.Rows)
        //        {
        //            s = dr[0].ToString();
        //            t = Convert.ToInt32(s);
        //        }
        //       // TxtClvPaciente.Text = t.ToString();
                
        //    }
            
        //}
        private void BtnBuscarReg_Click(object sender, EventArgs e)
        {

           
               
                    SqlConnection cnn = new SqlConnection(Conexion.cad);
                    cnn.Open();
                    
                    SqlDataAdapter da = new SqlDataAdapter("select Clave_Pacientes from TblCitas where Clave_Pacientes =" + TxtClave.Text, cnn);
                    DataTable dataTable = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                       MessageBox.Show("REGISTRO ENCONTRADO", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("LA CLAVE DEL PACIENTE NO EXISTE, DEBE AGREGARLA", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       // BtnAgregar.Enabled = true;
                      
                    }
                    //LimpiaCampos();
                    //obtiene_datos();
                   
                    //CargaDoctores();
          
                        if (TxtFechaCita.Text == "")
                        {
                            MessageBox.Show("FALTA LA FECHA DE LA CITA", "DIAGNOSTICO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           DtpFechaCita.Focus();
                        }
                        else
                        {
                            try
                            {
                                LimpiaCampos();
                                obtiene_datos();
                               
                                CargaDoctores();
                               
                            }
                            catch
                            {
                                MessageBox.Show("OCURRIO UN ERROR!!, NO SELECCIONO LA FECHA DE LA CITA", "DIAGNOSTICO");   
                            }             
                        }
           
        }

        public void LimpiaCampos()
        {
            
            TxtNombre.Text =""; 
            TxtApPat.Text =""; 
            TxtApMat.Text =""; 
            TxtDomicilio.Text ="";
            
            TxtHora.Text = "";
            TxtEstatura.Text =""; 
            TxtPeso.Text = "";
            TxtTemperatura.Text ="";
            TxtPresion.Text = "";
        }

        private void TxtClave_TextChanged(object sender, EventArgs e)
        {
            if (TxtClave.Text == "")
                BtnBuscarReg.Enabled = false;
            else
                BtnBuscarReg.Enabled = true;
        }

        private void TxtClave_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void TxtTemperatura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtSintomas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void TxtEnfermedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void TxtFechaCita_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            TxtFechaCita.Text = DtpFechaCita.Value.ToShortDateString();
        }

        private void BtnBuscarReg_MouseMove(object sender, MouseEventArgs e)
        {
          //  BtnBuscarReg.AccessibleDescription="BUSCAR REGISTRO";
        }

        private void BtnVerCitas_Click(object sender, EventArgs e)
        {
            FrmVerCitas X = new FrmVerCitas();
            X.ShowDialog();
        }

  
    }
}