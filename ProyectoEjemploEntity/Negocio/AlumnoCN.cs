using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
namespace Negocio
{
    public class AlumnoCN
    {
        public static List<tb_Alumno> obtenerAlumnos()
        {
            AlumnoRepositorio aluRepo = new AlumnoRepositorio();
            return aluRepo.obtenerAlumnos();
        }
    }
}
