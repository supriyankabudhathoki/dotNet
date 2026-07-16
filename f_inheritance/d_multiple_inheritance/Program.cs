namespace a_interface;

interface  IDad
{
    public void hi()
    {
        Console.WriteLine("Hello from your dad.");
    }
}
interface  IMom
{
    public void Hello()
    {
        Console.WriteLine("Hello from your mother.");
    }
}

class Child : IDad, IMom {
    public void hi()
    {
        Console.WriteLine("Hi dad and mom");
    }

    public void Hello()
    {
        Console.WriteLine("Hello dad and mom");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child c1 = new Child();
        c1.hi();
        c1.Hello();
    }
}