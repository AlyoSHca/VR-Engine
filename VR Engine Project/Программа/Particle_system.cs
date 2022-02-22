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
	/// Класс Particle_system 
	/// интерфейс для системы частиц
	/// родительский класс Form
	///</summary>
    public partial class Particle_system : Form
    {
	///<summary>
	/// свойство particle
	/// объект класса Particle
	/// представление частицы
	///</summary>
        Particle particle = new Particle();

	///<summary>
	/// свойство particleEvent
	/// объект класса ParticleEvent
	/// хранение поведения частиц для всех событий
	///</summary>
        ParticleEvent particleEvent = new ParticleEvent();

	///<summary>
	/// свойство dB
	/// объект класса Particle_DB
	/// база данных шаблонов частиц
	///</summary>
        Particle_DB dB = new Particle_DB();

	///<summary>
	/// свойство function
	/// объект класса Particle_function
	/// функции перемещения/поведения частиц в пространстве
	///</summary>
        Particle_function function = new Particle_function();

	///<summary>
	/// Конструктор класса Particle_system
	/// инициализация графических компонентов
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
