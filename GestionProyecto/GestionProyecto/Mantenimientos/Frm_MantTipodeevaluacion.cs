using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyecto.Mantenimientos
{
    public partial class Frm_MantTipodeevaluacion : Form
    {
        string usuario = "";
        public Frm_MantTipodeevaluacion(string user, string nombreBd)
        {
            InitializeComponent();
            navegador1.setBd(nombreBd);
            usuario = user;
            string[] alias = {"Codigo Tipo","Nombre Tipo", "Descripcion Tipo", "Estado Tipo" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color tipoevaluacion = Color.FromArgb(143, 208, 68);
            navegador1.asignarColorFondo(tipoevaluacion);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("10");
            navegador1.asignarTabla("TipoEvaluacion");
            navegador1.asignarNombreForm("Tipo de evaluacion");
        }

        private void Frm_MantTipodeevaluacion_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "2";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
