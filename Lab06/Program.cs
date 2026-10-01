/*
 * Student ID : 1690702525
 * Name       : Lab06
 * Section    : 129C
 * No.        : 16
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int survivorHp = 80;
            int zombieHp = 100;
            int axeDamage = 45;
            int medkitHeal = 20;
            int barricadeStrength = 50;

            Console.WriteLine("==> Zombie Survival <==");
            Console.WriteLine("== Survivor vs. Zombie ==");
            Console.WriteLine("ACTION 1: ATTACK WITH AN AXE");
            Console.WriteLine("ACTION 2: USE A MEDKIT");
            Console.WriteLine("ACTION 3: BUILD A BARRICADE");
            Console.Write("Choose your action (1-3): ");

            bool userInput = int.TryParse(Console.ReadLine(), out int choice);

            if (!userInput)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 3.");
            }
            else if (choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid action. Please choose a number from 1 to 3.");
            }
            else if (choice == 1)
            {
                zombieHp -= axeDamage;
                Console.WriteLine($"You hit the zombie with an axe. Zombie HP: {zombieHp}");
            }
            else if (choice == 2)
            {
                survivorHp += medkitHeal;

                if (survivorHp > 100)
                {
                    survivorHp = 100;
                    Console.WriteLine("You use a medkit. Your HP is full.");
                }
                else
                {
                    Console.WriteLine($"You use a medkit. Survivor HP: {survivorHp}");
                }
            }
            else
            {
                Console.WriteLine($"You build a barricade. Barricade strength: {barricadeStrength}");
            }
        }
    }
}