namespace a_studentclass
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, My name is {Name}, I am {Age} years old and my grade is {Grade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Supriyanka";
            s.Age = 20;
            s.Grade = "A++";
            s.Introduce();
        }
    }
}