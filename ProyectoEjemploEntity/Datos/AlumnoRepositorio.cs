using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class AlumnoRepositorio
    {
        public List<tb_Alumno> obtenerAlumnos()
        {
            using (BD_CursosMunicipalidadEntities bd = new BD_CursosMunicipalidadEntities())
            {
                return bd.tb_Alumno.ToList();
            }
        }
    }
}
