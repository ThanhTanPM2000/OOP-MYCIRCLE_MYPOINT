using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCircle_MyPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCircle alo = new MyCircle(2, 3, 12);
            Console.WriteLine(alo.ToString());
            Console.ReadLine();
        }
    }
}
