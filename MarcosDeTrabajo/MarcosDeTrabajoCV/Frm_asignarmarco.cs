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
    public partial class Frm_asignarmarco : Form
    {
        string usuario = "";
        public Frm_asignarmarco(string user, string namebd)
        {
            InitializeComponent();            
                        
            usuario = user;
            Nav_marcosdetrabajo.setBd(namebd);
            string[] alias = { "Marco", "Empresa", "Fecha de Asignación", "Estado" };
            Nav_marcosdetrabajo.asignarAlias(alias);
            Nav_marcosdetrabajo.asignarSalida(this);            
            Nav_marcosdetrabajo.asignarColorFondo(Color.White);
            Nav_marcosdetrabajo.asignarColorFuente(Color.Black);
            Nav_marcosdetrabajo.asignarAyuda("1");
            Nav_marcosdetrabajo.asignarComboConTabla("marcotrabajo", "Nombre_MarcoTrabajo", 1);
            Nav_marcosdetrabajo.asignarComboConTabla("empresa", "Nombre_Empresa", 1);
            Nav_marcosdetrabajo.asignarTabla("marcotrabajo_has_empresa");
            Nav_marcosdetrabajo.asignarNombreForm("");
        }

        private void Nav_marcosdetrabajo_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            Nav_marcosdetrabajo.ObtenerIdUsuario(usuario);
            Nav_marcosdetrabajo.botonesYPermisosInicial(usuario, aplicacionActiva);
            Nav_marcosdetrabajo.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
