using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizer
{
    public partial class Particle_system : Form
    {
        Particle particle = new Particle();
        ParticleEvent particleEvent = new ParticleEvent();
        Particle_DB dB = new Particle_DB();
        Particle_function function = new Particle_function();
        public Particle_system()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
