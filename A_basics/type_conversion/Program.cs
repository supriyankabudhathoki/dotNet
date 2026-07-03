namespace type_conversion;

class Program
{
    static void Main(string[] args)
    {

/*
        byte a1= 255;//due to implicit conversion  widening it cannot take 256 ok
        byte a= 10;
       / int  p= a; 

        double b = 255.55;
        int c =(int)a;

        /* float b =a; 
        float b = (float)a;*/

        string a = "123";
        
       /*  int b= Convert.ToInt32(a); */
       //demonstrating datatype conversion using parse
        int b = int.Parse(a);
        int c = 345;
        int sum = b+c;

    Console.WriteLine("sum ="+ sum);

        /* Console.WriteLine("double value="+ a);
        Console.WriteLine("Byte value="+ b);
        Console.WriteLine("converted integer value="+ c); */

    }
}
