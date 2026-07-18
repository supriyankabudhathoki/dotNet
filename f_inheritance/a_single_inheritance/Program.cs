namespace a_single_inheritance;

class SuperClass
{
    public void hi()
    {
        Console.WriteLine("Hi friends ! I.m from Super Class.");
    }
}

class Subclass: SuperClass
{
    public void hello()
    {
        Console.WriteLine("Hello friends ! I.m  from Sub class.");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Subclass obj = new Subclass();
        obj.hello();
        Console.WriteLine("ok done");
    }
}


