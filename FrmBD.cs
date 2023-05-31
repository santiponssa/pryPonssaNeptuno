using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Para conectar con una base de datos
using System.Data.OleDb;


namespace pryPonssaNeptuno
{
    public partial class FrmBD : Form
    {
        ClsManejoBD objbase = new ClsManejoBD();
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataReader rdr;
        public FrmBD()
        {
            InitializeComponent();
        }

        private void FrmBD_Load(object sender, EventArgs e)
        {
            try
            {
                objbase.ConectarBD();
                objbase.CargarLst(lstPais);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                comm.Connection = conn;
                comm.CommandType = CommandType.TableDirect;
                comm.CommandText = "Clientes";
                lblConexion.Text = "Tabla obtenida";
                lblConexion.BackColor = Color.Green;
                rdr = comm.ExecuteReader();

                while (rdr.Read())
                {
                    dgvClientes.Rows.Add(rdr[0], rdr[1], rdr[2],
                        rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8]);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnElegirBD_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //dlg.
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void lstPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
