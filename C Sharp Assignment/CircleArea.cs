using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment
{
    public static class CircleArea
    {
        public static int radium { get; set; }

        public static double Area(int r)
        {
            return r * r * Math.PI;
        }
    }
}