namespace a_overriding;

class Dad{
Public void hi()
{
    Console.WriteLine("Hi child");
}
}
class Child : Dad{
 public new void hi()
    {
        Console.WriteLine("Hi child"); 
    }
}

static void Main(string[] args)
{
    Child obj = new Child();
    obj.hi
}

