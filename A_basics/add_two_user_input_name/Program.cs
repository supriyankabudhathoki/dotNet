namespace add_two_user_input_name;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int a= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
         int b= Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("the sum of two user input number is: "+ (a+ b));
        
    }
}
