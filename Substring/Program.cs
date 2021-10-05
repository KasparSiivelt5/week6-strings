using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string 
                HelloWorld = "Hello World!";
            string partToLookFor = "hello";


            bool isThere;

            isThere = helloWorld.ToLower().Contains(partToLookFor);
            
            if(isThere)
            {
                Console.WriteLine($"leidsin {PartToLookFor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leidnud {PartToLookFor} üles!");
            }
        
        }

    }
}
