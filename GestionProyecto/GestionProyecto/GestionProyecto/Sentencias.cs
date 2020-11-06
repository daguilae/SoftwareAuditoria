using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProyecto
{
   public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
        public OdbcDataReader Insertarrubrica(string sID_Rubrica, string Nombre_Rubrica, string Descripcion100_Rubrica, string ID_Instrumentos, string Descripcion75_Rubrica, string sDescripcion50_Rubrica, string sDescripcion25_Rubrica, string sDescripcion0_Rubrica, string sTotal_Rubrica, string sEstado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into Rubrica values(" + sID_Rubrica + ", '" + Nombre_Rubrica + "' ,'" + Descripcion100_Rubrica + "','" + ID_Instrumentos + "','" + Descripcion75_Rubrica + "','" + sDescripcion50_Rubrica + "','" + sDescripcion25_Rubrica + "','" + sDescripcion0_Rubrica + "','" + sTotal_Rubrica + "','" + sEstado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultaayudas(string id)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from ayuda where ID_Ayuda =" + id + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
