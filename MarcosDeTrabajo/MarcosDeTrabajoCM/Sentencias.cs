using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosDeTrabajoCM
{
	class Sentencias
	{
		Conexion cn;
		public OdbcDataAdapter llenaTbl(string query)// metodo  que obtinene el contenio de una tabla
		{
			string sql = query;
			OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar());
			return dataTable;
		}
	}
}
