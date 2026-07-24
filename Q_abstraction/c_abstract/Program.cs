namespace a_abstract;


abstract class calculation
{
    public abstract void calc(int a);
}

class squareRoot : calculation
{
    public override void calc(int a)
    {
        Console.WriteLine("Cube ="+ Math.Sqrt(a));
    }
}
class cube : calculation
{
    public override void calc(int a)
    {
       Console.WriteLine ("CUBE ="+ (a * a * a)) ;
    }
}
class Program
{
    static void Main(string[] args)
    {
       squareRoot obj1 = new squareRoot();
       cube obj2= new cube();

       obj1.calc(9) ;
       obj2.calc(9) ;
    }
}
