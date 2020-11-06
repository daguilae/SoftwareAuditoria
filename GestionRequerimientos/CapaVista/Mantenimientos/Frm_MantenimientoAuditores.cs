using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Mantenimientos
{
    public partial class Frm_MantenimientoAuditores : Form
    {
        string usuario = "";
        public Frm_MantenimientoAuditores(string user, string nombreBd)
        {
            InitializeComponent();
            navegador2.setBd(nombreBd);
            usuario = user;
            string[] alias = { "Codigo Auditor", "Nombre Auditor", "Apellido Auditor", "Telefono", "Correo", "Nit", "DPI", "Sexo", "Estado" };
            navegador2.asignarAlias(alias);
            navegador2.asignarSalida(this);
            Color Hotel = Color.FromArgb(143, 208, 68);
            navegador2.asignarColorFondo(Hotel);
            navegador2.asignarColorFuente(Color.Black);
            navegador2.asignarAyuda("16");
            navegador2.asignarTabla("auditores");
            navegador2.asignarNombreForm("Auditores");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_MantenimientoAuditores_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "2";
            navegador2.ObtenerIdUsuario(usuario);
            navegador2.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador2.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
