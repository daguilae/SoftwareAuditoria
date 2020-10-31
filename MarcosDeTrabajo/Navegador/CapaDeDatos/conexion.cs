using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    class conexion
    {

        private string nombreBd { get; set; }

        public conexion(string nombreBd)
        {
            this.nombreBd = nombreBd;
        }

        public OdbcConnection probarConexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn="+nombreBd);// creacion de la conexion via ODBC
            try
            {              
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }       
    }
}
