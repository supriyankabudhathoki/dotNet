namespace h_hashset_t;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> MyIntHash = new HashSet<int>(){12,32,34,65,34};
        Console.WriteLine("Element in hasset:");
        foreach(var item in MyIntHash)
        {
            Console.WriteLine(item);
        }
        
    }
}
