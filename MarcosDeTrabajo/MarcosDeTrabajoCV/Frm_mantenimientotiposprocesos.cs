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
    public partial class Frm_mantenimientotiposprocesos : Form
    {
        string usuario = "";


        public Frm_mantenimientotiposprocesos(string user, string nombreBd)
        {
            InitializeComponent();
            navegador1.setBd(nombreBd);
            usuario = user;
            string[] alias = { "Codigo Objetivo","Nombre Tipo Objetivo","Descripcion","Estado"};
            navegador1.asignarAlias(alias);
            navegador1.asignarSalida(this);
            Color Hotel = Color.FromArgb(143, 208, 68);
            navegador1.asignarColorFondo(Hotel);
            navegador1.asignarColorFuente(Color.Black);
            navegador1.asignarAyuda("1");
            navegador1.asignarTabla("tiposprocesos");
            navegador1.asignarNombreForm("Tipos Procesos");



            
        }


        private void Frm_mantenimientotiposprocesos_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador1.ObtenerIdUsuario(usuario);
            navegador1.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador1.ObtenerIdAplicacion(aplicacionActiva);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudaMarco/ayudasMarcoTrabajo.chm", "AyudaMantenimientoTiposProc.html");
        }
    }
}
