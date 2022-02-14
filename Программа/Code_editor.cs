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
    public partial class Code_editor : Form
    {
        public Code_editor()
        {
            InitializeComponent();
        }
        Pattern_code code = new Pattern_code();
        Interpreter interpreter = new Interpreter();
        Expert_system expert_System = new Expert_system();
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
