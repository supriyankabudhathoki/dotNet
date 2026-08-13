namespace j_dictionary_tk_tv;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();
        rollnames.Add(420, "RAM");
        rollnames.Add(421, "sita");
        rollnames.Add(555, "gita");
        foreach(KeyValuePair<int,string> kvp in rollnames)
        {
             Console.WriteLine("Key is  {0} and the value is {1}",kvp.Key,kvp.Value);
        }
       
    }
}
