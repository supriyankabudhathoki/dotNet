namespace b_abstract;


class Nums
{
    public virtual int calc(int a, int b)
    {
        return (a+b);
    }
}

class AbsDemo : Nums
{
     public virtual int calc(int a, int b)
    {
        return (a*b);
    }
}

class Program
{
    static void Main(string[] args)
    {
        AbsDemo obj = new AbsDemo();
        int result = obj.calc(10,20);
        Console.WriteLine("The result is = "+ result);
    }
}
