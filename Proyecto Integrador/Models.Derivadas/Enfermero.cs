using Proyecto_Integrador.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Models
{
    public class Enfermero : Persona
    {
        public Enfermero()
        {
        }

        public Enfermero(int cuil, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            CUIL = cuil;
        }

        public int CUIL { get; set; }

    }
}
