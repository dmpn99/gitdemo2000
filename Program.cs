// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    public static void Main(string[] args)
    {
            // Variabler
            int timeHours = 7;
            int timeMinutes = 25;
            int sthlmToNyHours = 14;
            int sthlmToNyMinutes = 03;
            int nyToSthlmHours = 10;
            int nyToSthlmMinutes = 10;
            int timeDifference = 6;
            
            bool isRunning = true;
            
            
            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*************************************************************************");
                Console.WriteLine();
                Console.WriteLine("\nVälkommen till flygtidsberäknaren!");
                Console.WriteLine("\nVilket flyg vill du se detaljerad information om? (svara med en siffra)");
                Console.WriteLine("1. Stockholm - New York");
                Console.WriteLine("2. New York - Stockholm");
                Console.WriteLine("3. Avsluta programmet");
                Console.Write("Skriv ditt val här: ");
                int userChoice = int.Parse(Console.ReadLine());
                
                if (userChoice == 1)
                {
                    Console.WriteLine("Du har valt Stockholm - New York");
                    isRunning = false;
                    Console.WriteLine("Avgångstid från Stockholm: 14:03");
                    Console.WriteLine("Ankomsttid till New York: " + (sthlmToNyHours + timeHours - timeDifference) + ":" + (sthlmToNyMinutes + timeMinutes));
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Du har valt New York - Stockholm");
                    isRunning = false;
                    Console.WriteLine("Avgångstid från New York: 10:10");
                    Console.WriteLine("Ankomsttid till Stockholm: " + (nyToSthlmHours + timeHours + timeDifference) + ":" + (nyToSthlmMinutes + timeMinutes));
                }
                else
                {
                    
                    Console.WriteLine("\nFelaktigt val, försök igen!");
                
                    
                }
            }
        


        
    }
}    
    
