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
using GestionRecursosCV.GestionDeRecursos;
using GestionRecursosCV.Mantenimientos;
//Gestion de Requerimientos
using CapaVista.Mantenimientos;
//Gestion de Reportes
using GestionReportesCV;
//Gestion de Proyectos
using GestionProyecto;
using GestionProyecto.Mantenimientos;
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
            Frm_asignarmarco marco = new Frm_asignarmarco("usu", "auditoriaSW");
            mostrarVentana(marco);
        }

        private void recursosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_mantenimiento mantenimientoRecursos = new Frm_mantenimiento("usu", 2, "auditoriaSW");
            mostrarVentana(mantenimientoRecursos);
        }

        private void auditoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_MantenimientoAuditores auditores = new Frm_MantenimientoAuditores("usu", "auditoriaSW");
            mostrarVentana(auditores);
        }

        private void contactosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_MantenimientoContactos contactos = new Frm_MantenimientoContactos("usu", "auditoriaSW");
            mostrarVentana(contactos);
        }

        private void empresasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoEmpresa empresa = new Frm_MantenimientoEmpresa("usu", "auditoriaSW");
            mostrarVentana(empresa);
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoDepartamentos departamentos = new Frm_MantenimientoDepartamentos("usu", "auditoriaSW");
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

        private void tipoDeRecursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mantenimiento mantenimientoRecursos = new Frm_mantenimiento("usu", 3, "auditoriaSW");
            mostrarVentana(mantenimientoRecursos);
        }

        private void instrumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mantenimiento mantenimientoRecursos = new Frm_mantenimiento("usu", 1, "auditoriaSW");
            mostrarVentana(mantenimientoRecursos);
        }

        private void marcosDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_registrarmarco marco = new Frm_registrarmarco();
            mostrarVentana(marco);
        }

        private void tiposDeProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_mantenimientotiposprocesos tiposProceso = new Frm_mantenimientotiposprocesos("usu", "auditoriaSW");
            mostrarVentana(tiposProceso);
        }

        private void instrumentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_MantInstrumentos instrumentos = new Frm_MantInstrumentos("usu", "auditoriaSW");
            mostrarVentana(instrumentos);
        }

        private void tipoEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantTipodeevaluacion tipoEvaluacion = new Frm_MantTipodeevaluacion("usu", "auditoriaSW");
            mostrarVentana(tipoEvaluacion);
        }
    }
}
