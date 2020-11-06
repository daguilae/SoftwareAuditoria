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
    public partial class Frm_MantInstrumentos : Form
    {
        string usuario = "";
        public Frm_MantInstrumentos(string user, string nombreBd)
        {
            InitializeComponent();
            navegador1.setBd(nombreBd);
            usuario = user;
            string[] alias = { "Codigo Instrumento", "Nombre instrumento","Descripicion instrumento", "Estado instrumento" };
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color tipoevaluacion = Color.FromArgb(143, 208, 68);
            navegador1.asignarColorFondo(tipoevaluacion);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("4");
            navegador1.asignarTabla("Instrumentos");
            navegador1.asignarNombreForm("Instrumentos");
        }

        private void Frm_MantInstrumentos_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
