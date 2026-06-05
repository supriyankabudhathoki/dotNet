namespace classandobject;

class Student
{
    int principle;
    int rate;
    int time;
    

    public void input(int p, int t, int r )
    {
        principle= p;
        rate=r;
        time=t;
    }
    public void output()
    {
        Console.WriteLine("Principle is =" + principle);
        Console.WriteLine("time is =" + time);
        Console.WriteLine("rate is =" + rate);
    }

    public void simpleInt()
    {
       double si = (principle * rate * time) / 100.0;
        Console.WriteLine("Simple Interest = " + si);  
    }
 static void Main(string[] args)
 {
   Student s1 = new Student();
   s1.input(2,3,4);
   s1.output();
   s1.simpleInt();
   
 }
}

