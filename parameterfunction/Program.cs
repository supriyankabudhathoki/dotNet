namespace classandobject;

class Student
{
    int roll;
    string? name;//? for not null value once the project is setup only use dotnet run


    public void input(int r, string n)
    {
        roll= r;
        name=n;
    }
    public void output()
    {
        Console.WriteLine("Roll number =" + roll);
        Console.WriteLine("Name =" + name);
    }
 static void Main(string[] args)
 {
   Student s1 = new Student();
   Student s2 = new Student();
   s1.input(4, "ram");
   s2.input(5, "sita");
   s1.output();
   s2.output();
 }
}

