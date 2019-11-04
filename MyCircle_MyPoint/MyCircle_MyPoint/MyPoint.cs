using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCircle_MyPoint
{
    class MyPoint
    {
        private int X = 0;
        private int Y = 0;

        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int GetX()
        {
            return X;
        }
        public void SetX(int x)
        {
            this.X = x;
        }
        public int GetY()
        {
            return Y;
        }
        public void SetY(int y)
        {
            this.Y = y;
        }
        public int[] GetXY()
        {
            int[] xy = new int[2];
            xy[0] = this.X;
            xy[1] = this.Y;
            return xy;

            //return new int[] { this.X, this.Y };
        }
        public void SetXY(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", this.X, this.Y);
        }

        public double Distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public double Distance(MyPoint point)
        {
            return Distance(point.GetX(), point.GetY());
        }
        public double Distance()
        {
            return Distance(0, 0);
        }
    }
}
