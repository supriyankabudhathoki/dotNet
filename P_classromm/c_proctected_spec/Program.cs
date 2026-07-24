using System;

namespace c_proctected_spec
{
    class shape
    {
        // Protected fields are accessible by derived classes
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

    // Fixed: Class name is Rectangular
    class Rectangular : shape
    {
        // Fixed: Constructor name must match class name. 
        // Fixed: Correct base constructor syntax using ':' outside the parameter list.
        public Rectangular(int a = 0, int b = 0) : base(a, b) { }

        // Fixed: Removed duplicate code block and cleaned up the method body syntax
        public override int area()
        {
            Console.WriteLine("Rectangular Area Calculation");
            return width * height;
        }
    }

    class Program
    {
        // Fixed: Moved Main method into its own runner class for clean organization
        static void Main(string[] args)
        {
            Rectangular rect = new Rectangular(5, 4);
            Console.WriteLine("Area: " + rect.area());
        }
    }
}
