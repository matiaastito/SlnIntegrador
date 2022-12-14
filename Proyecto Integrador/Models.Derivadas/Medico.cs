using Proyecto_Integrador.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Models
{
    public class Medico : Persona
    {
        public Medico()
        {
        }

        public Medico(string especialidad, string matricula, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad = especialidad;
            Matricula = matricula;  
        }

        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }
}
