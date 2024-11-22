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
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Välkommen till flygtidsberäknaren!");
            Console.WriteLine("\nVilket flyg vill du se detaljerad information om? (svara med en siffra)");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Skriv ditt val här: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nAvgångstid från Stockholm: 14:03");
                    Console.WriteLine("Ankomsttid till New York: " + (sthlmToNyHours + timeHours - timeDifference) + ":" + (sthlmToNyMinutes + timeMinutes));
                    Console.WriteLine("\n*************************************************************************");
                    isRunning = false;
                }
                else if (userChoice == 2)
                    
                {
                    Console.Clear();
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nAvgångstid från New York: 10:10");
                    Console.WriteLine("Ankomsttid till Stockholm: " + (nyToSthlmHours + timeHours + timeDifference) + ":" + (nyToSthlmMinutes + timeMinutes));
                    Console.WriteLine("\n*************************************************************************");
                    isRunning = false;
                }
                else if (userChoice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("\nDu har valt att avsluta programmet");
                    Console.WriteLine("\n*************************************************************************");
                    isRunning = false;
                }
                else
                {
                    
                    Console.WriteLine("\nOgiltig inmatning, välj mellan alternativ 1-3!");
                }
            }
            else
            {
                
                Console.WriteLine("\nOgiltig inmatning, välj mellan alternativ 1-3!");
            }
        }
    }
}
    
