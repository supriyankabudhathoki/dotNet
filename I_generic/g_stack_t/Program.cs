namespace g_stack_t;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[]{12,32,43,23,22,53};
        Stack<int> myNum =new Stack<int>();

        foreach (var item in myNum){
        Console.WriteLine(item);
        Console.WriteLine("The total number of elements in stack = "+ myNum.Count());
        
        while (myNum.Count > 0)
        {
            Console.WriteLine(myNum.Pop() + ".");
        }
          Console.WriteLine("The total number of elements in stack = "+ myNum.Count());
    }
}
}