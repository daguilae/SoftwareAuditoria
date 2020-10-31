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
                case 1: //instrumentos
                    string[] alias1 = { "Instrumentos", "Nombre", "Descripción", "Estado" };
                    return (alias1, "1", "instrumentos", "Instrumento", "INSTRUMENTOS", 0);

                case 2: //recursos
                    string[] alias2 = { "Recursos", "TipoRecurso", "Nombre", "Descripción", "Estado" };
                    return (alias2, "1", "recursos", "de recursos", "RECURSOS", 1);

                case 3: //tipo recurso
                    string[] alias3 = { "TipoRecursos", "Nombre", "Descripción", "Estado" };
                    return (alias3, "1", "tiporecursos", "de Recursos", "TIPORECURSOS", 0);

                default:
                    break;
            }
            return (null, null, null, null, null, 0);
        }

        public (string, string, int) foraneas(int tabla, int no)
        {
            switch (tabla)
            {
                //instrumentos
                case 1:
                    break;

                //recursos
                case 2:
                    switch (no)
                    {
                        case 1:
                            return ("tiporecursos", "ID_TipoRecurso", 0);
                    }
                    break;

                //Tipo Recursos
                case 3:
                    break;

                default:
                    break;
            }
            return ("", "", 0);
        }
    }
}
