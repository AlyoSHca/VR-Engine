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
	/// ����� Particle_system 
	/// ��������� ��� ������� ������
	/// ������������ ����� Form
	///</summary>
    public partial class Particle_system : Form
    {
	///<summary>
	/// �������� particle
	/// ������ ������ Particle
	/// ������������� �������
	///</summary>
        Particle particle = new Particle();

	///<summary>
	/// �������� particleEvent
	/// ������ ������ ParticleEvent
	/// �������� ��������� ������ ��� ���� �������
	///</summary>
        ParticleEvent particleEvent = new ParticleEvent();

	///<summary>
	/// �������� dB
	/// ������ ������ Particle_DB
	/// ���� ������ �������� ������
	///</summary>
        Particle_DB dB = new Particle_DB();

	///<summary>
	/// �������� function
	/// ������ ������ Particle_function
	/// ������� �����������/��������� ������ � ������������
	///</summary>
        Particle_function function = new Particle_function();

	///<summary>
	/// ����������� ������ Particle_system
	/// ������������� ����������� �����������
	///</summary>
        public Particle_system()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
