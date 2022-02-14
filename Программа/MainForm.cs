using AMath;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Visualizer
{
    public partial class MainForm : Form
    {
        public Scene MainScene = new Scene();
        bool transfer = false;
        bool scene = true;
        bool rotate = false;
        public MainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            MouseWheel += MainForm_MouseWheel;
            MainScene = new Scene();
            MainScene.OnSceneChangedEvent += DrawContainerUpdate;
            MainScene.OnObjectListChanged += ChangeObjectList;
            KeyPreview = true;
            groupBox2.Visible = false;
            left.Visible = false;
            up.Visible = false;
            down.Visible = false;
            right.Visible = false;
            downright.Visible = false;
            downleft.Visible = false;
            upleft.Visible = false;
            upright.Visible = false;
            label18.Visible = false;
        }

        private void ChangeObjectList()
        {
            int oldIndex = ObjectList.SelectedIndex;
            ObjectList.Items.Clear();
            ObjectList.Items.AddRange(MainScene.ObjectList.ToArray());
        }
        double wheel = 0;
        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                MainScene.MainCamera.GoCloser(0.1);
                wheel+=0.1;
            }
            else
            {
                MainScene.MainCamera.GoFarther(0.1);
                wheel -= 0.1;
            }
        }

        private void DrawContainerUpdate()
        {
            drawContainer1.DrawScene = MainScene;
            drawContainer1.Invalidate();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            MainScene.ObjectList[1].Rotation.X += 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainScene.ObjectList[1].Rotation.Y += 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainScene.ObjectList[1].Rotation.Y -= 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainScene.ObjectList[1].Rotation.X -= 5;
        }
        //
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad5:
                    MainScene.IsPerspective = !MainScene.IsPerspective;
                    break;
                case Keys.P:
                    MainScene.IsPerspective = !MainScene.IsPerspective;
                    break;
                case Keys.Z:
                    MainScene.IsZBuffer = !MainScene.IsZBuffer;
                    break;
                case Keys.Add:
                    MainScene.MainCamera.GoCloser(0.1);
                    break;
                case Keys.Subtract:
                    MainScene.MainCamera.GoFarther(0.1);
                    break;
            }
        }

        private void AddObject_Click(object sender, EventArgs e)
        {
            AddNewObject();
        }

        private void RemoteControlReady(int buttonCount,
            double length,
            double width,
            double height,
            int stereoCount,
            double boxButtonWidth,
            double boxButtonHeight,
            double centralButtonRadius,
            double centralButtonHeight,
            double smallButtonRadius,
            double smallButtonHeight,
            double lampRadius,
            double buttonControle,
            string name)
        {
            MainScene.AddObject(new SceneObject(new Queen(buttonCount,
                length, width, height, stereoCount, boxButtonWidth, boxButtonHeight, centralButtonRadius, centralButtonHeight,
                smallButtonRadius, smallButtonHeight, lampRadius, buttonControle), name));
        }

        private void AddNewObject()
        {
            if(ObjectList.SelectedItem != null)
            {
                QueenParam RemoteControlParamsForm = new QueenParam(SceneObject.counter, ((Queen)((SceneObject)ObjectList.SelectedItem).Mesh));
                RemoteControlParamsForm.OnStereoReady += RemoteControlReady;
                RemoteControlParamsForm.ShowDialog();
                RemoteControlParamsForm.Dispose();
            }
            else
            {
                QueenParam RemoteControlParamsForm = new QueenParam(SceneObject.counter);
                RemoteControlParamsForm.OnStereoReady += RemoteControlReady;
                RemoteControlParamsForm.ShowDialog();
                RemoteControlParamsForm.Dispose();
            }
        }

        private void RemoteControlChange(int buttonCount,
            double length,
            double width,
            double height,
            int stereoCount,
            double boxButtonWidth,
            double boxButtonHeight,
            double centralButtonRadius,
            double centralButtonHeight,
            double smallButtonRadius,
            double smallButtonHeight,
            double lampRadius,
            double buttonControle,
            string name)
        {
            Vector3 transfer = ((SceneObject)ObjectList.SelectedItem).Transfer;
            Vector3 rotation = ((SceneObject)ObjectList.SelectedItem).Rotation;
            Vector3 scale = ((SceneObject)ObjectList.SelectedItem).Scale;
            MainScene.ObjectList.Remove(((SceneObject)ObjectList.SelectedItem));
            MainScene.AddObject(new SceneObject(new Queen(buttonCount, length,
                width, height, stereoCount, boxButtonWidth, boxButtonHeight,
                centralButtonRadius, centralButtonHeight, smallButtonRadius,
                smallButtonHeight, lampRadius, buttonControle), 
                transfer, rotation, scale, name));
        }

        private void ChangeObject()
        {
            if (ObjectList.SelectedItem != null)
            {
                QueenParam RemoteControlParamsForm = new QueenParam(((Queen)((SceneObject)ObjectList.SelectedItem).Mesh), ObjectList.SelectedItem.ToString());
                RemoteControlParamsForm.OnStereoReady += RemoteControlChange;
                RemoteControlParamsForm.ShowDialog();
                RemoteControlParamsForm.Dispose();
            }
        }

        private void ChangeObjectProperty_Click(object sender, EventArgs e)
        {
            ChangeObject();
        }

        private void DeleteObject_Click(object sender, EventArgs e)
        {
            if(ObjectList.SelectedItem != null)
            {
                MainScene.ObjectList.Remove((SceneObject)ObjectList.SelectedItem);
            }
        }

        private void ChangeProjection_Click(object sender, EventArgs e)
        {
            MainScene.IsPerspective = !MainScene.IsPerspective;
        }

        private void Near_ValueChanged(object sender, EventArgs e)
        {
            //MainScene.Near = (double)Near.Value;
        }

        private void Far_ValueChanged(object sender, EventArgs e)
        {
            //MainScene.Far = (double)Far.Value;
        }

        private void TransferZ_ValueChanged(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                if (transfer)
                {
                    ((SceneObject)ObjectList.SelectedItem).Transfer.Z = (double)TransferZ.Value;
                }
                else if (rotate)
                {
                    ((SceneObject)ObjectList.SelectedItem).Rotation.Z = (double)TransferZ.Value;
                }
            }
        }

        private void ScaleX_ValueChanged(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                ((SceneObject)ObjectList.SelectedItem).Scale.X = (double)ScaleX.Value;
            }
        }

        private void ScaleY_ValueChanged(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                ((SceneObject)ObjectList.SelectedItem).Scale.Y = (double)ScaleY.Value;
            }
        }

        private void ScaleZ_ValueChanged(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                ((SceneObject)ObjectList.SelectedItem).Scale.Z = (double)ScaleZ.Value;
            }
        }

        private void CameraX_ValueChanged(object sender, EventArgs e)
        {
            MainScene.MainCamera.ObserverPoint.X = (double)CameraX.Value;
            MainScene.IsPerspective = true;
        }

        private void CameraY_ValueChanged(object sender, EventArgs e)
        {
            MainScene.MainCamera.ObserverPoint.Y = (double)CameraY.Value;
            MainScene.IsPerspective = true;

        }

        private void CameraZ_ValueChanged(object sender, EventArgs e)
        {
            MainScene.MainCamera.ObserverPoint.Z = (double)CameraZ.Value;
            MainScene.IsPerspective = true;

        }

        private void EyeX_ValueChanged(object sender, EventArgs e)
        {
            MainScene.MainCamera.Position.X = (double)EyeX.Value;
            MainScene.IsPerspective = true;
        }

        private void EyeY_ValueChanged(object sender, EventArgs e)
        {
            MainScene.MainCamera.Position.Y = (double)EyeY.Value;
            MainScene.IsPerspective = true;
        }

        private void EyeZ_ValueChanged(object sender, EventArgs e)
        {
            MainScene.MainCamera.Position.Z = (double)EyeZ.Value;
            MainScene.IsPerspective = true;
        }

        private void ObjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ObjectList.SelectedItem != null)
            {
                TransferX.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Transfer.X;
                TransferY.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Transfer.Y;
                TransferZ.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Transfer.Z;
               // RotateX.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Rotation.X;
                //RotateY.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Rotation.Y;
                //RotateZ.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Rotation.Z;
                ScaleX.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Scale.X;
                ScaleY.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Scale.Y;
                ScaleZ.Value = (decimal)((SceneObject)ObjectList.SelectedItem).Scale.Z;
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewObject();
        }

        private void изменитьПараметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeObject();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                MainScene.ObjectList.Remove((SceneObject)ObjectList.SelectedItem);
            }
        }

        private void сохранитьСценуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".q";

            if (ObjectList.SelectedItem != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MainScene.SaveToFile(saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Выберите объект из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void открытьСценуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Scene files (*.q)|*.q";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MainScene = new Scene(openFileDialog1.FileName);
                MainScene.OnSceneChangedEvent += DrawContainerUpdate;
                MainScene.OnObjectListChanged += ChangeObjectList;
                ChangeObjectList();
                DrawContainerUpdate();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawContainer1_MouseUp(object sender, MouseEventArgs e)
        {
            if (scene)
            {
                double x = Convert.ToDouble(360 * e.X / drawContainer1.Width - 180);
                double y = Convert.ToDouble(360 * e.Y / drawContainer1.Height - 180);
                int x1 = Convert.ToInt32(Math.Round(x, 0));
                int y1 = Convert.ToInt32(Math.Round(y, 0));
                MainScene.MainCamera.Rotate(AMathHelper.ToRadians(x1), AMathHelper.ToRadians(y1));
            }
            else if (rotate)
            {
                double x = Convert.ToDouble(360 * e.X / drawContainer1.Width - 180);
                double y = Convert.ToDouble(360 * e.Y / drawContainer1.Height - 180);
                int x1 = Convert.ToInt32(Math.Round(x, 0));
                int y1 = Convert.ToInt32(Math.Round(y, 0));
                ((SceneObject)ObjectList.SelectedItem).Rotation.X = x1;
                ((SceneObject)ObjectList.SelectedItem).Rotation.Y = y1;
            }
            else if (transfer)
            {
                if (ObjectList.SelectedItem != null)
                {
                    double x = -(e.X - drawContainer1.Width / 2) / (drawContainer1.Width / 15);
                    double y = -(e.Y - drawContainer1.Height / 2) / (drawContainer1.Height / 5);
                    ((SceneObject)ObjectList.SelectedItem).Transfer.X = x;
                    ((SceneObject)ObjectList.SelectedItem).Transfer.Y = y;

                }
            }
        }

        private void каркаснаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScene.IsFilled = false;
            MainScene.IsWireframe = true;
        }

        private void твердотельнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScene.IsFilled = true;
            MainScene.IsWireframe = false;
        }

        private void параллельноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScene.IsPerspective = true;
        }

        private void центральноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScene.IsPerspective = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AddNewObject();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                MainScene.ObjectList.Remove((SceneObject)ObjectList.SelectedItem);
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                transfer = true;
                scene = false;
                groupBox2.Visible = true;
                groupBox2.Text = "Перенос";
                left.Visible = true;
                up.Visible = true;
                down.Visible = true;
                right.Visible = true;
                downright.Visible = false;
                downleft.Visible = false;
                upleft.Visible = false;
                upright.Visible = false;
                label18.Visible = true;
                TransferX.Value = Convert.ToInt32(((SceneObject)ObjectList.SelectedItem).Transfer.X);
                TransferY.Value = Convert.ToInt32(((SceneObject)ObjectList.SelectedItem).Transfer.Y);
                TransferZ.Value = Convert.ToInt32(((SceneObject)ObjectList.SelectedItem).Transfer.Z);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeObject();
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (ObjectList.SelectedItem != null)
            {
                rotate = true;
                scene = false;
                transfer = false;
                groupBox2.Text = "Поворот";
                groupBox2.Visible = true;
                left.Visible = true;
                up.Visible = true;
                down.Visible = true;
                right.Visible = true;
                downright.Visible = true;
                downleft.Visible = true;
                upleft.Visible = true;
                upright.Visible = true;
                label18.Visible = true;
                TransferX.Value = Convert.ToInt32(((SceneObject)ObjectList.SelectedItem).Rotation.X);
                TransferY.Value = Convert.ToInt32(((SceneObject)ObjectList.SelectedItem).Rotation.Y);
                TransferZ.Value = Convert.ToInt32(((SceneObject)ObjectList.SelectedItem).Rotation.Z);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            scene = true;
            left.Visible = false;
            up.Visible = false;
            down.Visible = false;
            right.Visible = false;
            downright.Visible = false;
            downleft.Visible = false;
            upleft.Visible = false;
            upright.Visible = false;
            label18.Visible = false;
            groupBox2.Visible = false;
        }

        private void TransferX_ValueChanged(object sender, EventArgs e)
        {
            if (transfer)
            {
                ((SceneObject)ObjectList.SelectedItem).Transfer.X = (double)TransferX.Value;
            }
            else if (rotate)
            {
                ((SceneObject)ObjectList.SelectedItem).Rotation.X = (double)TransferX.Value;
            }
        }

        private void TransferY_ValueChanged(object sender, EventArgs e)
        {
            if (transfer)
            {
                ((SceneObject)ObjectList.SelectedItem).Transfer.Y = (double)TransferY.Value;
            }
            else if (rotate)
            {
                ((SceneObject)ObjectList.SelectedItem).Rotation.Y = (double)TransferY.Value;
            }
        }

        private void up_Click(object sender, EventArgs e)
        {
            if (transfer)
            {
                ((SceneObject)ObjectList.SelectedItem).Transfer.Y +=0.3;
                TransferY.Value = TransferX.Value-3 / 10;
            }
            else if (rotate)
            {
                ((SceneObject)ObjectList.SelectedItem).Rotation.Y += 1;
                TransferY.Value += Convert.ToInt32(1);
            }
            else
            {

            }
        }

        private void down_Click(object sender, EventArgs e)
        {
            if (transfer)
            {
                ((SceneObject)ObjectList.SelectedItem).Transfer.Y -= 0.3;
                TransferY.Value = TransferX.Value-3 / 10;
            }
            else if (rotate)
            {
                ((SceneObject)ObjectList.SelectedItem).Rotation.Y -=1;
                TransferY.Value -= Convert.ToInt32(1);
            }
            else
            {

            }
        }

        private void upleft_Click(object sender, EventArgs e)
        {
            ((SceneObject)ObjectList.SelectedItem).Rotation.X +=1 ;
            ((SceneObject)ObjectList.SelectedItem).Rotation.Y += 1;
            TransferX.Value += Convert.ToInt32(1);
            TransferY.Value += Convert.ToInt32(1);
        }

        private void upright_Click(object sender, EventArgs e)
        {
            ((SceneObject)ObjectList.SelectedItem).Rotation.X -= 1;
            ((SceneObject)ObjectList.SelectedItem).Rotation.Y += 1;
            TransferX.Value -= Convert.ToInt32(1);
            TransferY.Value += Convert.ToInt32(1);
        }

        private void downleft_Click(object sender, EventArgs e)
        {
            ((SceneObject)ObjectList.SelectedItem).Rotation.X += 1;
            ((SceneObject)ObjectList.SelectedItem).Rotation.Y -= 1;
            TransferX.Value += Convert.ToInt32(1);
            TransferY.Value -= Convert.ToInt32(1);
        }

        private void downright_Click(object sender, EventArgs e)
        {
            ((SceneObject)ObjectList.SelectedItem).Rotation.X -= 1;
            ((SceneObject)ObjectList.SelectedItem).Rotation.Y -= 1;
            TransferX.Value -= Convert.ToInt32(1);
            TransferY.Value -= Convert.ToInt32(1);
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (transfer)
            {
                ((SceneObject)ObjectList.SelectedItem).Transfer.X += 0.3;
                TransferX.Value = TransferX.Value+3 / 10;
            }
            else if (rotate)
            {
                ((SceneObject)ObjectList.SelectedItem).Rotation.X +=1 ;
                TransferX.Value += Convert.ToInt32(1);
            }
            else
            {

            }
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (transfer)
            {
                ((SceneObject)ObjectList.SelectedItem).Transfer.X -= 0.3;
                TransferX.Value = TransferX.Value-3/10;
            }
            else if (rotate)
            {
                ((SceneObject)ObjectList.SelectedItem).Rotation.X -= 1;
                TransferX.Value -= Convert.ToInt32(1);
            }
            else
            {

            }
        }
    }
}
