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
	/// ����� Dialog_interface 
	/// ��������� ��� ��������,�������������� ���������� ����
	/// ������������ ����� Form
	///</summary>
    public partial class Dialog_interface : Form
    {
	///<summary>
	/// �������� editor
	/// ������ ������ DialogEditor
	/// �������������� ���������� ���� 
	///</summary>
        DialogEditor editor = new DialogEditor();

	///<summary>
	/// �������� pattern
	/// ������ ������ Pattern_dialog
	/// ������� ���������� �������� ���������� ����
	///</summary>
        Pattern_dialog pattern = new Pattern_dialog();

	///<summary>
	/// ����������� ������ Dialog_interface
	/// ������������� ����������� �����������
	///</summary>
        public Dialog_interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
