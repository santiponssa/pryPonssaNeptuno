using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryPonssaNeptuno
{
    internal class ClsManejoBD
    {
        //OBJETOS para manipular la conexiòn y datos de una BD
        //zona de declaraciones de objetos y variables
        OleDbConnection conn = new OleDbConnection();
        OleDbCommand comm = new OleDbCommand();
        OleDbDataReader rdr;

        public string RutaDeBaseDatos;

        public void ConectarBD()
        {
            RutaDeBaseDatos = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = NEPTUNO.accdb";
            try
            {
                //debo ingresar la cadena de conexiòn (proveedor de la base, ruta, nombre de archivo)
                conn.ConnectionString = RutaDeBaseDatos;
                conn.Open();
                MessageBox.Show("Base de Datos conectada");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
        public void CargarGrilla()
        {

        }

        public void ListarTablasDeLaBaseDeDatos()
        {
            DataTable tablas;
            tablas = conn.GetSchema("Tables");

            //https://social.msdn.microsoft.com/Forums/es-ES/8b06cfb9-ce9b-4ad4-a8d5-53f0f281f198/obtener-el-nombre-de-todas-las-tablas-existentes-en-una-base-de-datos-acces-en-c?forum=vcses

        }
    }
}
