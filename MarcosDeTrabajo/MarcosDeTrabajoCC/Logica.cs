using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MarcosDeTrabajoCC
{
	class Logica
	{
		
		public DataTable consultaLogica(string tabla)  //obtener datos de la consulta
		{
		//	sn = new sentencias(nombreBd);
			//OdbcDataAdapter dt = sn.llenaTbl(tabla);
			DataTable table = new DataTable();
			//dt.Fill(table);
			return table;
		}
	}
}
