namespace c_simpleInterest_using_entervalue;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter a principle amount: ");
        int p= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the time of interest: ");
         int t= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the rate of interest: ");
         int r= Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("the sum of two user input number is: "+ ((p*t*r)/100));
    }
}
