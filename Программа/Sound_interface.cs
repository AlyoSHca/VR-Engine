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
    public partial class Sound_interface : Form
    {
        SoundEditor se = new SoundEditor();
        SoundEvent soundEvent = new SoundEvent();
        Sound_DB Sound_DB = new Sound_DB();
        public Sound_interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
