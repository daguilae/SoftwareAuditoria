using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcosDeTrabajoCV
{
    public partial class Frm_registrarmarco : Form
    {
		Logica lg = new Logica();
		bool state = false;
		public Frm_registrarmarco()
        {
            InitializeComponent();
			//Estado de botones
			Btn_eliminarp.Enabled = false;
			Btn_modificarp.Enabled = false;
			Btn_agregarp.Enabled = false;
			Btn_cancelarp.Enabled = false;

			Btn_eliminaro.Enabled = false;
			Btn_modificaro.Enabled = false;
			Btn_agregaro.Enabled = false;
			Btn_cancelaro.Enabled = false;
			//Estado de campos
			Txt_codigoproceso.Enabled = false;
			Cbo_seleccionmarcop.Enabled = false;
			Cbo_tipoproceso.Enabled = false;
			Txt_nombreproceso.Enabled = false;
			Txt_Descripción.Enabled = false;
			Cbo_estadoproceso.Enabled = false;

			Cbo_proceso.Enabled = false;
			Cbo_seleccionemarcoo.Enabled = false;
			Txt_codigoobjetivo.Enabled = false;
			Txt_nombreobjetivo.Enabled = false;
			Txt_descripcionobjetivo.Enabled = false;
			Cbo_estadoobjetivo.Enabled = false;


		}
		bool comboMarcos()
		{
			Cbo_seleccionmarcop.Items.Clear();
			foreach (string item in lg.llenarCombo("marcotrabajo", "Nombre_MarcoTrabajo"))
			{
				if (item != "" && item != null)
				{
					Cbo_seleccionmarcop.Items.Add(item);
				}
			}

			return (Cbo_seleccionmarcop.Items.Count > 0) ? true : false;
		}

		bool comboProcesos()
		{
			Cbo_tipoproceso.Items.Clear();
			foreach (string item in lg.llenarCombo("tiposprocesos", "Nombre_TipoObjetivo"))
			{
				if (item != "" && item != null)
				{
					Cbo_tipoproceso.Items.Add(item);
				}
			}

			return (Cbo_tipoproceso.Items.Count > 0) ? true : false;
		}

		bool comboMarco2()
		{
			Cbo_seleccionemarcoo.Items.Clear();
			foreach (string item in lg.llenarCombo("marcotrabajo", "Nombre_MarcoTrabajo"))
			{
				if (item != "" && item != null)
				{
					Cbo_seleccionemarcoo.Items.Add(item);
				}
			}

			return (Cbo_seleccionemarcoo.Items.Count > 0) ? true : false;
		}

		bool comboProceso2()
		{
			Cbo_proceso.Items.Clear();
			foreach (string item in lg.llenarComboWhere("procesos", "Nombre_Procesos", "ID_MarcoTrabajo = (SELECT ID_MarcoTrabajo FROM marcotrabajo WHERE Nombre_MarcoTrabajo='" + Cbo_seleccionemarcoo.Text+"')"))
			{
				if (item != "" && item != null)
				{
					Cbo_proceso.Items.Add(item);
				}
			}

			return (Cbo_proceso.Items.Count > 0) ? true : false;
		}

		string estado(ComboBox combo)
		{
			string estado = "0";
			if (combo.Text=="Activo")
			{
				estado = "1";
			}

			return estado;
		}
		string estadoReverso(string valorEstado)
		{
			string estado = "Inactivo";
			if (valorEstado == "1")
			{
				estado = "Activo";
			}

			return estado;
		}
		private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_nombremarco_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nombremarco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbp_objetivos_Click(object sender, EventArgs e)
        {

        }

		private void Frm_registrarmarco_Load(object sender, EventArgs e)
		{
			Dgv_procesos.DataSource = lg.tabla("SELECT * FROM procesos");
			Dgv_objetivos.DataSource = lg.tabla("SELECT * FROM objetivos");
			if (!comboMarcos()) { MessageBox.Show("No hay marcos registrados!"); }
			if (!comboProcesos()) { MessageBox.Show("No hay Tipos de Proceso registrados!"); }
			if (!comboMarco2()) { MessageBox.Show("No hay marcos registrados!"); }
			comboProceso2();
		}

		private void Btn_agregarp_Click(object sender, EventArgs e)
		{
			if (Cbo_seleccionmarcop.Text!=""&&
				Txt_codigoproceso.Text != "" &&
				Txt_nombreproceso.Text != "" &&
				Txt_Descripción.Text != "" &&
				Cbo_estadoproceso.Text != ""
				)
			{
				string query = "INSERT INTO procesos VALUES(" + Txt_codigoproceso.Text + "," +
				"(SELECT ID_MarcoTrabajo FROM marcotrabajo WHERE Nombre_MarcoTrabajo = '" + Cbo_seleccionmarcop.Text + "')" + "," +
				" (SELECT ID_TipoObjetivo FROM tiposprocesos " +
				"WHERE Nombre_TipoObjetivo = '" + Cbo_tipoproceso.Text + "'), " +
				"'" + Txt_nombreproceso.Text + "', '" + Txt_Descripción.Text + "'," +
				" " + estado(Cbo_estadoproceso) + ")";
				lg.nuevoQuery(query);
				Dgv_procesos.DataSource = lg.tabla("SELECT * FROM procesos");
				Btn_nuevop.Enabled = true;
				Btn_agregarp.Enabled = false;
				Btn_cancelarp.Enabled = false;
				// Vaciar campos
				Txt_codigoproceso.Text = "";
				Cbo_seleccionmarcop.Text = "";
				Cbo_tipoproceso.Text = "";
				Txt_nombreproceso.Text = "";
				Txt_Descripción.Text = "";
				Cbo_estadoproceso.Text = "";
				//BLoquear campos
				Txt_codigoproceso.Enabled = false;
				Cbo_seleccionmarcop.Enabled = false;
				Cbo_tipoproceso.Enabled = false;
				Txt_nombreproceso.Enabled = false;
				Txt_Descripción.Enabled = false;
				Cbo_estadoproceso.Enabled = false;
			}
			else
			{
				MessageBox.Show("Por favor llena todos los campos para continuar");
			}
		}

		private void Btn_modificaro_Click(object sender, EventArgs e)
		{
			if (state)
			{
				if (MessageBox.Show("¿Desea modificar el Objetivo " + Dgv_objetivos.SelectedCells[3].Value.ToString() + "?", "Modificar objetivos", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					string query = "UPDATE objetivos SET ID_Procesos = " +
					"(SELECT ID_Procesos FROM procesos WHERE Nombre_Procesos = '" + Cbo_proceso.Text + "')" + ", " +
					"ID_MarcoTrabajo = (SELECT ID_MarcoTrabajo FROM marcotrabajo WHERE Nombre_MarcoTrabajo = '" + Cbo_seleccionemarcoo.Text + "'), " +
					"Nombre_Actividad='" + Txt_nombreobjetivo.Text + "', Descripcion_Actividad='" + Txt_descripcionobjetivo.Text + "', " +
					"Estado= " + estado(Cbo_estadoobjetivo) + " WHERE ID_Actividad=" + Txt_codigoobjetivo.Text;
					lg.nuevoQuery(query);
					Dgv_objetivos.DataSource = lg.tabla("SELECT * FROM objetivos");
				}
				// Estado de esliminacion/modificacion a la normalidad
				state = false;
				// estado de campos y botones a la normalidad
				Btn_eliminaro.Enabled = false;
				Btn_modificaro.Enabled = false;
				Btn_agregaro.Enabled = false;
				Btn_cancelaro.Enabled = false;
				Btn_nuevoo.Enabled = true;
				// vaciar campos
				Txt_codigoproceso.Text = "";
				Cbo_seleccionemarcoo.Text = "";
				Cbo_proceso.Text = "";
				Txt_nombreobjetivo.Text = "";
				Txt_descripcionobjetivo.Text = "";
				Cbo_estadoobjetivo.Text = "";
				//Bloquear campos
				Txt_codigoobjetivo.Enabled = false;
				Cbo_seleccionemarcoo.Enabled = false;
				Cbo_proceso.Enabled = false;
				Txt_nombreobjetivo.Enabled = false;
				Txt_descripcionobjetivo.Enabled = false;
				Cbo_estadoobjetivo.Enabled = false;
			}
			else
			{
				MessageBox.Show("Debes seleccionar un registro!");
			}


		}

		private void Btn_modificarp_Click(object sender, EventArgs e)
		{
			if (state)
			{
				if (MessageBox.Show("¿Desea modificar el Proceso " + Dgv_procesos.SelectedCells[3].Value.ToString() + "?", "Modificar Proceso", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					string query = "UPDATE procesos SET ID_MarcoTrabajo = " +
					"(SELECT ID_MarcoTrabajo FROM marcotrabajo WHERE Nombre_MarcoTrabajo = '" + Cbo_seleccionmarcop.Text + "')" + ", " +
					"ID_TipoObjetivo = (SELECT ID_TipoObjetivo FROM tiposprocesos WHERE Nombre_TipoObjetivo = '" + Cbo_tipoproceso.Text + "'), " +
					"Nombre_Procesos='" + Txt_nombreproceso.Text + "', Descripcion_Objetivo='" + Txt_Descripción.Text + "', " +
					"Estado= " + estado(Cbo_estadoproceso) + " WHERE ID_Procesos=" + Txt_codigoproceso.Text;
					lg.nuevoQuery(query);
					Dgv_procesos.DataSource = lg.tabla("SELECT * FROM procesos");
				}
				// Estado de esliminacion/modificacion a la normalidad
				state = false;
				// estado de campos y botones a la normalidad
				Btn_eliminarp.Enabled = false;
				Btn_modificarp.Enabled = false;
				Btn_agregarp.Enabled = false;
				Btn_cancelarp.Enabled = false;
				Btn_nuevop.Enabled = true;
				// vaciar campos
				Txt_codigoproceso.Text = "";
				Cbo_seleccionmarcop.Text = "";
				Cbo_tipoproceso.Text = "";
				Txt_nombreproceso.Text = "";
				Txt_Descripción.Text = "";
				Cbo_estadoproceso.Text = "";
			}
			else {
				MessageBox.Show("Debes seleccionar un registro!");
			}
			

			
		}

		private void Dgv_procesos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Estado de eliminacion o modificacion
			state = true;
			// vaciar campos
			Txt_codigoproceso.Text = "";
			Cbo_seleccionmarcop.Text = "";
			Cbo_tipoproceso.Text = "";
			Txt_nombreproceso.Text = "";
			Txt_Descripción.Text = "";
			Cbo_estadoproceso.Text = "";
			// estado de campos y botones
			Txt_codigoproceso.Enabled = false;
			Cbo_estadoproceso.Enabled = false;
			Cbo_seleccionmarcop.Enabled = true;
			Cbo_tipoproceso.Enabled = true;
			Txt_nombreproceso.Enabled = true;
			Txt_Descripción.Enabled = true;
			Btn_eliminarp.Enabled = true;
			Btn_modificarp.Enabled = true;
			Btn_agregarp.Enabled = false;
			Btn_cancelarp.Enabled = true;
			Btn_nuevop.Enabled = false;
			// Valores de tabla a campos
			Txt_codigoproceso.Text =  Dgv_procesos.SelectedCells[0].Value.ToString();
			Cbo_seleccionmarcop.Text = lg.valor("SELECT Nombre_MarcoTrabajo FROM marcotrabajo WHERE ID_MarcoTrabajo=" + Dgv_procesos.SelectedCells[1].Value.ToString());
			Cbo_tipoproceso.Text = lg.valor("SELECT Nombre_TipoObjetivo FROM tiposprocesos WHERE ID_TipoObjetivo = '"+Dgv_procesos.SelectedCells[2].Value.ToString()+"' ");
			Txt_nombreproceso.Text = Dgv_procesos.SelectedCells[3].Value.ToString();
			Txt_Descripción.Text = Dgv_procesos.SelectedCells[4].Value.ToString();
			Cbo_estadoproceso.Text = estadoReverso(Dgv_procesos.SelectedCells[5].Value.ToString());
		}

		private void Btn_eliminarp_Click(object sender, EventArgs e)
		{
			if (state)
			{
				if (MessageBox.Show("¿Desea eliminar el Proceso " + Dgv_procesos.SelectedCells[3].Value.ToString() + "?", "Eliminar Proceso", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{

					string query = "UPDATE procesos SET Estado= 0 WHERE ID_Procesos=" + Txt_codigoproceso.Text;
					lg.nuevoQuery(query);
					Dgv_procesos.DataSource = lg.tabla("SELECT * FROM procesos");

				}
				// Estado de esliminacion/modificacion a la normalidad
				state = false;
				// estado de campos y botones a la normalidad
				Btn_eliminarp.Enabled = false;
				Btn_modificarp.Enabled = false;
				Btn_agregarp.Enabled = false;
				Btn_cancelarp.Enabled = false;
				Btn_nuevop.Enabled = true;
				// vaciar campos
				Txt_codigoproceso.Text = "";
				Cbo_seleccionmarcop.Text = "";
				Cbo_tipoproceso.Text = "";
				Txt_nombreproceso.Text = "";
				Txt_Descripción.Text = "";
				Cbo_estadoproceso.Text = "";

				Txt_codigoproceso.Enabled = false;
				Cbo_seleccionmarcop.Enabled = false;
				Cbo_tipoproceso.Enabled = false;
				Txt_nombreproceso.Enabled = false;
				Txt_Descripción.Enabled = false;
				Cbo_estadoproceso.Enabled = false;
			}
			else
			{
				MessageBox.Show("Debes seleccionar un registro!");
			}
			

		}

		private void Btn_nuevop_Click(object sender, EventArgs e)
		{
			//Estado de ingreso campos
			Txt_codigoproceso.Enabled = true;
			Cbo_seleccionmarcop.Enabled = true;
			Cbo_tipoproceso.Enabled = true;
			Txt_nombreproceso.Enabled = true;
			Txt_Descripción.Enabled = true;
			Cbo_estadoproceso.Enabled = true;
			//Estado de botones
			Btn_nuevop.Enabled = false;
			Btn_agregarp.Enabled = true;
			Btn_cancelarp.Enabled = true;
			// Vaciar campos
			Txt_codigoproceso.Text = "";
			Cbo_seleccionmarcop.Text = "";
			Cbo_tipoproceso.Text = "";
			Txt_nombreproceso.Text = "";
			Txt_Descripción.Text = "";
			Cbo_estadoproceso.Text = "";
		}

		private void Btn_cancelarp_Click(object sender, EventArgs e)
		{
			state = false;
			//Estado botones a la normalidad
			Btn_eliminarp.Enabled = false;
			Btn_modificarp.Enabled = false;
			Btn_agregarp.Enabled = false;
			Btn_cancelarp.Enabled = false;
			Btn_nuevop.Enabled = true;
			// Vaciar campos
			Txt_codigoproceso.Text = "";
			Cbo_seleccionmarcop.Text = "";
			Cbo_tipoproceso.Text = "";
			Txt_nombreproceso.Text = "";
			Txt_Descripción.Text = "";
			Cbo_estadoproceso.Text = "";
			//BLoquear campos
			Txt_codigoproceso.Enabled = false;
			Cbo_seleccionmarcop.Enabled = false;
			Cbo_tipoproceso.Enabled = false;
			Txt_nombreproceso.Enabled = false;
			Txt_Descripción.Enabled = false;
			Cbo_estadoproceso.Enabled = false;
		}

		private void Cbo_tipoproceso_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validar.nada(e);
		}

		private void Dgv_procesos_KeyDown(object sender, KeyEventArgs e)
		{
			if (Dgv_procesos.Rows.Count!=0)
			{
				Txt_codigoproceso.Text = Dgv_procesos.SelectedCells[0].Value.ToString();
				Cbo_seleccionmarcop.Text = lg.valor("SELECT Nombre_MarcoTrabajo FROM marcotrabajo WHERE ID_MarcoTrabajo=" + Dgv_procesos.SelectedCells[1].Value.ToString());
				Cbo_tipoproceso.Text = lg.valor("SELECT Nombre_TipoObjetivo FROM tiposprocesos WHERE ID_TipoObjetivo = '" + Dgv_procesos.SelectedCells[2].Value.ToString() + "' ");
				Txt_nombreproceso.Text = Dgv_procesos.SelectedCells[3].Value.ToString();
				Txt_Descripción.Text = Dgv_procesos.SelectedCells[4].Value.ToString();
				Cbo_estadoproceso.Text = estadoReverso(Dgv_procesos.SelectedCells[5].Value.ToString());
			}
			
		}

		private void Dgv_procesos_KeyUp(object sender, KeyEventArgs e)
		{
			if (Dgv_procesos.Rows.Count != 0)
			{
				Txt_codigoproceso.Text = Dgv_procesos.SelectedCells[0].Value.ToString();
				Cbo_seleccionmarcop.Text = lg.valor("SELECT Nombre_MarcoTrabajo FROM marcotrabajo WHERE ID_MarcoTrabajo=" + Dgv_procesos.SelectedCells[1].Value.ToString());
				Cbo_tipoproceso.Text = lg.valor("SELECT Nombre_TipoObjetivo FROM tiposprocesos WHERE ID_TipoObjetivo = '" + Dgv_procesos.SelectedCells[2].Value.ToString() + "' ");
				Txt_nombreproceso.Text = Dgv_procesos.SelectedCells[3].Value.ToString();
				Txt_Descripción.Text = Dgv_procesos.SelectedCells[4].Value.ToString();
				Cbo_estadoproceso.Text = estadoReverso(Dgv_procesos.SelectedCells[5].Value.ToString());
			}
		}

		private void Tbc_gestionmarcos_TabIndexChanged(object sender, EventArgs e)
		{
			//Verificar combos
			if (!comboMarcos()) { MessageBox.Show("No hay marcos registrados!"); }
			if (!comboProcesos()) { MessageBox.Show("No hay Tipos de Proceso registrados!"); }
			if (!comboMarco2()) { MessageBox.Show("No hay marcos registrados!"); }
			comboProceso2();

			// Estado de Botones
			Btn_eliminarp.Enabled = false;
			Btn_modificarp.Enabled = false;
			Btn_agregarp.Enabled = false;
			Btn_cancelarp.Enabled = false;
			Btn_nuevop.Enabled = true;

			Btn_eliminaro.Enabled = false;
			Btn_modificaro.Enabled = false;
			Btn_agregaro.Enabled = false;
			Btn_cancelaro.Enabled = false;
			Btn_nuevoo.Enabled = true;

			//Campos
			Txt_codigoproceso.Enabled = false;
			Cbo_seleccionmarcop.Enabled = false;
			Cbo_tipoproceso.Enabled = false;
			Txt_nombreproceso.Enabled = false;
			Txt_Descripción.Enabled = false;
			Cbo_estadoproceso.Enabled = false;

			Cbo_proceso.Enabled = false;
			Cbo_seleccionemarcoo.Enabled = false;
			Txt_codigoobjetivo.Enabled = false;
			Txt_nombreobjetivo.Enabled = false;
			Txt_descripcionobjetivo.Enabled = false;
			Cbo_estadoobjetivo.Enabled = false;

			Txt_codigoobjetivo.Text = "";
			Cbo_seleccionemarcoo.Text = "";
			Cbo_proceso.Text = "";
			Txt_nombreobjetivo.Text = "";
			Txt_descripcionobjetivo.Text = "";
			Cbo_estadoobjetivo.Text = "";

			Txt_codigoobjetivo.Text = "";
			Cbo_seleccionemarcoo.Text = "";
			Cbo_proceso.Text = "";
			Txt_nombreobjetivo.Text = "";
			Txt_descripcionobjetivo.Text = "";
			Cbo_estadoobjetivo.Text = "";


			//Estado 
			state = false;
		}

		private void Cbo_seleccionemarcoo_KeyPress(object sender, KeyPressEventArgs e)
		{
			Validar.nada(e);
		}

		private void Btn_nuevoo_Click(object sender, EventArgs e)
		{
			//Estado de ingreso campos
			Cbo_proceso.Enabled = true;
			Cbo_seleccionemarcoo.Enabled = true;
			Txt_codigoobjetivo.Enabled = true;
			Txt_nombreobjetivo.Enabled = true;
			Txt_descripcionobjetivo.Enabled = true;
			Cbo_estadoobjetivo.Enabled = true;
			//Estado de botones
			Btn_nuevoo.Enabled = false;
			Btn_agregaro.Enabled = true;
			Btn_cancelaro.Enabled = true;
			// Vaciar campos
			Cbo_proceso.Text = "";
			Cbo_seleccionemarcoo.Text = "";
			Txt_codigoobjetivo.Text = "";
			Txt_nombreobjetivo.Text = "";
			Txt_descripcionobjetivo.Text = "";
			Cbo_estadoobjetivo.Text = "";
		}

		private void Btn_agregaro_Click(object sender, EventArgs e)
		{
			if (Cbo_seleccionemarcoo.Text != "" &&
				Cbo_proceso.Text != "" &&
				Txt_nombreobjetivo.Text != "" &&
				Txt_descripcionobjetivo.Text != "" &&
				Cbo_estadoobjetivo.Text != ""
				)
			{
				string query = "INSERT INTO objetivos VALUES(" + Txt_codigoobjetivo.Text + "," +
				"(SELECT ID_Procesos FROM procesos WHERE Nombre_Procesos = '" + Cbo_proceso.Text + "')" + "," +
				" (SELECT ID_MarcoTrabajo FROM marcotrabajo " +
				"WHERE Nombre_MarcoTrabajo = '" + Cbo_seleccionemarcoo.Text + "'), " +
				"'" + Txt_nombreobjetivo.Text + "', '" + Txt_descripcionobjetivo.Text + "'," +
				" " + estado(Cbo_estadoobjetivo) + ")";
				lg.nuevoQuery(query);
				Dgv_objetivos.DataSource = lg.tabla("SELECT * FROM objetivos");
				Btn_nuevoo.Enabled = true;
				Btn_agregaro.Enabled = false;
				Btn_cancelaro.Enabled = false;
				Txt_codigoobjetivo.Text = "";
				Cbo_seleccionemarcoo.Text = "";
				Cbo_proceso.Text = "";
				Txt_nombreobjetivo.Text = "";
				Txt_descripcionobjetivo.Text = "";
				Cbo_estadoobjetivo.Text = "";
				Txt_codigoobjetivo.Enabled = false;
				Cbo_seleccionemarcoo.Enabled = false;
				Cbo_proceso.Enabled = false;
				Txt_nombreobjetivo.Enabled = false;
				Txt_descripcionobjetivo.Enabled = false;
				Cbo_estadoobjetivo.Enabled = false;
			}
			else
			{
				MessageBox.Show("Por favor llena todos los campos para continuar");
			}

		}

		private void Cbo_seleccionemarcoo_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboProceso2();
		}

		private void Tbc_gestionmarcos_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Verificar combos
			if (!comboMarcos()) { MessageBox.Show("No hay marcos registrados!"); }
			if (!comboProcesos()) { MessageBox.Show("No hay Tipos de Proceso registrados!"); }
			if (!comboMarco2()) { MessageBox.Show("No hay marcos registrados!"); }
			comboProceso2();

			// Estado de Botones
			Btn_eliminarp.Enabled = false;
			Btn_modificarp.Enabled = false;
			Btn_agregarp.Enabled = false;
			Btn_cancelarp.Enabled = false;
			Btn_nuevop.Enabled = true;

			Btn_eliminaro.Enabled = false;
			Btn_modificaro.Enabled = false;
			Btn_agregaro.Enabled = false;
			Btn_cancelaro.Enabled = false;
			Btn_nuevoo.Enabled = true;

			//Campos
			Txt_codigoproceso.Enabled = false;
			Cbo_seleccionmarcop.Enabled = false;
			Cbo_tipoproceso.Enabled = false;
			Txt_nombreproceso.Enabled = false;
			Txt_Descripción.Enabled = false;
			Cbo_estadoproceso.Enabled = false;

			Cbo_proceso.Enabled = false;
			Cbo_seleccionemarcoo.Enabled = false;
			Txt_codigoobjetivo.Enabled = false;
			Txt_nombreobjetivo.Enabled = false;
			Txt_descripcionobjetivo.Enabled = false;
			Cbo_estadoobjetivo.Enabled = false;
			//Vaciar campos
			Txt_codigoproceso.Text = "";
			Cbo_seleccionmarcop.Text = "";
			Cbo_tipoproceso.Text = "";
			Txt_nombreproceso.Text = "";
			Txt_Descripción.Text = "";
			Cbo_estadoproceso.Text = "";

			Txt_codigoobjetivo.Text = "";
			Cbo_seleccionemarcoo.Text = "";
			Cbo_proceso.Text = "";
			Txt_nombreobjetivo.Text = "";
			Txt_descripcionobjetivo.Text = "";
			Cbo_estadoobjetivo.Text = "";
			//Estado 
			state = false;
		}

		private void Dgv_objetivos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// Estado de eliminacion o modificacion
			state = true;
			// vaciar campos
			Txt_codigoobjetivo.Text = "";
			Cbo_seleccionemarcoo.Text = "";
			Cbo_proceso.Text = "";
			Txt_nombreobjetivo.Text = "";
			Txt_descripcionobjetivo.Text = "";
			Cbo_estadoobjetivo.Text = "";
			// estado de campos y botones
			Txt_codigoobjetivo.Enabled = false;
			Cbo_estadoobjetivo.Enabled = false;
			Cbo_seleccionemarcoo.Enabled = true;
			Cbo_proceso.Enabled = true;
			Txt_nombreobjetivo.Enabled = true;
			Txt_descripcionobjetivo.Enabled = true;
			Btn_eliminaro.Enabled = true;
			Btn_modificaro.Enabled = true;
			Btn_agregaro.Enabled = false;
			Btn_cancelaro.Enabled = true;
			Btn_nuevoo.Enabled = false;
			// Valores de tabla a campos
			Txt_codigoobjetivo.Text = Dgv_objetivos.SelectedCells[0].Value.ToString();
			Cbo_proceso.Text = lg.valor("SELECT Nombre_Procesos FROM procesos WHERE ID_Procesos=" + Dgv_objetivos.SelectedCells[1].Value.ToString());
			Cbo_seleccionemarcoo.Text = lg.valor("SELECT Nombre_MarcoTrabajo FROM marcotrabajo WHERE ID_MarcoTrabajo = '" + Dgv_objetivos.SelectedCells[2].Value.ToString() + "' ");
			Txt_nombreobjetivo.Text = Dgv_objetivos.SelectedCells[3].Value.ToString();
			Txt_descripcionobjetivo.Text = Dgv_objetivos.SelectedCells[4].Value.ToString();
			Cbo_estadoobjetivo.Text = estadoReverso(Dgv_objetivos.SelectedCells[5].Value.ToString());
		}

		private void Btn_eliminaro_Click(object sender, EventArgs e)
		{
			if (state)
			{
				if (MessageBox.Show("¿Desea eliminar el Objetivo " + Dgv_objetivos.SelectedCells[3].Value.ToString() + "?", "Eliminar Objetivo", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{

					string query = "UPDATE objetivos SET Estado= 0 WHERE ID_Actividad=" + Txt_codigoobjetivo.Text;
					lg.nuevoQuery(query);
					Dgv_objetivos.DataSource = lg.tabla("SELECT * FROM objetivos");

				}
				// Estado de esliminacion/modificacion a la normalidad
				state = false;
				// estado de campos y botones a la normalidad
				Btn_eliminaro.Enabled = false;
				Btn_modificaro.Enabled = false;
				Btn_agregaro.Enabled = false;
				Btn_cancelaro.Enabled = false;
				Btn_nuevoo.Enabled = true;
				// vaciar campos
				Txt_codigoobjetivo.Text = "";
				Cbo_seleccionemarcoo.Text = "";
				Cbo_proceso.Text = "";
				Txt_nombreobjetivo.Text = "";
				Txt_descripcionobjetivo.Text = "";
				Cbo_estadoobjetivo.Text = "";
			}
			else
			{
				MessageBox.Show("Debes seleccionar un registro!");
			}

		}

		private void Btn_cancelaro_Click(object sender, EventArgs e)
		{
			state = false;
			//Estado botones a la normalidad
			Btn_eliminaro.Enabled = false;
			Btn_modificaro.Enabled = false;
			Btn_agregaro.Enabled = false;
			Btn_cancelaro.Enabled = false;
			Btn_nuevoo.Enabled = true;
			// Vaciar campos
			Txt_codigoobjetivo.Text = "";
			Cbo_seleccionemarcoo.Text = "";
			Cbo_proceso.Text = "";
			Txt_nombreobjetivo.Text = "";
			Txt_descripcionobjetivo.Text = "";
			Cbo_estadoobjetivo.Text = "";
			//BLoquear campos
			Txt_codigoobjetivo.Enabled = false;
			Cbo_seleccionemarcoo.Enabled = false;
			Cbo_proceso.Enabled = false;
			Txt_nombreobjetivo.Enabled = false;
			Txt_descripcionobjetivo.Enabled = false;
			Cbo_estadoobjetivo.Enabled = false;
		}

		private void Dgv_objetivos_KeyDown(object sender, KeyEventArgs e)
		{
			if (Dgv_objetivos.Rows.Count!=0)
			{
				Txt_codigoobjetivo.Text = Dgv_objetivos.SelectedCells[0].Value.ToString();
				Cbo_proceso.Text = lg.valor("SELECT Nombre_Procesos FROM procesos WHERE ID_Procesos=" + Dgv_objetivos.SelectedCells[1].Value.ToString());
				Cbo_seleccionemarcoo.Text = lg.valor("SELECT Nombre_MarcoTrabajo FROM marcotrabajo WHERE ID_MarcoTrabajo = '" + Dgv_objetivos.SelectedCells[2].Value.ToString() + "' ");
				Txt_nombreobjetivo.Text = Dgv_objetivos.SelectedCells[3].Value.ToString();
				Txt_descripcionobjetivo.Text = Dgv_objetivos.SelectedCells[4].Value.ToString();
				Cbo_estadoobjetivo.Text = estadoReverso(Dgv_objetivos.SelectedCells[5].Value.ToString());
			}

		}

		private void Dgv_objetivos_KeyUp(object sender, KeyEventArgs e)
		{
			if (Dgv_objetivos.Rows.Count != 0)
			{
				Txt_codigoobjetivo.Text = Dgv_objetivos.SelectedCells[0].Value.ToString();
				Cbo_proceso.Text = lg.valor("SELECT Nombre_Procesos FROM procesos WHERE ID_Procesos=" + Dgv_objetivos.SelectedCells[1].Value.ToString());
				Cbo_seleccionemarcoo.Text = lg.valor("SELECT Nombre_MarcoTrabajo FROM marcotrabajo WHERE ID_MarcoTrabajo = '" + Dgv_objetivos.SelectedCells[2].Value.ToString() + "' ");
				Txt_nombreobjetivo.Text = Dgv_objetivos.SelectedCells[3].Value.ToString();
				Txt_descripcionobjetivo.Text = Dgv_objetivos.SelectedCells[4].Value.ToString();
				Cbo_estadoobjetivo.Text = estadoReverso(Dgv_objetivos.SelectedCells[5].Value.ToString());
			}
		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
			Help.ShowHelp(this, "ayudaMarco/ayudasMarcoTrabajo.chm", "gestionmarco.html");
        }
    }
}
