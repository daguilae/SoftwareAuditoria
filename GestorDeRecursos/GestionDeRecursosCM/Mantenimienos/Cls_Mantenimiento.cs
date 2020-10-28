using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionRecursosCM.Mantenimienos
{
    public class Cls_Mantenimientos
    {
        /*
         ID DE TABLAS:
            1 = Instrumento
            2 = Recursos
            3 = Tipos Recursos

        ORDEN DE LOS DATOS EN RETURN PARA datos:
            1 = alias
            2 = ayuda
            3 = tabla
            4 = form
            5 = nombre
            6 = noForaneas

        ORDEN DE LOS DATOS EN RETURN PARA foraneas:
            1 = tabla
            2 = campo
            3 = modo
         */

        public (string[], string, string, string, string, int) datos(int tabla)
        {
            switch (tabla)
            {
                default:
                    break;
            }
            return (null, null, null, null, null, 0);
        }

        public (string, string, int) foraneas(int tabla, int no)
        {
            switch (tabla)
            {
               
                default:
                    break;
            }
            return ("", "", 0);
        }
    }
}
