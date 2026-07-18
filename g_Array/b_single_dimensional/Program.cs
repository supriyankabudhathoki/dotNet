namespace b_single_dimensional;

class Program
{
   static void Main(string[] args)
    {
        char[] myarray = { 'H', 'E', 'L', 'O' };
        // string[] myarray = { "Ram", "Sita", "Hari", "Gita", "Nita" };
        foreach (var item in myarray)
        {
            // Console.Write(item);
            Console.Write("\t {0}", item);
        }
    }
}