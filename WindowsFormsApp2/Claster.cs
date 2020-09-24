using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    class Claster
    {
        public bool IsChanged;
        public List<ClasterPoint> Points = new List<ClasterPoint>();
        //List<int> Distens = new List<int>();
        public ClasterPoint MassPoint;
        public Color ClasterColor;

        public TextBox TextBoxX;
        public TextBox TextBoxY;

        public void PushPoint(ClasterPoint point)
        {
            Points.Add(point);
        }
        public Claster(ClasterPoint _MassPoint, Color color)
        {
            MassPoint = _MassPoint;
            ClasterColor = color;
        }
        public void SetNewMassPoint()
        {
            IsChanged = false;
            float bufferX = (float)Math.Round(MassPoint.x,5);
            float bufferY = (float)Math.Round(MassPoint.y, 5);
            MassPoint.x = (float)Math.Round(Points.Average(f => f.x),5);
            MassPoint.y = (float)Math.Round(Points.Average(f => f.y),5);
            TextBoxX.Text = MassPoint.x.ToString();
            TextBoxY.Text = MassPoint.y.ToString();
            if (bufferX!= MassPoint.x || bufferY != MassPoint.y)
            {
                IsChanged = true;
            }
        }
    }
}
