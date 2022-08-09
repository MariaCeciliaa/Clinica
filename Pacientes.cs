using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.SetVisibleCore(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PacientesCriar pacientesCriar = new PacientesCriar();   //comando para troca de telas
            this.SetVisibleCore(false);
        }
    }
}
