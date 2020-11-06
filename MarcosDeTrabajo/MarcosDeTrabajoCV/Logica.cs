using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MarcosDeTrabajoCV
{
	class Logica
	{
		Sentencias sn = new Sentencias();
		public DataTable tabla(string query)  //obtener datos de la consulta
		{
			OdbcDataAdapter dt = sn.llenaTbl(query);
			DataTable table = new DataTable();
			dt.Fill(table);
			return table;
		}

		public void nuevoQuery(String query)//trasporta el query de la capa de disenio a Datos
		{
			sn.ejecutarQuery(query);
		}

		public String[] llenarCombo(string tabla, string campo) {
			return sn.obtenerItems(tabla, campo);
		}

		public String[] llenarComboWhere(string tabla, string campo, string where)
		{
			return sn.obtenerItemsWhere(tabla, campo, where);
		}

		public String valor(string query)
		{
			return sn.obtenerValor(query);
		}
	}
}
