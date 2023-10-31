using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{
    public class Medico : Persona
    {
        private string especialidad;
        private List<Paciente> listaPacientes = new List<Paciente>();
        public string Especialidad { get { return especialidad; } set { especialidad = value; } }
        public List<Paciente> ListaPacientes { get { return listaPacientes; } set { listaPacientes = value; } }
        public Medico() { }

        public Medico(string nombre, int id, string especialidad)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Especialidad = especialidad;
        }
        public override void Alta(Hospital hospital)
        {
            hospital.ListaMedicos.Add(this);
            hospital.ListaGeneral.Add(this);
        }
        public override void Baja(Hospital hospital)
        {
            hospital.ListaMedicos.Remove(this);
            hospital.ListaGeneral.Remove(this);
        }
        public override string ToString()
        {
            return "Médico: " + Nombre + " Especialidad: " + Especialidad;
        }
        public void ListarPacientes()
        {
            Console.WriteLine("Los pacientes del doctor " + this.Nombre + " son: ");
            foreach (Paciente paciente in this.ListaPacientes)
            {
                Console.WriteLine(paciente.ToString());
            }
        }
    }
}
