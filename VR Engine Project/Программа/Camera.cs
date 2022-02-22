using System;
using AMath;
using System.ComponentModel;

namespace Visualizer
{
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnCoordinateChanged(string propertyName)
        {
            OnCoordinateChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected void OnCoordinateChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public event PositionChanged OnPositionChangedEvent;
        public event ObserverPointChanged OnObserverPointChangedEvent;
        public delegate void PositionChanged();
        public delegate void ObserverPointChanged();

	///<summary>
	/// Конструктор класса Camera
	/// Создание объекта класса Camera  
	/// с другим местоположением
	///</summary>
	///<param name="x">Координата x</param>
	///<param name="y">Координата y</param>
	///<param name="z">Координата z</param>
        public Camera(double x, double y, double z)
        {
            Position = new Vector3();
            ObserverPoint = new Vector3();
            Position.X = x;
            Position.Y = y;
            Position.Z = z;
            ObserverPoint.X = 0;
            ObserverPoint.Y = 0;
            ObserverPoint.Z = 0;
            Position.PropertyChanged += CameraPositionChanged;
            Position.PropertyChanged += CameraObserverPointChanged;
        }
	
///<summary>
/// Конструктор класса Camera
/// Создание объекта класса Camera  
/// с другой позицией камеры и точкой наблюдения
///</summary>
///<param name="position">Новая позиция камеры</param>
///<param name="observerPoint">Новая точка наблюдения</param>
        public Camera(Vector3 position, Vector3 observerPoint)
        {
            Position = new Vector3(position);
            ObserverPoint = new Vector3(observerPoint);
            Position.PropertyChanged += CameraPositionChanged;
            Position.PropertyChanged += CameraObserverPointChanged;
        }

        private void CameraPositionChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPositionChangedEvent();
        }

        private void CameraObserverPointChanged(object sender, PropertyChangedEventArgs e)
        {
            OnObserverPointChangedEvent();
        }

///<summary>
/// Метод Rotate
/// Поворот камеры на определенный угол
///</summary>
///<param name="doubleX">Угловой коэффициент по оси Х</param>
///<param name="doubleY">Угловой коэффициент по оси Y</param>
        public void Rotate(double angleX, double angleY)
        {
            if (ObserverPoint.X == 0 && ObserverPoint.Y == 0 && ObserverPoint.Z == 0)
            {
                Vector3 CameraVector = Position - ObserverPoint;
                double r = CameraVector.Length();
                Position = new Vector3(r * Math.Sin(angleY) * Math.Sin(angleX),
                    r * Math.Cos(angleY), -r * Math.Sin(angleY) * Math.Cos(angleX));
            }
            else
            {
                Vector3 CameraVector = Position - ObserverPoint;
                double r = 8;
                Position = new Vector3(r * Math.Sin(angleY) * Math.Sin(angleX),
                        r * Math.Cos(angleY), -r * Math.Sin(angleY) * Math.Cos(angleX));
            }
        }

///<summary>
/// Метод GoCloser
/// Приближение камеры
///</summary>
///<param name="value">Значение, на которое приближается камера</param>
        public void GoCloser(double value)
        {
            Vector3 NewView = ViewVector() * (1 - value);
            Position = new Vector3(NewView.X + ObserverPoint.X, NewView.Y + ObserverPoint.Y, NewView.Z + ObserverPoint.Z);
        }

///<summary>
/// Метод GoFather
/// Отдаление камеры
///</summary>
///<param name="value">Значение, на которое отдаляется камера</param>
        public void GoFarther(double value)
        {
            Vector3 NewView = ViewVector() * (1 + value);
            Position = new Vector3(NewView.X + ObserverPoint.X, NewView.Y + ObserverPoint.Y, NewView.Z + ObserverPoint.Z);
        }

///<summary>
/// Метод ViewVector типа Vector3
/// Получение наблюдаемого вектора
///</summary>
        public Vector3 ViewVector()
        {
            return Position - ObserverPoint;
        }
    }
}