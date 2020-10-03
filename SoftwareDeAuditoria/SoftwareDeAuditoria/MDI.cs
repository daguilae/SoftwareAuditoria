using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Gestion de Recursos
using GestionDeRecursosCV.GestionDeRecursos;
using GestionDeRecursosCV.Mantenimientos;
//Gestion de Requerimientos
using CapaVista.Mantenimientos;
//Gestion de Reportes
 // -- no se siguio el estandard
//Gestion de Proyectos
 // -- no se siguio el estandard y no compila 
//Gestion de


namespace SoftwareDeAuditoria
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.Show();
        }

        private void asignacionDeRecursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AsignacionDeRecursos asignacionDeRecursos = new Frm_AsignacionDeRecursos();
            asignacionDeRecursos.Show();
        }

        private void auditoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoAuditores auditores = new Frm_MantenimientoAuditores();
            auditores.Show();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoContactos contactos = new Frm_MantenimientoContactos();
            contactos.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoDepartamentos departamentos = new Frm_MantenimientoDepartamentos();
            departamentos.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoEmpresa empresa = new Frm_MantenimientoEmpresa();
            empresa.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes();
            reporte.Show();
        }
    }
}
