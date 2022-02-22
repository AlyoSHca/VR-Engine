using System;
using AMath;
using System.ComponentModel;

namespace Visualizer
{
	///<summary>
	/// ����� Camera
	/// ���������� ������
	/// �������� ������ � �����
	///</summary>
    public class Camera : INotifyPropertyChanged
    {
	///<summary>
	/// �������� _position
	/// �������� ���� ������ Vector3
	/// ������������ ������
	///</summary>
        private Vector3 _position;

	///<summary>
	/// �������� _observerPoint
	/// ������ ������ Vector3
	/// ������ ������������ ����� ����������
	///</summary>
        private Vector3 _observerPoint;

	///<summary>
	/// �������� _focus
	/// �������� ���� double 
	/// ����� ������
	///</summary>
        private double _focus;

	///<summary>
	/// ����� Focus ���� double
	/// ��������� � �������� ��������  
	/// �������� ������ ������
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
	/// ����� Position ���� Vector3
	/// ��������� � �������� ��������  
	/// �������� ������� ������
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
	/// ����� ObserverPoint ���� Vector3
	/// ��������� � �������� ��������  
	/// �������� ����� ����������
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
	/// ����������� ������ Camera
	/// �������� ������� ������ Camera  
	/// � ������ ���������������
	///</summary>
	///<param name="x">���������� x</param>
	///<param name="y">���������� y</param>
	///<param name="z">���������� z</param>
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
/// ����������� ������ Camera
/// �������� ������� ������ Camera  
/// � ������ �������� ������ � ������ ����������
///</summary>
///<param name="position">����� ������� ������</param>
///<param name="observerPoint">����� ����� ����������</param>
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
/// ����� Rotate
/// ������� ������ �� ������������ ����
///</summary>
///<param name="doubleX">������� ����������� �� ��� �</param>
///<param name="doubleY">������� ����������� �� ��� Y</param>
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
/// ����� GoCloser
/// ����������� ������
///</summary>
///<param name="value">��������, �� ������� ������������ ������</param>
        public void GoCloser(double value)
        {
            Vector3 NewView = ViewVector() * (1 - value);
            Position = new Vector3(NewView.X + ObserverPoint.X, NewView.Y + ObserverPoint.Y, NewView.Z + ObserverPoint.Z);
        }

///<summary>
/// ����� GoFather
/// ��������� ������
///</summary>
///<param name="value">��������, �� ������� ���������� ������</param>
        public void GoFarther(double value)
        {
            Vector3 NewView = ViewVector() * (1 + value);
            Position = new Vector3(NewView.X + ObserverPoint.X, NewView.Y + ObserverPoint.Y, NewView.Z + ObserverPoint.Z);
        }

///<summary>
/// ����� ViewVector ���� Vector3
/// ��������� ������������ �������
///</summary>
        public Vector3 ViewVector()
        {
            return Position - ObserverPoint;
        }
    }
}