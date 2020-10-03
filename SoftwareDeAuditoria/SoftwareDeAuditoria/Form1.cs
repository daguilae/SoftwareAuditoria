using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeRecursosCV.GestionDeRecursos;
using GestionDeRecursosCV.Mantenimientos;

namespace SoftwareDeAuditoria
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
