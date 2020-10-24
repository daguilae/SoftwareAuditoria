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
using GestionReportesCV;
//Gestion de Proyectos
using GestionProyecto;
//Gestion de Marcos de Trabajo
using MarcosDeTrabajoCV;

namespace SoftwareDeAuditoria
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void mostrarVentana(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }

        private void asignacionDeMarcoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_asignarmarco marco = new Frm_asignarmarco();
            mostrarVentana(marco);
        }

        private void recursosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_mantenimiento mantenimientoRecursos = new Frm_mantenimiento();
            mostrarVentana(mantenimientoRecursos);
        }

        private void auditoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_MantenimientoAuditores auditores = new Frm_MantenimientoAuditores();
            mostrarVentana(auditores);
        }

        private void contactosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_MantenimientoContactos contactos = new Frm_MantenimientoContactos();
            mostrarVentana(contactos);
        }

        private void empresasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoEmpresa empresa = new Frm_MantenimientoEmpresa();
            mostrarVentana(empresa);
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoDepartamentos departamentos = new Frm_MantenimientoDepartamentos();
            mostrarVentana(departamentos);
        }

        private void informacionGeneralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_InfoGeneral general = new Frm_InfoGeneral();
            mostrarVentana(general);
        }

        private void evaluacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Evaluacion evaluacion = new Frm_Evaluacion();
            mostrarVentana(evaluacion);
        }

        private void registroDeMarcoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_registrarmarco marco = new Frm_registrarmarco();
            mostrarVentana(marco);
        }

        private void asignacionDeRecursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_AsignacionDeRecursos asignacionDeRecursos = new Frm_AsignacionDeRecursos();
            mostrarVentana(asignacionDeRecursos);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_reportes reporte = new Frm_reportes();
            mostrarVentana(reporte);
        }
    }
}
