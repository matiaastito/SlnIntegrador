using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio.Models
{
    public class AdmMedico
    {
        List<Medico> medicos;

        #region Metodos

        public List<Medico> Listar()
        {

            medicos = new List<Medico>()
            {
                new Medico("Clinico", "AB123",0,"Juan", "Perez", "Calle falsa 123", "4756547","juanperez@gmail.com"), 
                new Medico("Pediatra", "CD456",1,"Maria", "Gomez", "Calle VERDADERA 456", "1234578","mariagomez123@gmail.com")
            };
            Medico medico3 = new Medico("Pediatra", "CDE452", 2, "Martin", "Gimenez", "Calle falsa 1234", "123", "Martingimenez@gmail.com");

            Medico medico4 = new Medico("Traumatologo", "GHF45", 3, "Mauricio", "Peralta", "Calle falsa 1235", "456", "peraltamauricio@gmail.com");

            Medico medico5 = new Medico("Clinico", "SAD42", 4, "Javiera", "Castro", "Calle falsa 1236", "789", "castroJavi_09@gmail.com");

            medicos.Add(medico3);
            medicos.Add(medico4);
            medicos.Add(medico5);

            //TODO mostrar listado medicos 
            return medicos;
        }

        public List<Medico> Listar(string especialidad)
        {
            //TODO mostrar listado medico x especialidad
            return null;
        }

        public int Insertar (Medico medico)
        {
            //TODO inserta medico ; retorna el id del medico agregado
            return 0;
        }

        public int Eliminar (int id) 
        {
            //TODO elimina un medico x id; retorna el id eliminado
            return 0;
        }

        public Medico TraerUno(int id)
        {
            //TODO muestra 1 medico x id; retorna ese medico
            return null;
        }

        #endregion
    }
}
