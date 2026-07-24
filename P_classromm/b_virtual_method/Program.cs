using System;

namespace b_virtual_method
{
    class superClass
    {
        public virtual int calc(int a, int b)
        {
            return (a + b);
        }
    }

    class SubClass : superClass
    {
        public override int calc(int a, int b)
        {
            return (a + b + 5);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SubClass obj = new SubClass();
            Console.WriteLine("Redefined object is " + obj.calc(10, 5));
        }
    }
}
