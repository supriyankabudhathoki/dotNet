using System;
using System.Formats.Asn1;

namespace c_proctected_spec
{
    class shape
    {
        protected int width, height;
        public shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }

        public virtual int area()
        {
            return 0;
        }
    }
    class Rectangular : shape
    {
        public Rectangular(int a = 0, int b = 0) : base(a, b) { }
        public override int area()
        {
            Console.WriteLine("Rectangular Area Calculation");
            return width * height;
        }
    }
    class Triangle : shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b) { }
        public override int area()
        {
            Console.WriteLine("Rectangular Area Calculation");
            return (width * height) /2;
        }
    }

    class Caller
    {
        public void callArea(shape sh)
        {
            int ar;
            ar = sh.area();
            Console.WriteLine("area = {0}", ar);
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Caller obj= new Caller();
            Rectangular r = new Rectangular(5, 4);
            Triangle t = new Triangle(10,20);
            obj.callArea(r);
            obj.callArea(t);
        }
    }
}
