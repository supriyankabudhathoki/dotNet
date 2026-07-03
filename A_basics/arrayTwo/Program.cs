namespace arrayTwo;

class Program
{
    static void Main(string[] args)
    {
        int[] myarray = {34,54,77,65,34};
        Console.WriteLine("Minimum value " + myarray.Min());
        Console.WriteLine("Maxmimum value " + myarray.Max());
        Console.WriteLine("Sum value " + myarray.Sum());
        Console.WriteLine("Average value " + myarray.Average());
    }
}
