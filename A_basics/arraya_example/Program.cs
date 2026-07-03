namespace arraya_example;

class Program
{
    static void Main(string[] args)
    {
        int [] myArray = {102, 45,65,77,65,43};
        Console.WriteLine("Hello, World!");
        foreach(var item in myArray)
        {
            Console.WriteLine(item);
        }
        Array.Sort(myArray);
        Array.Reverse(myArray);
        Console.WriteLine("array after sorting");
         foreach(var item in myArray)
        {
            Console.WriteLine(item);
        }
    }
}
