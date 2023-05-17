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
        public FrmBD()
        {
            InitializeComponent();
        }

        OleDbConnection ConectarBD;
        OleDbCommand ComandoBD;
        OleDbDataReader LectorBD;

        private void FrmBD_Load(object sender, EventArgs e)
        {
            try
            {
                ConectarBD = new OleDbConnection();
                ConectarBD.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\NEPTUNO.accdb";
                ConectarBD.Open();
                lblConexion.Text = "Conexión establecida";
                lblConexion.BackColor = Color.Green;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                //lblConexion.Text = "Hubo un error: " + exc.Message;
                //lblConexion.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComandoBD = new OleDbCommand();
                ComandoBD.Connection = ConectarBD;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "Clientes";
                lblConexion.Text = "Tabla obtenida";
                lblConexion.BackColor = Color.Green;
                LectorBD = ComandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    dgvClientes.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2],
                        LectorBD[3], LectorBD[4], LectorBD[5], LectorBD[6], LectorBD[7], LectorBD[8]);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
