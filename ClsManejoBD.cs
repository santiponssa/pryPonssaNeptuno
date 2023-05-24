using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;

namespace pryPonssaNeptuno
{
    internal class ClsManejoBD
    {
        OleDbConnection conn;
        OleDbCommand comm;
        OleDbDataReader rdr;

        string ProveedorAcceso = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =";

        public void ConectarBD()
        {
            try
            {
                conn = new OleDbConnection();
                conn.ConnectionString = ProveedorAcceso + "NEPTUNO.accdb";
                conn.Open();
                
            }
            catch (Exception exc)
            {
                
            }
        }
    }
}
