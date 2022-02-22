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
	/// Класс Sound_interface
	/// интерфейс для системы редактирования звуковых эффектов
	/// родительский класс Form
	///</summary>
    public partial class Sound_interface : Form
    {
	///<summary>
	/// свойство se
	/// объект класса SoundEditor
	/// редактор звуковых дорожек
	///</summary>
        SoundEditor se = new SoundEditor();

	///<summary>
	/// свойство soundEvent
	/// объект класса SoundEvent
	/// хранение звуковых эфектов для заданных событий
	///</summary>
        SoundEvent soundEvent = new SoundEvent();

	///<summary>
	/// свойство Sound_DB
	/// объект класса Sound_DB
	/// хранение шаблонов звуковых эффектов и событий
	///</summary>
        Sound_DB Sound_DB = new Sound_DB();

	///<summary>
	/// Конструктор класса Sound_interface
	/// инициализация графических компонентов
	///</summary>
        public Sound_interface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
