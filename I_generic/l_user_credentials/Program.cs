namespace l_user_credentials;

class Program
{
    static void Main(string[] args)
    {
        bool isFound = false;
        List<Tuple<string,string>>Credentials = new List<Tuple<string, string>>
        {
            new Tuple<String, string>("ram", "ram@123"),
            new Tuple<String, string>("sita", "sita@123"),
            new Tuple<String, string>("hari", "hari@123"),
       
        };
        Console.WriteLine("Enter name:");
        string  u = Console.ReadLine();
        Console.WriteLine("Enter password:");
        string  p = Console.ReadLine();

        foreach(Tuple<string, string> c in Credentials)
        {
            if(c.Item1 ==u && c.Item2 == p)
            {
                isFound =true;
                break;
            }
        }
        if (isFound)
        {
            Console.WriteLine("welcome {0}",u); 
        }
        else
        {
            Console.WriteLine("Invalid username and password");
        }

    }
}
