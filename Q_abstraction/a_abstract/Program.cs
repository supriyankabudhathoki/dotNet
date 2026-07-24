namespace a_abstract;


abstract class HelloNepal
{
    public abstract void hi();
}

class Kathmandu : HelloNepal
{
    public override void hi()
    {
        Console.WriteLine("Hi Kathmandu");
    }
}
class Bhaktpur : HelloNepal
{
    public override void hi()
    {
        Console.WriteLine("Hi Bhaktpur");
    }
}
class Program
{
    static void Main(string[] args)
    {
        HelloNepal  h;
        h= new Kathmandu();
        h.hi();
        h=new Bhaktpur();
        h.hi();
    }
}
