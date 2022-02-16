# VR-Engine

**VR Engine** – это программный комплекс, который упрощает разработку игр, предоставляя вам набор необходимых для разработки инструментов.
Обобщённо говоря, данный продукт ответственен за организацию и поведение игровых объектов, а также за их отображение на экране. Ваша же задача – выбрать, как они будут выглядеть и как себя вести. Для этого движок предоставит вам возможность создавать и удалять объекты, задавать их параметры, добавлять логику и управлять ресурсами.
Данный игровой движок разработан с целью упрощения создания ПО и игр для VR/AR.

## Модули, которые предоставляет VR Engine:
*	Система частиц;
*	Редактор местности;
*	Модуль редактирования звуковых дорожек и вызывающих их событий;
*	Модуль отображения и взаимодействия со сценой в реальном времени;
*	Модуль шейдера;
*	Модуль диалоговых окон;
*	Редактор написания кода.

### Модуль шейдера
Программы, работающие с трёхмерной графикой и видео (игры, GIS, CAD, CAM и др.), используют шейдеры для определения параметров геометрических объектов или изображения, для изменения изображения (для создания эффектов сдвига, отражения, преломления, затемнения с учётом заданных параметров поглощения и рассеяния света, для наложения текстур на геометрические объекты и др.).

### Модуль отображения и взаимодействия со сценой
Модуль отображения и взаимодействия со сценой является интерфейсом пользователя и через взаимодействие с ним нажатием горячих клавиш и кнопок мыши можно вызвать методы модуля шейдера, которые перерисуют изображение на сцене. Также на нее можно добавлять объекты, изменять, перемещать и прочее.

### Модуль воспроизведения звука
Модуль воспроизведения звука представляет собой пользовательский интерфейс для добавления звуковых дорожек в создаваемый проект, их изменения, удаления и пр.

### Редактор местности
Редактор местности представляет собой удобный инструмент для быстрого создания рельефа карты, ее высот, добавление объектов и их генерацию. Система уровней представляет собой интерфейс для удобного создания карт (уровней) проекта, их изменения в сцене, удобное переключение уровней между собой (осуществление навигации по проекту).

### Система частиц
Система частиц – используемый в компьютерной графике способ представления объектов, не имеющих чётких геометрических границ (различные облака, туманности, взрывы, струи пара, шлейфы от ракет, дым, снег, дождь и т. п.). Системы частиц могут быть реализованы как в двумерной, так и в трёхмерной графике.

### Модуль диалоговых окон
Модуль диалоговых окон – это инструмент для добавления в игру различных панелей элементов (главных и второстепенных меню, настроек графики и персонажа, всплывающих подсказок во время прохождения игры, карты местности и пр.).

### Редактор написания кода
Редактор написания кода представляет собой модуль, в котором описывается основная логика приложения, которую нельзя реализовать с помощью ранее описанных инструментов. Это вызов от элементов меню, изменения показателей игрока в зависимости от его действий и их отображение в соответствующем диалоговом окне или изменения звуковой дорожки в зависимости от ситуации, с которой столкнулся игрок и пр.

## Архитектура VR Engine
Ниже представлена диаграмма классов разрабатываемого ПО.
![Диаграмма классов](class_diagram.png)
### Классы модуля шейдера
К модулю шейдера относятся такие классы, как:
* *Vector4*,
* *Mesh*,
* *MeshCreater*,
* *Matrix*,
* *Matrix4*,
* *Face*,
* *Camera*,
* *Vertex*.

Более подробно рассмотрим класс *Camera*. 
```
  ///<summary>
	/// Класс Camera
	/// реализация камеры
	/// основной объект в сцене
	///</summary>
    public class Camera : INotifyPropertyChanged
    {
	///<summary>
	/// свойство _position
	/// значение типа класса Vector3
	/// расположения камеры
	///</summary>
        private Vector3 _position;

	///<summary>
	/// свойство _observerPoint
	/// объект класса Vector3
	/// вектор расположения точки наблюдения
	///</summary>
        private Vector3 _observerPoint;

	///<summary>
	/// свойство _focus
	/// значение типа double 
	/// фокус камеры
	///</summary>
        private double _focus;

	///<summary>
	/// Метод Focus типа double
	/// получение и отправка текущего  
	/// значения фокуса камеры
	///</summary>
        public double Focus
        {
            get
            {
                return _focus;
            }
            set
            {
                _focus = value;
                OnCoordinateChanged(nameof(Focus));
            }
        }

	///<summary>
	/// Метод Position типа Vector3
	/// получение и отправка текущего  
	/// значения позиции камеры
	///</summary>
        public Vector3 Position
        {
            get {
                return _position;
            }
            set
            {
                _position = value;
                OnCoordinateChanged(nameof(Position));
            }
        }

	///<summary>
	/// Метод ObserverPoint типа Vector3
	/// получение и отправка текущего  
	/// значения точки наблюдения
	///</summary>
        public Vector3 ObserverPoint
        {
            get
            {
                return _observerPoint;
            }
            set
            {
                _observerPoint = value;
                OnCoordinateChanged(nameof(ObserverPoint));
            }
        }
    }
```
### Классы модуля диалоговых окон
К модулю диалоговых окон относятся такие классы, как:
* *Dialog_interface*,
* *Pattern_dialog*,
* *DialogEditor*.

Более подробно рассмотрим класс *Dialog_interface*. 
```
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
    }
```
### Классы редактора написания кода
К модулю редактора написания кода относятся такие классы, как:
* *Code_editor*,
* *Pattern_code*,
* *Expert_system*,
* *Interpreter*.

Более подробно рассмотрим класс *Code_editor*. 
```
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
    }
```
### Классы системы частиц
К модулю системы частиц относятся такие классы, как:
* *Particle_system*,
* *ParticleEvent*,
* *Particle*,
* *Patricle_DB*.

Более подробно рассмотрим класс *Particle_system*.
```
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
    }
```
### Классы редактора местности
К модулю редактора местности относятся такие классы, как:
* *terrain_editor*,
* *Relief_map*,
* *PaintTexture*,
* *Generation_rule*.

Более подробно рассмотрим класс *terrain_editor*.
```
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
    }
```
### Классы модуля воспроизведения звука
К модулю воспроизведения звука относятся такие классы, как:
* *Sound_interface*,
* *SoundEditor*,
* *Sound_DB*,
* *SoundEvent*.

Более подробно рассмотрим класс *Sound_interface*.
```
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
    }
```
### Классы модуля отображения и взаимодействия со сценой
К модулю отображения и взаимодействия со сценой относятся такие классы, как:
* *Scene*,
* *DrawContainer*,
* *SceneObject*,
* *Vector3*.

Более подробно рассмотрим класс *Scene*.
```
//<summary>
	/// Класс Scene 
	/// взаимодействия пользователя со сценой
	///</summary>
    public class Scene
    {
	///<summary>
	/// свойство _isPerspective
	/// объект типа bool
	/// сцену отрисовывать в перспективе
	///</summary>
        private bool _isPerspective;
	
	///<summary>
	/// свойство _isWireframe
	/// объект типа bool
	/// сцену отрисовывать полигональной
	///</summary>
        private bool _isWireframe;
        private bool _isFilled;

	///<summary>
	/// свойство _near
	/// объект типа double
	/// приближать камеру
	///</summary>
        private double _near;
	
	///<summary>
	/// свойство _far
	/// объект типа double
	/// отдалять камеру
	///</summary>
        private double _far;
	
	///<summary>
	/// свойство _isZBuffer
	/// объект типа bool
	/// использовать метод Zbuffer
	///</summary>
        private bool _isZBuffer;
	
	///<summary>
	/// свойство MainCamera
	/// объект класса Camera
	/// проецирование изображения с камеры на сцену
	///</summary>
        public Camera MainCamera;
        public ObservableCollection<SceneObject> ObjectList { get; set; }
```
Методы класса *Scene* представлены как:
* конструктор класса *Scene*,
* геттеры и сеттеры свойств *Scene* (*_far*, *_isZbuffer*, *_near*, *_isPerspective*, *_isWireframe*, *_isFilled*),
* метод добавления объекта на сцену.
```
	///<summary>
	/// Метод Far типа double
	/// получение и отправка текущего  
	/// значения отдаления
	///</summary>
        public double Far {
            get
            {
                return _far;
            }
            set
            {
                _far = value;
                ScenePropertiesChanged();
            }
        }
	
	///<summary>
	/// Метод Near типа double
	/// получение и отправка текущего  
	/// значения приближения
	///</summary>
        public double Near
        {
            get
            {
                return _near;
            }
            set
            {
                _near = value;
                ScenePropertiesChanged();
            }
        }

	///<summary>
	/// Метод IsZBuffer типа bool
	/// получение и отправка текущего  
	/// значения использования zbuffer
	///</summary>
        public bool IsZBuffer
        {
            get
            {
                return _isZBuffer;
            }
            set
            {
                _isZBuffer = value;
                ScenePropertiesChanged();
            }
        }

	///<summary>
	/// Метод IsPerspective типа bool
	/// получение и отправка текущего  
	/// значения использования перспективы
	///</summary>
        public bool IsPerspective {
            get
            {
                return _isPerspective;
            }
            set
            {
                _isPerspective = value;
                ScenePropertiesChanged();
            }
        }

	///<summary>
	/// Метод IsWireframe типа bool
	/// получение и отправка текущего  
	/// значения вида отрисовки
	///</summary>
        public bool IsWireframe
        {
            get
            {
                return _isWireframe;
            }
            set
            {
                _isWireframe = value;
                ScenePropertiesChanged();
            }
        }

	///<summary>
	/// Метод IsFilled типа bool
	/// получение и отправка текущего  
	/// значения вида отрисовки (не wireframe)
	///</summary>
        public bool IsFilled
        {
            get
            {
                return _isFilled;
            }
            set
            {
                _isFilled = value;
                ScenePropertiesChanged();
            }
        }

	///<summary>
	/// Конструктор класса Scene
	/// Создание объекта класса Scene  
	/// по умолчанию
	///</summary>
        public Scene()
        {
            MainCamera = new Camera(-4, 2, 4);
            MainCamera.OnPositionChangedEvent += ScenePropertiesChanged;
            MainCamera.OnObserverPointChangedEvent += ScenePropertiesChanged;
            MainCamera.PropertyChanged += MainCamera_PropertyChanged;
            ObjectList = new ObservableCollection<SceneObject>();
            ObjectList.CollectionChanged += ObjectCollectionChanged;
            _isPerspective = true;
            _isFilled = true;
            _isWireframe = false;
            _isZBuffer = true;
            _near = 0.2;
            _far = 100.0;
        }
	
	///<summary>
	/// Метод AddObject типа void
	/// добавление выбранных объектов на сцене
	///</summary>
	///<param name="obj">Объект класса SceneObject</param>
        public void AddObject(SceneObject obj)
        {
            obj.PropertyChanged += TransformChanged;
            ObjectList.Add(obj);
        }
   }
```
## Сценарии использования
### *Environment artist*
Данный продукт может использоваться для создания любого рельефа, иерархии карт, процедурной генерации местности с помощью удобного инструментария редактора местности terrain_editor. 
### *3D-artist*
Данный продукт может использоваться для необычной и современной презентации своих проектов. Например, перенос 3D-модели в Blender на сцену VR Engine. С помощью интуитивно-понятного интерфейса, похожего на аналоги, человек без особого технического образования может добавить свои файлы, выбрать интересующий шаблон сцены, освещения и получить за короткий срок готовую VR-презентацию своего продукта и добавить себе в портфолио.
### *Software Programmer*
Данный вид пользователя может разрабатывать более уникальные продукты на основе шаблонов или на чистом ЯП. Добавлять новые модули проектирования, утилиты для упрощения работы и пр.
### *VFX-designer*
Художник по визуальным эффектам может использовать данный продукт для создания спецэффектов, настройки и доработки существующих шаблонов эффектов, частиц с помощью модуля *Particle_system*.
