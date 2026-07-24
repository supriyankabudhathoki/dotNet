using System;
using System.Security.Cryptography; 

namespace a_exception
{
    class InvalidVoter : Exception 
    {
        // Fixed: Access modifier must be lowercase 'public', not 'Public'
        public InvalidVoter(string message) : base(message) {}
    }

    class Program 
    {
        static void ageValidator(int age) 
        {
            if (age < 18) 
            {
                // Fixed: Wrapped string in quotation marks
                throw new InvalidVoter("you are not eligible to get your voter card"); 
            }
            else 
            {
                // Fixed: Wrapped string in quotation marks
                Console.WriteLine("you are eligible for voting feel safe."); 
            }
        }

        static void Main(string[] args) 
        {
            int a = Convert.ToInt32(Console.ReadLine()); 
            
            try 
            {
                ageValidator(a);
            } 
            catch (InvalidVoter ex) 
            {
                // Fixed: Catch exception object and print its .Message property
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
