﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    class Test
    {
        public override string ToString()
        {
            return $"hello";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(test);
            Rectangle r1 = new Rectangle(2, 3);
            Rectangle r2 = new Rectangle(4, 5);
            r1.Printme();
            Rectangle r3 = r1 + r2;
            Rectangle r4 = r1 * r2;
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r1 == r2);
            Console.WriteLine(r1 != r2);
            Console.ReadKey();

        }
    }
    public class Rectangle
    {
        public int x { get; set; }
        public int y { get; set; }
        public string Printme()
        {
            return $"{x}:{y}";
        }
        public override string ToString()
        {
            return $"{x}:{y}";
        }
        public Rectangle(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(r1.x + r2.x, r1.y + r2.y);
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(r1.x * r2.x, r1.y * r2.y);
        }
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.x == r2.x && r1.y == r2.y;
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }
    }
}