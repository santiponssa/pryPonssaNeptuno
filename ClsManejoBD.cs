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
        OleDbConnection conn;
        OleDbCommand comm;
        OleDbDataReader rdr;

        string ProveedorAcceso = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";
        public string RutaDeBaseDatos = "-";

        public void ConectarBD()
        {
            try
            {
                //crea el objeto en memoria (instanciar)
                conn = new OleDbConnection();
                //debo ingresar la cadena de conexiòn (proveedor de la base, ruta, nombre de archivo)
                conn.ConnectionString = ProveedorAcceso + "NEPTUNO.accdb";
                conn.Open();
                
                MessageBox.Show("Base de Datos abierta - con propiedades de la clase");

            }
            catch (Exception fallo)
            {
                MessageBox.Show("Error: " + fallo.Message);
            }
        }
        public void ListarTablasDeLaBaseDeDatos()
        {
            DataTable tablas;
            tablas = conn.GetSchema("Tables");

            //https://social.msdn.microsoft.com/Forums/es-ES/8b06cfb9-ce9b-4ad4-a8d5-53f0f281f198/obtener-el-nombre-de-todas-las-tablas-existentes-en-una-base-de-datos-acces-en-c?forum=vcses

        }
    }
}
