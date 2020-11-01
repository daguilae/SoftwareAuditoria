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
    public partial class Frm_MantenimientoDepartamentos : Form
    {
        string usuario = "";
        public Frm_MantenimientoDepartamentos(string user, int tbl, string nombreBD)
        {
            InitializeComponent();
            usuario = user;
            navegador2.setBd(nombreBD);
            string[] alias = { "ID", "Empresa", "Nombre Departamento", "Descripcion","Estado" };
            navegador2.asignarAlias(alias);
            navegador2.asignarSalida(this);
            Color Hotel = Color.FromArgb(218, 125, 125);
            navegador2.asignarColorFondo(Hotel);
            navegador2.asignarColorFuente(Color.Black);
            navegador2.asignarAyuda("1");
            navegador2.asignarComboConTabla("Empresa", "Nombre_Empresa", 1);
            navegador2.asignarTabla("Departamento");
            navegador2.asignarNombreForm("Departamentos");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            string aplicacionActiva = "1";
            navegador2.ObtenerIdUsuario(usuario);
            navegador2.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador2.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
