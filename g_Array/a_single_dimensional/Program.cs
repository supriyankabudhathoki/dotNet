namespace a_array_nums;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray = { 12, 34, 56, 7, 89, 90 };

        foreach (var item in myArray)
        {
            Console.Write("{0}\t",item);
        }
    }
}