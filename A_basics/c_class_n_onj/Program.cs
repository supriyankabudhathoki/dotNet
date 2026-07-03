using System.Formats.Asn1;

namespace c_class_n_onj;
class Student
{
    public int roll;
    public void displayRoll(int r)
    {
        Console.WriteLine("Roll Number =" + roll);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.roll= 444;
        s1.displayRoll(s1.roll);
    }
}
