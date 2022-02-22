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
	///<summary>
	/// ����� Code_editor
	/// ��������� ��� �������������� ����
	/// ������������ ����� Form
	///</summary>
    public partial class Code_editor : Form
    {
	///<summary>
	/// ����������� ������ Code_editor
	/// ������������� ����������� �����������
	///</summary>
        public Code_editor()
        {
            InitializeComponent();
        }
	///<summary>
	/// �������� code
	/// ������ ������ Pattern_code
	/// ������� ���������� ��������
	///</summary>
        Pattern_code code = new Pattern_code();

	///<summary>
	/// �������� interpreter
	/// ������ ������ Interpreter
	/// ������������� ����������� ����
	///</summary>
        Interpreter interpreter = new Interpreter();

	///<summary>
	/// �������� expert_System
	/// ������ ������ Expert_system
	/// ���������� ������� �� ��������� ������������
	///</summary>
        Expert_system expert_System = new Expert_system();

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
