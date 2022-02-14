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
    public partial class Dialog_interface : Form
    {
        DialogEditor editor = new DialogEditor();
        Pattern_dialog pattern = new Pattern_dialog();
        public Dialog_interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
