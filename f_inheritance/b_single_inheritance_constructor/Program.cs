namespace b_single_inheritance_constructor;



class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Construtor from  parent class");
    }

public  void ParentMethod()
    {
        Console.WriteLine("Hello from Parent method.");
    }
}


class ChildClass : ParentClass
{
    public ChildClass()
    {
        Console.WriteLine("Constructor from child class");
    }

    public void ChildMethod()
    {
        Console.WriteLine("Hello from Child Method.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        ChildClass c1 = new ChildClass();
        c1.ParentMethod();
        c1.ChildMethod();
    }
}
