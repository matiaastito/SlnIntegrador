using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Models.Base
{
    public abstract class Persona
    {
        #region construct
        protected Persona()
        {
        }

        protected Persona(int id, string nombre, string apellido, string domicilio, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
        }
        #endregion

        #region atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        #endregion

    }
}
