namespace k_dictionary_tk_tk_string;

class Program
{
    static void Main(string[] args)
    {
        var subjects = new Dictionary<string, string>()
        {
            {"education", "English, population, math"},
            {"science", "Biology, physics, chemistry"},
            {"humanities", "Sociology, social, Work, Journal"},
            {"management", "Finance, Bussiness, Economics"},
        };
           
        
            
        
       
        /* foreach(KeyValuePair<string,string> kvp in subjects)
        {
             Console.WriteLine(subjects["education"]);
             Console.WriteLine(subjects["humanities"]);
        }
           */  /* if (subjects.ContainsKey("management"))
            {
                Console.WriteLine("Key is = {0} and values are {1}",kvp.Key,kvp.Value);
            } */
/* 
            for(int i= 0; i<subjects.Count; i++)
            {
                Console.WriteLine(
                "Key = {0} and Value = {1}",
                subjects.ElementsAt(i).Key,
                subjects.ElementsAt(i).Value
            );
            } */
       
       string? result;
       if(subjects.TryGetValue("education", out result))
            {
                Console.WriteLine(result);
            }
    }

}
