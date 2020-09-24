using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class ClasterPoint
    {
        public float x;
        public float y;
        public float[] Distens;
        public ClasterPoint(float x, float y, int ClustersAmount)
        {
            this.x = x;
            this.y = y;
            Distens = new float[ClustersAmount];
        }
        public ClasterPoint(ClasterPoint copyPoint)
        {
            x = copyPoint.x;
            y = copyPoint.y;
        }
    }
}
