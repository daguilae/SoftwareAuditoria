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
    public partial class Frm_MantenimientoEmpresa : Form
    {
        string usuario;
        int noTabla;

        public Frm_MantenimientoEmpresa(string user, int tbl, string nombreBD)
        {
            InitializeComponent();
            navegador2.setBd(nombreBD);

            string[] alias = { "ID", "Nombre", "Direccion", "Telefono", "Estado" };
            navegador2.asignarAlias(alias);
            navegador2.asignarSalida(this);
            Color Hotel = Color.FromArgb(218, 125, 125);
            navegador2.asignarColorFondo(Hotel);
            navegador2.asignarColorFuente(Color.Black);
            navegador2.asignarAyuda("15");
            navegador2.asignarTabla("Empresa");
            navegador2.asignarNombreForm("Empresas");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Frm_MantenimientoEmpresa_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador2.ObtenerIdUsuario(usuario);
            navegador2.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador2.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
