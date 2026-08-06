namespace c_collection;

class Program
{
    static void Main(string[] args)
    {
        var nums = new List <int>(){45,65,76,45,86,44,55,66,77,88};
        nums.Insert(3,455);
        nums.Remove(89);
        nums.RemoveAt(44);
        nums.Clear(); 
        
        nums.ForEach(nums=>Console.WriteLine(nums));

        for(int i=0; i<5; i++){
        Console.WriteLine(nums[i]);
        }
    }
}
