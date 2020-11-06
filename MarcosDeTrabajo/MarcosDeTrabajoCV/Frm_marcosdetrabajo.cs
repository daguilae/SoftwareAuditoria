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
    public partial class Frm_marcosdetrabajo : Form
    {
        string usuario = "";
        public Frm_marcosdetrabajo(string user, string namebd)
        {
            InitializeComponent();            
                        
            usuario = user;
            Nav_marcosdetrabajo.setBd(namebd);
            string[] alias = { "Codigo Marco", "Nombre Marco", "Descripcion", "Estado" };
            Nav_marcosdetrabajo.asignarAlias(alias);
            Nav_marcosdetrabajo.asignarSalida(this);            
            Nav_marcosdetrabajo.asignarColorFondo(Color.White);
            Nav_marcosdetrabajo.asignarColorFuente(Color.Black);
            Nav_marcosdetrabajo.asignarAyuda("1");
            Nav_marcosdetrabajo.asignarTabla("marcotrabajo");
            Nav_marcosdetrabajo.asignarNombreForm("");
        }

        private void Nav_marcosdetrabajo_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_marcosdetrabajo.ObtenerIdUsuario(usuario);
            Nav_marcosdetrabajo.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_marcosdetrabajo.ObtenerIdAplicacion(aplicacionActiva);
        }

        private void Frm_marcosdetrabajo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudaMarco/ayudasMarcoTrabajo.chm", "mantenimientomarcos.html");
        }
    }
}
