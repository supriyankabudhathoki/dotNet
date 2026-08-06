namespace a_collection_demo;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        nums.Add(34);
        nums.Add(334);
        nums.Add(345);
       
        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);
    }
}
