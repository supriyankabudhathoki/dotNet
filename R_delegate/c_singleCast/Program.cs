using System.Runtime.InteropServices;

namespace c_singleCast;

class Program
{

    public delegate void Delegatemethod();

    class MyClass
    {
        public static void display()
        {
            Console.WriteLine("Hello sanothimi");
        }
    
        public static void show()
        {
            Console.WriteLine("Hello Nepal");
        }
        public  void print()
        {
            Console.WriteLine("Hello morning");
        }

    }
    static void Main(string[] args)
    {
        Delegatemethod d1 = MyClass.display;
        d1();
        Delegatemethod d2 = new Delegatemethod(MyClass.show);
        d2();
        MyClass obj = new MyClass();
        Delegatemethod d3 = obj.print;
        d3.Invoke();
        Console.WriteLine("congrats girl");
    }
}
