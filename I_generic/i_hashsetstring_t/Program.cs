namespace i_hashsetstring_t;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();
        names.Add("Ram");
        names.Add("sita");
        names.Add("gita");
        names.Add("tina");
        names.Add("rom");
        names.Add("gita");
        names.Add("mina");
        //remove
        names.Remove("Mina");
         Console.WriteLine("Elements in the hash set");
        foreach(var item in names)
        {
            Console.WriteLine(item);
        }
        names.Clear();

        Console.WriteLine("Elements in the hashset");
        foreach(var item in names)
        {
            Console.WriteLine(item);
        }
    }
}
