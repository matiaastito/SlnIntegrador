using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Models
{
    public class Habitacion
    {
        public Habitacion()
        {
        }

        public Habitacion(int id, int numero, string estado)
        {
            Id = id;
            Numero = numero;
            Estado = estado;
        }

        public int Id { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }



    }
}
