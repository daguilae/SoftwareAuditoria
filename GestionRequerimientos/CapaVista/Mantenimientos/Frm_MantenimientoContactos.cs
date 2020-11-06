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
    public partial class Frm_MantenimientoContactos : Form
    {
        string usuario;
        int noTablas;

        public Frm_MantenimientoContactos(string user, int tbl, string nombreBD)
        {
            InitializeComponent();
            usuario = user;
            navegador2.setBd(nombreBD);
            string[] alias = { "ID", "Nombre Contacto", "Telefono Contacto", "Email Contacto","Cargo Contacto","Etiqueta Contacto","Estado","Departamento", "Empresa" };
            navegador2.asignarAlias(alias);
            navegador2.asignarSalida(this);
            Color Hotel = Color.FromArgb(218, 125, 125);
            navegador2.asignarColorFondo(Hotel);
            navegador2.asignarColorFuente(Color.Black);
            navegador2.asignarAyuda("13");
            navegador2.asignarComboConTabla("Departamento", "Nombre_Departamento", 1);
            navegador2.asignarComboConTabla("Empresa", "Nombre_Empresa", 1);
            navegador2.asignarTabla("Contactos");
            navegador2.asignarNombreForm("Contactos");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Frm_MantenimientoContactos_Load(object sender, EventArgs e)
        {
            string aplicacionActiva = "1";
            navegador2.ObtenerIdUsuario(usuario);
            navegador2.botonesYPermisosInicial(usuario, aplicacionActiva);
            navegador2.ObtenerIdAplicacion(aplicacionActiva);
        }
    }
}
