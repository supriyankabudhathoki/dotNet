namespace b_numbercalc;

class Program
{
    delegate int numbercalc(int a);
    public static int num=10;
    public static int addnum(int a){
        num+=a;
        return num;
    }
    public static int mulnum(int a){
        num*=a;
        return num;
    }
public static int getnum()
    {
        return num;
    }



    static void Main(string[] args)
    {
        numbercalc del =new numbercalc(addnum);
        del(5);
        Console.WriteLine("New value is= {0}", getnum());
        numbercalc del1 =new numbercalc(mulnum);
        del1(5);
        Console.WriteLine("New value is= {0}", getnum());
    }
}

