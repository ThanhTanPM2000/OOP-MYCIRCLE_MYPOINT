using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCircle_MyPoint
{
    class MyCircle
    {
        private MyPoint center = new MyPoint(0, 0);
        private int radius = 1;
        public MyCircle()
        {

        }

        public MyCircle(int x, int y, int radius)
        {
            center = new MyPoint(x, y);
            this.radius = radius;
        }

        public MyCircle(MyPoint center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public int GetRadius()
        {
            return this.radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }

        public MyPoint GetCenter()
        {
            return center;
        }

        public void SetCenter(MyPoint center)
        {
            this.center = new MyPoint(center.GetX(), center.GetY());
        }

        public int GetCenterX()
        {
            return center.GetX();
        }

        public void SetCenterX(int x)
        {
            this.center.SetX(x);
        }

        public int GetCenterY()
        {
            return center.GetY();
        }

        public void SetCenterY(int y)
        {
            this.center.SetY(y);
        }

        public int[] GetCenterXY()
        {
            return center.GetXY();
        }

        public void SetCenterXY(int x, int y)
        {
            this.center.SetX(x);
            this.center.SetY(y);
        }

        public override string ToString()
        {
            return string.Format("MyCircle[radius = {0}, center: {1}, Are: {2}, Circumference: {3}, distance: {4}", GetRadius(), GetCenter(), GetAre(), GetCircumference(), distance(new MyCircle(10, 19, 2)));
        }

        public double GetAre()
        {
            return radius * radius * Math.PI;
        }

        public double GetCircumference()
        {
            return 2 * radius * Math.PI;
        }

        public double distance(MyCircle another)
        {
            return center.Distance(another.GetCenter());
        }

    }
}
