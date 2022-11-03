using Proyecto_Integrador.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Models
{
    public class Director : Medico
    {
        public Director()
        {
        }

        public Director(string postGrado, string especialidad, string matricula, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(especialidad, matricula, id, nombre, apellido, domicilio, telefono, email)
        {
            PostGrado = postGrado;
        }

        public string PostGrado { get; set; }
    }
}
