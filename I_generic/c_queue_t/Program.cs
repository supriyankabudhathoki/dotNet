namespace c_queue_t;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(23);
        nums.Enqueue(45);
        nums.Enqueue(145);
        nums.Enqueue(765);
        nums.Enqueue(345);
        nums.Enqueue(876);
        foreach(var item in nums)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(nums.Contains(345));
        Console.WriteLine(nums.Contains(67));
        
    }
}
