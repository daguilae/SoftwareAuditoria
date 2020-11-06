using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionRecursosCM.Mantenimienos;

namespace GestionRecursosCV.Mantenimientos
{
    public partial class Frm_mantenimiento : Form
    {
        string usuario;
        int noTabla;

        //Llaves Foraneas
        int noForaneas;

        public Frm_mantenimiento(string user, int tbl, string nombreBd)
        {
            InitializeComponent();
            usuario = user;
            noTabla = tbl;
            
            Cls_Mantenimientos Mant = new Cls_Mantenimientos();
            Nav_Mantenimiento.setBd(nombreBd);

            // Arreglo de nombres para campos
            Nav_Mantenimiento.asignarAlias(Mant.datos(noTabla).Item1); // Asignar nombres
            Nav_Mantenimiento.asignarSalida(this); // Asignar form de salida

            Nav_Mantenimiento.asignarColorFuente(Color.Black);
            Nav_Mantenimiento.asignarAyuda(Mant.datos(noTabla).Item2); // asignar 1 por defecto 
                                                                       // LOS COMBOS SE ASIGNAN SEGUN EL ORDEN EN QUE SE DECLAREN
                                                                       //navegador1.asignarComboConTabla("tabla", "campo", 0); // 0 o 1 en modo, 0 pone el id y 1 coloca el nombre y consulta el id

            noForaneas = Mant.datos(noTabla).Item6;
            if (noForaneas != 0)
            {
                int i = noForaneas;
                while (i != 0)
                {
                    Mant.foraneas(noTabla, i);
                    Nav_Mantenimiento.asignarComboConTabla(
                        Mant.foraneas(noTabla, i).Item1,
                        Mant.foraneas(noTabla, i).Item2,
                        Mant.foraneas(noTabla, i).Item3
                        );
                    i--;
                }
            }

            Nav_Mantenimiento.asignarTabla(Mant.datos(noTabla).Item3); // tabla principal
            Nav_Mantenimiento.asignarNombreForm(" "); // Titulo y nombre del form

            //establecer nombre del form y lable
            Text = Text + Mant.datos(noTabla).Item4;
            Lbl_Mantenimiento.Text = Mant.datos(noTabla).Item5;

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            Nav_Mantenimiento.ObtenerIdUsuario("MyUsuario");
            Nav_Mantenimiento.botonesYPermisosInicial("MyUsuario", "1");
            Nav_Mantenimiento.ObtenerIdAplicacion("1");
        }

        private void Frm_mantenimiento_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "C:\\pruebas\\Ayudas\\Recursos\\ayudaRecursos.chm");
        }
    }
}
