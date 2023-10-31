using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    public class Hospital
    {
        private List<Persona> listaGeneral = new List<Persona>();
        private List<Medico> listaMedicos = new List<Medico>();
        private List<Paciente> listaPacientes = new List<Paciente>();

        public List<Persona> ListaGeneral { get { return listaGeneral; } set { listaGeneral = value; } }
        public List<Medico> ListaMedicos { get { return listaMedicos; } set { listaMedicos = value; } }
        public List<Paciente> ListaPacientes { get {  return listaPacientes; } set { listaPacientes = value; } }

        public void ListarPersonas()
        {
            Console.WriteLine("Lista de personas: ");
            foreach (Persona persona in listaGeneral)
                Console.WriteLine(persona.ToString());
        }
        public void ListarMedicos()
        {
            Console.WriteLine("Lista de médicos: ");
            foreach (Medico medico in listaMedicos)
                Console.WriteLine(medico.ToString());
        }
        public void ListarPacientes()
        {
            Console.WriteLine("Lista de pacientes: ");
            foreach (Paciente paciente in listaPacientes)
                Console.WriteLine(paciente.ToString());
        }

    }
}
