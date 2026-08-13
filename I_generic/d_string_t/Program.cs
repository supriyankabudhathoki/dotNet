namespace d_string_t;

class Program
{
    static void Main(string[] args)
    {
        Queue <string> names = new Queue<string>();
        names.Enqueue("Ram");
        names.Enqueue("sita");
        names.Enqueue("gita");
        names.Enqueue("hari");
        names.Enqueue("rabi");
        Console.WriteLine("The number of element in the queue is = "+ names.Count);
        Console.WriteLine("The first number of element in the queue is = "+ names.Peek());
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

    }
}
