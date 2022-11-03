using Negocio.Models;
using Proyecto_Integrador.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Form1 : Form
    {

        #region definicion y creacion de instancias

        #region administradores
        AdmMedico administradorMedico = new AdmMedico();
        AdmHabitacion administradorHabitacion = new AdmHabitacion();
        AdmPaciente admPaciente = new AdmPaciente();
        #endregion

        #region listas
        List<Medico> listaMedicos;
        List<Paciente> listaPaciente;
        List<Habitacion> listaHabitaciones;
        #endregion

        #endregion

        public Form1()
        {
            InitializeComponent();
        }


        private void btnListarMedicos_Click(object sender, EventArgs e)
        {
            listaMedicos = administradorMedico.Listar();
        }

        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            listaPaciente = admPaciente.Listar();
        }

        private void btnListarHabitaciones_Click(object sender, EventArgs e)
        {
            listaHabitaciones = administradorHabitacion.Listar();
        }

        private void btnMostarListaMedicos_Click(object sender, EventArgs e)
        {
            gridMedicos.DataSource = listaMedicos;
        }

        private void btnMostarListaPacientes_Click(object sender, EventArgs e)
        {
            gridPacientes.DataSource = listaPaciente;
        }

        private void btnContarYMostrarClinicos_Click(object sender, EventArgs e)
        {
            foreach (Medico medico in listaMedicos)
            {
                if (string.Compare(medico.Especialidad.ToUpper(), "CLINICO") == 0)
                {
                    lstMedicosClinicos.Items.Add(medico.Nombre + " " + medico.Apellido);
                }
            }
        }

        private void btnContaryListarHabitaciones_Click(object sender, EventArgs e)
        {
            foreach (Habitacion habitacion in listaHabitaciones)
            {
                lstHabitaciones.Items.Add(habitacion.Numero + " " + habitacion.Estado);
            }
        }


    }
}
