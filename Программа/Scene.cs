using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using AMath;
using System.IO;
using System.Drawing;

namespace Visualizer
{
	///<summary>
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

        public event SceneChanged OnSceneChangedEvent; 
        public delegate void SceneChanged();
        public event ObjectListChanged OnObjectListChanged;
        public delegate void ObjectListChanged();

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

        private void MainCamera_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnSceneChangedEvent();
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

        private void TransformChanged(object sender, PropertyChangedEventArgs e)
        {
            OnSceneChangedEvent();
        }

        private void ObjectCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnSceneChangedEvent();
            OnObjectListChanged();
        }

        private void ScenePropertiesChanged()
        {
            OnSceneChangedEvent();
        }

        public Scene(string fileName)
        {
            List<string> lines = new List<string>(File.ReadLines(fileName));

            _isZBuffer = Convert.ToBoolean(lines[1].Split(' ').Last());
            _isPerspective = Convert.ToBoolean(lines[2].Split(' ').Last());
            _isWireframe = Convert.ToBoolean(lines[3].Split(' ').Last());
            _isFilled = Convert.ToBoolean(lines[4].Split(' ').Last());
            _near = Convert.ToDouble(lines[5].Split(' ').Last());
            _far = Convert.ToDouble(lines[6].Split(' ').Last());
            Vector3 position = new Vector3(lines[8].Split(':').ElementAt(1).Split(';').Select(s => Convert.ToDouble(s.Trim())).ToArray());
            Vector3 observerPoint = new Vector3(lines[9].Split(':').ElementAt(1).Split(';').Select(s => Convert.ToDouble(s.Trim())).ToArray());
            MainCamera = new Camera(position, observerPoint);
            ObjectList = new ObservableCollection<SceneObject>();

            for(int i = 11; i < lines.Count; i += 20)
            {
                string name = lines[i].Substring(2, lines[i].Length - 3);
                byte[] bColor = lines[i + 2].Substring(13, lines[i + 2].Length - 14).Split(',').Select(s => Convert.ToByte(s.Trim())).ToArray();
                Color color = Color.FromArgb(bColor[0], bColor[1], bColor[2], bColor[3]);
                Vector3 transfer = new Vector3(lines[i + 3].Split(':').ElementAt(1).Split(';').Select(s => Convert.ToDouble(s.Trim())).ToArray());
                Vector3 rotation = new Vector3(lines[i + 4].Split(':').ElementAt(1).Split(';').Select(s => Convert.ToDouble(s.Trim())).ToArray());
                Vector3 scale = new Vector3(lines[i + 5].Split(':').ElementAt(1).Split(';').Select(s => Convert.ToDouble(s.Trim())).ToArray());
                int countFigure = Convert.ToInt32(lines[i + 7].Split(' ').Last());
                double length = Convert.ToDouble(lines[i + 8].Split(' ').Last());
                double heightPyramid = Convert.ToDouble(lines[i + 9].Split(' ').Last());
                double radiusTorus = Convert.ToDouble(lines[i + 10].Split(' ').Last());
                int stereoCount = Convert.ToInt32(lines[i + 11].Split(' ').Last());
                double radiusFrustum2 = Convert.ToDouble(lines[i + 12].Split(' ').Last());
                double radiusFrustum1 = Convert.ToDouble(lines[i + 13].Split(' ').Last());
                double  heightFrustum3= Convert.ToDouble(lines[i + 14].Split(' ').Last());
                double radiusHalfsphere = Convert.ToDouble(lines[i + 15].Split(' ').Last());
                double heightFrustum = Convert.ToDouble(lines[i + 16].Split(' ').Last());
                double heightCylinder = Convert.ToDouble(lines[i + 17].Split(' ').Last());
                double heightBox = Convert.ToDouble(lines[i + 18].Split(' ').Last());
                double controle = Convert.ToDouble(lines[i + 19].Split(' ').Last());
                ObjectList.Add(new SceneObject(name, new Queen(countFigure, length,
                    heightPyramid, radiusTorus, stereoCount, radiusFrustum2, radiusFrustum1,
                    heightFrustum3, radiusHalfsphere, heightFrustum, heightCylinder,
                    heightBox,  controle), transfer, rotation, scale, color));
            }

            MainCamera.OnPositionChangedEvent += ScenePropertiesChanged;
            MainCamera.OnObserverPointChangedEvent += ScenePropertiesChanged;
            MainCamera.PropertyChanged += MainCamera_PropertyChanged;
            ObjectList.CollectionChanged += ObjectCollectionChanged;
        }

        public void SaveToFile(string fileName)
        {
            List<string> result = new List<string>();

            result.Add("Scene");
            result.Add("ZBuffer: " + IsZBuffer);
            result.Add("Perspective: " + IsPerspective);
            result.Add("Wireframe: " + IsWireframe);
            result.Add("Filled: " + IsFilled);
            result.Add("Near: " + Near);
            result.Add("Far: " + Far);
            result.Add("Camera");
            result.Add("Position: " + MainCamera.Position);
            result.Add("ObserverPoint: " + MainCamera.ObserverPoint);
            result.Add(string.Format("Object(Count = {0})", ObjectList.Count));

            foreach(SceneObject so in ObjectList)
            {
                result.Add(" \"" + so.Name + "\"");
                result.Add(" " + string.Format(" {0} вершины, {1} полигоны", so.Mesh.Verteces.Count, so.Mesh.Faces.Count));
                result.Add("Color:  " + string.Format("argb({0}, {1}, {2}, {3})", so.Color.A, so.Color.R, so.Color.G, so.Color.B));
                result.Add("Transfer: " + so.Transfer);
                result.Add("Rotation: " + so.Rotation);
                result.Add("Scale: " + so.Scale);
                result.Add("Parameters");
                result.Add("Count frustum 4,5: " + ((Queen)so.Mesh).countFigure);
                result.Add("Lenght: " + ((Queen)so.Mesh).length);
                result.Add("Height Pyramid: " + ((Queen)so.Mesh).heightPyramid);
                result.Add("Radius Torus: " + ((Queen)so.Mesh).radiusTorus);
                result.Add("Count: " + ((Queen)so.Mesh).Count);
                result.Add("Radius Frustum 4,5: " + ((Queen)so.Mesh).radiusFrustum2);
                result.Add("Radius Frustum 1,2: " + ((Queen)so.Mesh).radiusFrustum1);
                result.Add("Height Frustum 3: " + ((Queen)so.Mesh).heightFrustum3);
                result.Add("Radius HalfSphere: " + ((Queen)so.Mesh).radiusHalfSphere);
                result.Add("Height Frustum: " + ((Queen)so.Mesh).heightFrustum);
                result.Add("Height Cylinder: " + ((Queen)so.Mesh).heightCylinder);
                result.Add("HeightBox: " + ((Queen)so.Mesh).heightBox);
                result.Add("Edge distance: " + ((Queen)so.Mesh).controle);
            }

            File.WriteAllLines(fileName, result.ToArray());
        }
    }
}
