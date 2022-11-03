using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Ayudantes
{
    public static class UtilidadesFechas
    {
        public static int CalcularEdad (DateTime fechaNacimiento)
        {
            DateTime actualDate = DateTime.Now;
            int edad = -1;

            if (actualDate.Month > fechaNacimiento.Month)
            {
                edad++;
            }
            else if (edad == 0 && actualDate.Month == fechaNacimiento.Month)
            {
                if(actualDate.Day <= fechaNacimiento.Day)
                {
                    edad++;
                }
            }
            edad +=(actualDate.Year - fechaNacimiento.Year);
           
            //TODO agregar
            return edad;
        }
    }
}
