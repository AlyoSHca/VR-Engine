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
	/// Класс Code_editor
	/// интерфейс для редактирования кода
	/// родительский класс Form
	///</summary>
    public partial class Code_editor : Form
    {
	///<summary>
	/// Конструктор класса Code_editor
	/// инициализация графических компонентов
	///</summary>
        public Code_editor()
        {
            InitializeComponent();
        }
	///<summary>
	/// свойство code
	/// объект класса Pattern_code
	/// быстрое применение шаблонов
	///</summary>
        Pattern_code code = new Pattern_code();

	///<summary>
	/// свойство interpreter
	/// объект класса Interpreter
	/// интерпретатор написанного кода
	///</summary>
        Interpreter interpreter = new Interpreter();

	///<summary>
	/// свойство expert_System
	/// объект класса Expert_system
	/// экспертная система по выявлению потребностей
	///</summary>
        Expert_system expert_System = new Expert_system();

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
