using System.Text;

namespace a_string_builder;

class Program
{
    static void Main(string[] args)
    {
     
        StringBuilder s = new StringBuilder("Hello sanothimi");
           string str = s.ToString();
        Console.WriteLine("str");
    }
}