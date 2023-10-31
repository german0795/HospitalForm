using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalForm
{    public class Persona
    {
        private int id;
        private string nombre;
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Persona() { }
        public Persona(string nombre, int id)
        {
            this.Nombre = nombre;
            this.Id = id;
        }

        public virtual void Alta(Hospital hospital)
        {
        }
        public virtual void Baja(Hospital hospital)
        {
        }
    }
}
