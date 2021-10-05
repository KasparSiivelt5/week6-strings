using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõne pikkust length omaduse kasutamata

            //foreach loop
            //foreach(element in string)

            int counter = 0;
            foreach (char character in helloworld)
            
            {
                counter = counter + 1;
                      //counter++;
            }
            Console.WriteLine($"(helloworld) on {counter } sümbolilt pikk." 
        }
    }
}
