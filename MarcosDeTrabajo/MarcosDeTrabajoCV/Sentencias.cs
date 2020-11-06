using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcosDeTrabajoCV
{
	class Sentencias
	{
		Conexion cn = new Conexion();
		public OdbcDataAdapter llenaTbl(string query)// metodo  que obtinene el contenio de una tabla
		{
			string sql = query;
			OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conectar());
			return dataTable;
		}

		public void ejecutarQuery(string query)// ejecuta un query en la BD
		{
			
			try
			{
				OdbcCommand consulta = new OdbcCommand(query, cn.conectar());
				consulta.ExecuteNonQuery();
				MessageBox.Show("Correcto");
			}
			catch (OdbcException ex) { Console.WriteLine(ex.ToString()); MessageBox.Show("Ocurrió un fallo"); }

		}

		public string[] obtenerItems(string tabla, string campo)//metodo que obtiene la lista de los tipos de campos que requiere una tabla
		{
			string[] items = new string[300];
			int i = 0;


			try
			{

				OdbcCommand command = new OdbcCommand("select  " + campo + " FROM " + tabla + " WHERE Estado = 1", cn.conectar());
				OdbcDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					items[i] = reader.GetValue(0).ToString();
					i++;

				}
			}
			catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }


			return items;

		}

		public string[] obtenerItemsWhere(string tabla, string campo, string where)//metodo que obtiene la lista de los tipos de campos que requiere una tabla
		{
			string[] items = new string[300];
			int i = 0;


			try
			{

				OdbcCommand command = new OdbcCommand("select  " + campo + " FROM " + tabla + " WHERE Estado = 1 && " + where, cn.conectar());
				OdbcDataReader reader = command.ExecuteReader();
				while (reader.Read())
				{
					items[i] = reader.GetValue(0).ToString();
					i++;

				}
			}
			catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }


			return items;

		}

		public string obtenerValor(string query)
		{
			string valor = "";
			bool correcto = false;


			try
			{

				OdbcCommand command = new OdbcCommand(query, cn.conectar());
				OdbcDataReader reader = command.ExecuteReader();
				if(reader.Read())
				{
					valor = reader.GetValue(0).ToString();
					correcto = true;

				}
			}
			catch (Exception ex) { Console.WriteLine(ex.Message.ToString()); }


			return (correcto)?valor:"error";

		}
	}
}
