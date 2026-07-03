namespace structure;


struct student
{
    public int roll;
    public string name;
    public int age;
    public string address;
    public string faculty;
}
class Program
{

    static void Main(string[] args)
    {
        student s1;
        s1.roll = 1;
        s1.name="supri";
        s1.age= 21;
        s1.address= "dolakha";
        s1.faculty= "ict";

        student s2;
        s2.roll = 2;
        s2.name="sima";
        s2.age= 21;
        s2.address= "dang";
        s2.faculty= "it";

        Console.WriteLine(" Roll number is: "+ s1.roll);
        Console.WriteLine(" name  is: "+ s1.name);
        Console.WriteLine(" age is: "+ s1.age);
        Console.WriteLine(" address is: "+ s1.address);
        Console.WriteLine(" faculty is: "+ s1.faculty);


        Console.WriteLine(" Roll number is: "+ s2.roll);
        Console.WriteLine(" name  is: "+ s2.name);
        Console.WriteLine(" age is: "+ s2.age);
        Console.WriteLine(" address is: "+ s2.address);
        Console.WriteLine(" faculty is: "+ s2.faculty);
    }
}
