using Proyecto_Integrador.Ayudantes;
using Proyecto_Integrador.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Integrador.Models
{
    public class Paciente :Persona
    {
        public Paciente()
        {
        }

        public Paciente(DateTime fechaNacimiento,  string nroHistoriaClinica, int id, string nombre, string apellido, string domicilio, string telefono, string email) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
            FechaNacimiento = fechaNacimiento;
            edad = UtilidadesFechas.CalcularEdad(fechaNacimiento);
        }

        public string NroHistoriaClinica { get; set; }

        public DateTime FechaNacimiento { get; set; }

        private int edad;
        public int Edad { get { 
                return edad; 
            } }

    }
}
