using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Negocio
{
    public class PersonaCN
    {
        public static List<tb_Persona> obtenerPersonas()
        {
            PersonaRepositorio perRepo = new PersonaRepositorio();
            return perRepo.obtenerPersonas();
        }
    }
}
