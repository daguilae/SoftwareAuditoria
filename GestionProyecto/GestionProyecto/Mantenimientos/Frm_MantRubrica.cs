using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyecto.Mantenimientos
{
    public partial class Frm_MantRubrica : Form
    {
        int subtotal = 0;
        Logica logic = new Logica();
        public Frm_MantRubrica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_MantRubrica_Load(object sender, EventArgs e)
        {

        }

        private void Dgw_rubric_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Dgw_rubric.Rows.Count-1; i++)
            {
                string col1 = Dgw_rubric.Rows[i].Cells[0].Value.ToString();
                string col2 = Dgw_rubric.Rows[i].Cells[1].Value.ToString();
                string col3 = Dgw_rubric.Rows[i].Cells[2].Value.ToString();
                string col4 = Dgw_rubric.Rows[i].Cells[4].Value.ToString();
                string col5 = Dgw_rubric.Rows[i].Cells[6].Value.ToString();
                string col6 = Dgw_rubric.Rows[i].Cells[8].Value.ToString();
                string col7 = Dgw_rubric.Rows[i].Cells[10].Value.ToString();
               // string insert_sql = "INSERT INTO Rubrica(ID_Rubrica, Nombre_Rubrica, Descripcion100_Rubrica,ID_Instrumentos,Descripcion75_Rubrica,Descripcion50_Rubrica,Descripcion25_Rubrica,Descripcion0_Rubrica,Total_Rubrica,Estado) VALUES ('" + col1 + "','" + col2 + "','" + col3 + "','" + Txt_instrumento.Text + "','" + col4 + "','" + col5 + "','" + col6 + "','" + col7 + "','0','1')";
                //this.getcom(insert_sql);
                //MessageBox.Show(insert_sql);
                logic.insertarrubrica(col1 ,col2 , col3, Txt_instrumento.Text ,  col4 , col5 ,  col6 , col7 , Convert.ToString(0),Convert.ToString(1));
            }

        }

        private void Dgw_rubric_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dgw_rubric.Rows.Clear();
            Txt_instrumento.Text = "";
        }
    }
}
