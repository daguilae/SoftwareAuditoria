using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyecto
{
   public class Logica
    {
        Sentencias sn = new Sentencias();
        public OdbcDataReader insertarrubrica(string sID_Rubrica, string Nombre_Rubrica, string Descripcion100_Rubrica, string ID_Instrumentos, string Descripcion75_Rubrica, string sDescripcion50_Rubrica, string sDescripcion25_Rubrica, string sDescripcion0_Rubrica, string sTotal_Rubrica, string sEstado)
        {
            return sn.Insertarrubrica( sID_Rubrica,  Nombre_Rubrica,  Descripcion100_Rubrica,  ID_Instrumentos,  Descripcion75_Rubrica,  sDescripcion50_Rubrica,  sDescripcion25_Rubrica,  sDescripcion0_Rubrica,  sTotal_Rubrica,  sEstado);
        }
    }
}
