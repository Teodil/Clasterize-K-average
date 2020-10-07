using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Analizator analizator = new Analizator();
        Graphics g;
        ClasterPoint[] points;
        Claster[] clasters;

        Label[] ClasterLabelData;

        TextBox[] PointDataX;
        TextBox[] PointDataY;
        Label[] PointLabelData;
        Button[] AddCenterMassBTN;
        bool IsAnalize =false;

        Point StartClasterLabelPosition;
        Point StartClasterCoardPosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartClasterLabelPosition = StartClasterLabel.Location;
            StartClasterCoardPosition = StartClasterCoard.Location;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void AddMassCenterClick(object sender, EventArgs e)
        {
            try
            {
                Match match = Regex.Match((sender as Button).Text, @"Сделать (.*?) точку");
                int index = Convert.ToInt32(match.Groups[1].Value)-1;
                bool IsAdded = false;
                bool IsSame = false;
                Random random = new Random();
                for(int i =0;i<clasters.Length;i++)
                {
                    if(clasters[i] == null)
                    {
                        clasters[i] = new Claster(new ClasterPoint(points[index]),Color.FromArgb(random.Next(0,255), random.Next(0, 255), random.Next(0, 255)));
                        for(int j = 0; j < clasters.Length; j++)
                        {
                            if (clasters[j] != null && j != i)
                            {
                                ClasterPoint CheckPoint = clasters[i].MassPoint;
                                if(CheckPoint.x == clasters[j].MassPoint.x && CheckPoint.y == clasters[j].MassPoint.y)
                                {
                                    IsSame = true;
                                    break;
                                }
                            }
                        }
                        if (!IsSame)
                        {
                            ClasterLabelData[i] = new Label();
                            ClasterLabelData[i].Text = $"Кластер {i + 1}";
                            ClasterLabelData[i].ForeColor = clasters[i].ClasterColor;
                            ClasterLabelData[i].Location = StartClasterLabel.Location;

                            clasters[i].TextBoxX = new TextBox();
                            clasters[i].TextBoxX.Text = clasters[i].MassPoint.x.ToString();
                            clasters[i].TextBoxX.Width = StartClasterCoard.Width;
                            clasters[i].TextBoxX.Height = StartClasterCoard.Width;
                            clasters[i].TextBoxX.ForeColor = clasters[i].ClasterColor;
                            clasters[i].TextBoxX.Location = new System.Drawing.Point(StartClasterCoard.Location.X, StartClasterCoard.Location.Y);

                            clasters[i].TextBoxY = new TextBox();
                            clasters[i].TextBoxY.Text = clasters[i].MassPoint.y.ToString();
                            clasters[i].TextBoxY.Width = StartClasterCoard.Width;
                            clasters[i].TextBoxY.Height = StartClasterCoard.Width;
                            clasters[i].TextBoxY.ForeColor = clasters[i].ClasterColor;
                            clasters[i].TextBoxY.Location = new System.Drawing.Point(clasters[i].TextBoxX.Location.X + clasters[i].TextBoxX.Width + 3, clasters[i].TextBoxX.Location.Y);

                            StartClasterCoard.Location = new Point(StartClasterCoard.Location.X, StartClasterCoard.Location.Y + StartClasterCoard.Height + 20);
                            StartClasterLabel.Location = new Point(StartClasterLabel.Location.X, StartClasterLabel.Location.Y + StartClasterCoard.Height + 20);

                            Controls.Add(clasters[i].TextBoxX);
                            Controls.Add(clasters[i].TextBoxY);
                            Controls.Add(ClasterLabelData[i]);

                            IsAdded = true;
                            Refresh();
                            break;
                        }
                        else
                        {
                            clasters[i] = null;
                            MessageBox.Show("Данная точка уже выбрана центром масс", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
                if (!IsAdded && !IsSame)
                {
                    MessageBox.Show("Все центры масс выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (points == null || clasters == null)
            {
                try
                {

                    points = new ClasterPoint[Convert.ToInt32(PointAmount.Text)];
                    clasters = new Claster[Convert.ToInt32(ClasterAmount.Text)];
                    PointDataX = new TextBox[points.Length];
                    PointDataY = new TextBox[points.Length];
                    PointLabelData = new Label[points.Length];
                    AddCenterMassBTN = new Button[points.Length];

                    ClasterLabelData = new Label[clasters.Length];

                    int Width = 100;
                    int Height = 50;
                    int LastPosX = StartPoint.Location.X;
                    int LastPosY = StartPoint.Location.Y;

                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new ClasterPoint((float)random.NextDouble(), (float)random.NextDouble(), clasters.Length);
                        PointLabelData[i] = new Label();
                        PointLabelData[i].Text = (i + 1).ToString();
                        PointLabelData[i].Width = 20;
                        PointLabelData[i].Height = 20;
                        PointLabelData[i].Location = new System.Drawing.Point(LastPosX, LastPosY);

                        PointDataX[i] = new TextBox();
                        PointDataX[i].Text = points[i].x.ToString();
                        PointDataX[i].Width = Width;
                        PointDataX[i].Height = Height;
                        PointDataX[i].Location = new System.Drawing.Point(PointLabelData[i].Location.X + 25 + 1, LastPosY);

                        PointDataY[i] = new TextBox();
                        PointDataY[i].Text = points[i].y.ToString();
                        PointDataY[i].Width = Width;
                        PointDataY[i].Height = Height;
                        PointDataY[i].Location = new System.Drawing.Point(PointDataX[i].Location.X + Width + 1, LastPosY);

                        AddCenterMassBTN[i] = new Button();
                        AddCenterMassBTN[i].Text = $"Сделать {i + 1} точку центром масс кластера";
                        AddCenterMassBTN[i].Width = Width + 100;
                        AddCenterMassBTN[i].Height = Height / 2;
                        AddCenterMassBTN[i].Click += AddMassCenterClick;
                        AddCenterMassBTN[i].Location = new System.Drawing.Point(PointDataY[i].Location.X + Width + 1, LastPosY);


                        LastPosY += (25 + 1);

                        Controls.Add(PointLabelData[i]);
                        Controls.Add(PointDataX[i]);
                        Controls.Add(PointDataY[i]);
                        Controls.Add(AddCenterMassBTN[i]);
                        Application.DoEvents();
                        Refresh();
                        Thread.Sleep(1);
                    }
                    MessageBox.Show("Генерация выполнена", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Очистите выборку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //pictureBox1.Image.Dispose();
            try
            {
                if (!IsAnalize)
                {
                    foreach (ClasterPoint point in points)
                    {
                        g.DrawRectangle(new Pen(Color.Red), point.x * pictureBox1.Width, point.y * pictureBox1.Height, 10f, 10);
                    }
                    foreach(Claster claster in clasters)
                    {
                        if (claster != null)
                        {
                            g.DrawEllipse(new Pen(claster.ClasterColor), claster.MassPoint.x * pictureBox1.Width, claster.MassPoint.y * pictureBox1.Height, 15, 15);

                        }
                    }
                }
                else
                {
                    foreach(Claster claster in clasters)
                    {
                        g.DrawEllipse(new Pen(claster.ClasterColor), claster.MassPoint.x * pictureBox1.Width, claster.MassPoint.y * pictureBox1.Height, 15, 15);
                        for(int i = 0; i < claster.Points.Count; i++)
                        {
                            g.DrawRectangle(new Pen(claster.ClasterColor), claster.Points[i].x * pictureBox1.Width, claster.Points[i].y * pictureBox1.Height, 10f, 10f);
                        }
                    }
                }
            }
            catch
            {
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IsAnalize = true;
                analizator.Clastarize(clasters, points, this);
                pictureBox1.Refresh();
                IsAnalize = false;
                MessageBox.Show("Кластаризация завершена Do u like what u see??", "Выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                IsAnalize = false;
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBTN_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < points.Length; i++)
            {
                Controls.Remove(PointDataX[i]);
                Controls.Remove(PointDataY[i]);
                Controls.Remove(PointLabelData[i]);
                Controls.Remove(AddCenterMassBTN[i]);
            }
            for (int i = 0; i < clasters.Length; i++)
            {
                if (clasters[i] != null)
                {
                    Controls.Remove(clasters[i].TextBoxX);
                    Controls.Remove(clasters[i].TextBoxY);
                    Controls.Remove(ClasterLabelData[i]);
                }
            }
            points = null;
            clasters = null;
            PointDataX = null;
            PointDataY = null;
            PointLabelData = null;
            ClasterLabelData = null;
            StartClasterCoard.Location = StartClasterCoardPosition;
            StartClasterLabel.Location = StartClasterLabelPosition;
            Refresh();

        }
    }
}
