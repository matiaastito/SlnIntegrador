using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public static class AdmHabitacion
    {
        static List<Habitacion> habitaciones;

        #region Metodos

        public static List<Habitacion> Listar()
        {
            habitaciones = new List<Habitacion>()
            {
                new Habitacion(0, 1, "Ocupada"),
                new Habitacion(1, 4, "Libre")
            };
            Habitacion habitacion3 = new Habitacion(2, 12, "Libre");

            Habitacion habitacion4 = new Habitacion(3, 35, "Ocupada");

            Habitacion habitacion5 = new Habitacion(4, 21, "Ocupada");

            habitaciones.Add(habitacion3);
            habitaciones.Add(habitacion4);
            habitaciones.Add(habitacion5);

            //TODO mostrar listado habitaciones 
            return habitaciones;
        }

        public static List<Habitacion> Listar(string estado)
        {
            //TODO mostrar habitaciones x estado
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO inserta habitacion ; retorna el id de la habitacion agregada
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO elimina una habitacion x id; retorna el id eliminado
            return 0;
        }

        public static Habitacion TraerUno(int numero)
        {
            //TODO muestra 1 habitacion x numero; retorna esa habitacion
            return null;
        }

        #endregion
    }
}
