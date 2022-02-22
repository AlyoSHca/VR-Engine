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
	/// Класс terrain_editor 
	/// интерфейс для редактора местности
	/// родительский класс Form
	///</summary>
    public partial class terrain_editor : Form
    {
	///<summary>
	/// свойство rm
	/// объект класса Relief_map
	/// карта рельефа, объема и системы уровней
	///</summary>
        Relief_map rm = new Relief_map();

	///<summary>
	/// свойство paintTexture
	/// объект класса PaintTexture
	/// набор цветовых палитр, текстур и наложение на рельеф
	///</summary>
        PaintTexture paintTexture = new PaintTexture();

	///<summary>
	/// свойство gr
	/// объект класса Generation_rule
	/// правила генерации карты и их задача
	///</summary>
        Generation_rule gr = new Generation_rule();

	///<summary>
	/// Конструктор класса terrain_editor
	/// инициализация графических компонентов
	///</summary>
        public terrain_editor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
