using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kõsib kasutajal sisestada eesnimi ja perekonnanimi
            //programm kuvab, mitu "a" tähte kasutaja eesnimes ja perekonnanimes kokku on

            //char a = 'a'

            Console.WriteLine("Sisesta oma eesnimi");
            string userFirstName = Console.ReadLine();
            
            Console.WriteLine("Sisesta oma perekonnanimi");
            string userLastName = Console.ReadLine();

            

            string fullName = $"{userFirstName}{userLastName}".ToLower();
            
            int counter = 0;
            
            foreach (char character in fullName)
            {
              if(character == 'a')
                {
                    counter++; //counter = counter + 1
                }
                    
                {

                    Console.WriteLine($"Sinu nimes on {counter} a-tähte");
              }
          }
      

          


















