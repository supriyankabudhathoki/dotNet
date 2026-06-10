namespace d_librarybook
{
    class Student
    {
        public string name;
        public int grade;

        public void Input()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Grade: ");
            grade = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name + " | Grade: " + grade);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students do you want to enter? ");
            int count = int.Parse(Console.ReadLine());

            Student[] students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nStudent " + (i + 1) + ":");
                students[i] = new Student();
                students[i].Input();
            }

            Console.WriteLine("\nAll Students");
            for (int i = 0; i < count; i++)
            {
                students[i].Display();
            }

            Student top = students[0];
            for (int i = 1; i < count; i++)
            {
                if (students[i].grade > top.grade)
                    top = students[i];
            }

            Console.WriteLine("\nTop Student: " + top.name + " with grade " + top.grade);
        }
    }
}