using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class PersonaRepositorio
    {
        public List<tb_Persona> obtenerPersonas()
        {
            using (BD_CursosMunicipalidadEntities bd = new BD_CursosMunicipalidadEntities())
            {
                return bd.tb_Persona.ToList();
            }
        }
    }
}
