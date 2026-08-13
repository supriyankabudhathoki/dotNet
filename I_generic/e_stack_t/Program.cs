namespace e_stack_t;

class Program
{
    static void Main(string[] args)
    {
        
       /*  myNums.Push(45);
        myNums.Push(8);
        myNums.Push(435);
        myNums.Push(455);
        myNums.Push(454); */

    int[] myArray = new int[] {23,44,55,65,34,23};
       Stack<int> myNums = new Stack<int>(myArray);
        foreach(var item in myNums)
        {
             Console.WriteLine(item);
             myNums.Pop();
             if(myNums.Count > 0)
            {
                foreach(var item in myNums)
                {
                   Console.WriteLine(item);
                }
                else
                {
                     Console.WriteLine("There is nothing in the stack");
                }
            }
        }
    }
}
