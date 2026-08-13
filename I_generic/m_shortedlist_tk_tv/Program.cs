namespace m_shortedlist_tk_tv;

class Program
{
    static void Main(string[] args)
    {
         SortedList<int,string>rollnames = new SortedList<int, string>();
        {
           rollnames.Add(1,"ram");
           rollnames.Add(5,"sita");
           rollnames.Add(13,"hari");
           rollnames.Add(11,"gita");


           rollnames.Add(7,"supriyanka");
           rollnames.Add(99,"rita");
           rollnames.Add(78,"laxmi");

           Console.WriteLine(rollnames[3]);
       
       foreach(var item in rollnames)
            {
                 Console.WriteLine("Key is {0} and value is {1}", item.Key, item.Value);
            }
        };

    }
}
