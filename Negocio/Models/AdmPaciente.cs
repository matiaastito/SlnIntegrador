using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models
{
    public static class AdmPaciente
    {
        static List<Paciente> pacientes;

        #region Metodos

        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>()
            {
                new Paciente( new DateTime(1996,10,27), "JP00045",0,"Javier", "Poljkstre", "Calle falsa 123", "665456","JaviePoljkstrer@gmail.com"),
                new Paciente( new DateTime(1981,11,27), "MG00046",1,"Marcos", "Gustavez", "Calle VERDADERA 456", "1234578","marcosGustavez_12@gmail.com")
            };
            Paciente paciente3 = new Paciente(new DateTime(2000, 1, 25), "MG00045", 2, "Marcela", "Gimenez", "Calle falsa 1234", "123", "marcelita_gimenez@gmail.com");

            Paciente paciente4 = new Paciente(new DateTime(2005, 10, 5), "MP00123", 3, "Melody", "Pichichi", "Calle falsa 1235", "456", "pichichi_melu@gmail.com");

            Paciente paciente5 = new Paciente(new DateTime(1975, 12, 6), "JG00002", 4, "Juan", "Gomez", "Calle falsa 1236", "789", "jg_eyou23@gmail.com");

            pacientes.Add(paciente3);
            pacientes.Add(paciente4);
            pacientes.Add(paciente5);

            //TODO mostrar lista de pacientes 
            return pacientes;
        }
        public static int Insertar(Paciente paciente)
        {
            //TODO inserta paciente ; retorna el id del paciente agregado
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO elimina un paciente x id; retorna el id eliminado
            return 0;
        }

        public static Paciente TraerUno(string nroHistoriaMedica)
        {
            //TODO muestra 1 paciente x id; retorna ese paciente
            return null;
        }

        #endregion
    }
}
