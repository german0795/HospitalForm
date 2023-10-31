using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HospitalForm
{
    public class Paciente : Persona
    {
        private string sintoma;
        private Medico medicoAsignado;

        public string Sintoma { get { return sintoma; } set { sintoma = value; } }
        public Medico MedicoAsignado { get {  return medicoAsignado; } set { medicoAsignado = value; } }

        public Paciente(string nombre, int id, string sintoma, Medico medicoPaciente)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.Sintoma = sintoma;
            this.MedicoAsignado = medicoPaciente;
        }

        public override void Alta(Hospital hospital)
        {
            hospital.ListaPacientes.Add(this);
            hospital.ListaGeneral.Add(this);
            this.medicoAsignado.ListaPacientes.Add(this);
        }
        public override void Baja(Hospital hospital)
        {
            hospital.ListaPacientes.Remove(this);
            hospital.ListaGeneral.Remove(this);
            this.medicoAsignado.ListaPacientes.Remove(this);

        }
        public override string ToString()
        {
            return "Paciente: " + Nombre + " Síntoma: " + Sintoma;
        }
        public static void MostrarPacientes(Hospital hospital)
        {
            hospital.ListaPacientes.ToString();
        }
    }
}
