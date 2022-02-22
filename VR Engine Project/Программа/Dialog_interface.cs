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
	/// Класс Dialog_interface 
	/// интерфейс для создания,редактирования диалоговых окон
	/// родительский класс Form
	///</summary>
    public partial class Dialog_interface : Form
    {
	///<summary>
	/// свойство editor
	/// объект класса DialogEditor
	/// редактирование диалоговых окон 
	///</summary>
        DialogEditor editor = new DialogEditor();

	///<summary>
	/// свойство pattern
	/// объект класса Pattern_dialog
	/// быстрое применение шаблонов диалоговых окон
	///</summary>
        Pattern_dialog pattern = new Pattern_dialog();

	///<summary>
	/// Конструктор класса Dialog_interface
	/// инициализация графических компонентов
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
