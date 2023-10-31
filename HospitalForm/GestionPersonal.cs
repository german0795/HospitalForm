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
    public partial class GestionPersonal : Form
    {
        int nuevaId;
        string nuevoNombre;
        string nuevaEspecialidad;
        Form1 infoFormulario;

        public GestionPersonal(Form1 form)
        {
            InitializeComponent();
            infoFormulario = form;
            ActualizarLista();
        }
        public void ActualizarLista()
        {
            listBox1.Items.Clear();
            foreach (Medico medico in infoFormulario.PrincetonGeneral.ListaMedicos)
            {
                listBox1.Items.Add(medico.Nombre);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nuevaId = Convert.ToInt32(textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nuevoNombre = Convert.ToString(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            nuevaEspecialidad = Convert.ToString(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medico nuevoMedico = new Medico(nuevoNombre, nuevaId, nuevaEspecialidad);
            nuevoMedico.Alta(infoFormulario.PrincetonGeneral);
            ActualizarLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medico medicoSeleccionado = new Medico();
            foreach (Medico medico in infoFormulario.PrincetonGeneral.ListaMedicos)
            {
                if(medico.Nombre == listBox1.SelectedItem.ToString())
                    medicoSeleccionado = medico;
            }
            infoFormulario.PrincetonGeneral.ListaMedicos.Remove(medicoSeleccionado);
            ActualizarLista();
        }
    }
}
