using System;
using System.Collections.Generic;
using System.Text;

namespace task3_ооад_lab1
{
    internal class Rectangle
    {
        readonly int a, b;
        public Rectangle (int a, int b)
        {
            this.a = a; this.b = b;

        }
        public int Square => a * b;
    }
}
