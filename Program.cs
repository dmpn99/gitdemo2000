// See https://aka.ms/new-console-template for more information
using System;

internal class Program
{
    public static void Main(string[] args)
    {
            bool isRunning = true;
            
            while (isRunning)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("*************************************************************************");
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
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Du har valt New York - Stockholm");
                    isRunning = false;
                }
                else
                {
                    
                    Console.WriteLine("Felaktigt val, försök igen!");
                
                    
                }
            }
        


        
    }
}    
    
