namespace classandobject;

class Student
{
    int roll;
    string? name;


    public void input()
    {
    Console.WriteLine("Enter roll number");
    roll = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your name"); 
    name = Console.ReadLine();
    }

    public void output()
    {
        Console.WriteLine("Roll number =" + roll);
        Console.WriteLine("Name =" + name);
    }
 static void Main(string[] args)
 {
   Student s1 = new Student();
   s1.input();
   s1.output();
 }




/* public void display()
{
    Console.WriteLine("Hello Supriyanka");
}
static void Main(string[] args)
{
    Student s1 = new Student();
    s1.display();
} */
}

