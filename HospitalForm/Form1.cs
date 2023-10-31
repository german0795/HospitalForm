using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalForm
{
    public partial class Form1 : Form
    {
        public Hospital PrincetonGeneral = new Hospital();

        Medico drHouse = new Medico("Gregory House", 0101, "Epidemiólogo");
        Medico drWilson = new Medico("Robert Wilson", 0102, "Oncólogo");
        Medico drChase = new Medico("Australian Chase", 0103, "Cirujano");

        public Form1()
        {
            InitializeComponent();
            drHouse.Alta(PrincetonGeneral);
            drWilson.Alta(PrincetonGeneral);
            drChase.Alta(PrincetonGeneral);
        }



       

        private void button1_Click(object sender, EventArgs e)
        {
            GestionPersonal gestionPersonal = new GestionPersonal(this);
            gestionPersonal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GestionPacientes gestionPacientes = new GestionPacientes();
            gestionPacientes.Show();

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
