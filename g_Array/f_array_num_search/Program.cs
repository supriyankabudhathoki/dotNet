namespace f_array_num_search;

class Program
{
    static void Main(string[] args)
    {
        int[] myArray={23,34,65,76,44,54,34};
        Console.WriteLine("Enter number to search it in array:");
        int num =int.Parse(Console.ReadLine());
        bool found = false;


        for(int i =0; i<myArray.Length; i++)
        {
            if(num == myArray[i])
            {
            found =true;
            break;
        }
    }
    if(found== true)
        {
            Console.WriteLine("Number found");
        }
        else
        {
            Console.WriteLine("Number not found");
        }
   }
}
