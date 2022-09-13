using System;
using System.Diagnostics.Metrics;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
             /*vi kan ställa samma fråga om och om igen tills vi fått det svar vi vill ha. rätt svar
              * kan få den att söka igenom en text och leta efter ett ord, 
              * en while fungerar så länge inputet är sant (true) 
              * vad är skillnad på while och do-while, do while kör alltid en gång
              * while kör bara om vilkoret är uppfyllt
              * använder while när man inte vet hur mycket den ska loopa 
              */
            for (int counter = 0; counter < 10; counter++) //noll till nio , for satser går från start till slut                                                           
            {

            }

            int count = 0;//när vi kör mot begränsade värden
            while (count < 10)
            {
                Console.WriteLine(count++);
                count++;
            }

            string password = "password"; //vet inte hur många gånger den ska köras
            string input = "";
            bool wrongpassword = false;
            while (input != password)
            {
                Console.WriteLine("ange lösenord:");
                input = Console.ReadLine();
                if ()
                { 
                
                }
                //kolla senare om mer än tre försök gjorts
                //isf ring säpo
                //då använder man en ifsats
            }
            //do while, kör loopen en gång oavsett vilket.
            do
            {
                Console.WriteLine("ange lösenord:");
                input = Console.ReadLine();
            } while (input != password);

        }

    }
    
}