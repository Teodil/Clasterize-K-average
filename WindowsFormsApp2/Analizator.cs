using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Analizator
    {
        public void Clastarize(Claster[] clasters,ClasterPoint[] points, Form form)
        {
            bool CanChange = true;
            do
            {
                foreach (ClasterPoint point in points)
                {
                    int i = 0;
                    foreach (Claster claster in clasters)
                    {
                        point.Distens[i] = (float)Math.Sqrt(Math.Pow(point.x - claster.MassPoint.x, 2) + Math.Pow(point.y - claster.MassPoint.y, 2));
                        i++;
                    }
                }
                foreach (Claster claster in clasters)
                {
                    claster.Points.Clear();
                }
                foreach (ClasterPoint point in points)
                {
                    int index = Array.IndexOf(point.Distens, point.Distens.Min());
                    clasters[index].PushPoint(point);
                }
                foreach (Claster claster in clasters)
                {
                    claster.SetNewMassPoint();
                }
                foreach(Claster claster in clasters)
                {
                    if (claster.IsChanged)
                    {
                        CanChange = true;
                        break;
                    }
                    else
                    {
                        CanChange = false;
                    }
                }
                form.Refresh();
                Thread.Sleep(1000);
            }
            while (CanChange);
        }
    }
}
