/*
* Student ID : 1690702525
* Name       : Aduldej Yooin
* Section    : 129C
* No.        : 16
* Course     : GI113 Computer Programming (GI)
*/

using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Scrap Metal";
            const string ProductName = "Ammo Pack";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.0;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----   Crafting Workbench    -----");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"=> {MaterialName} Crafting {SmeltRate} / Salvage {SalvageRate}");
            Console.WriteLine("=> Key 'S' for Craft (Scrap Metal -> Ammo Pack)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ammo Pack -> Scrap Metal)");

            Console.Write("=> Choose Menu: ");
            char.TryParse(Console.ReadLine(), out char menu);

            Console.Write("=> How much would you like: ");
            bool amountParsed = double.TryParse(Console.ReadLine(), out double amount);

            if (amountParsed && amount > 0 && amount <= MaxBatch)
            {
                if (menu == 'S' || menu == 's')
                {
                    double ammoPacks = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} = {ammoPacks:F2} {ProductName}");
                }
                else if (menu == 'B' || menu == 'b')
                {
                    double scrapMetal = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {ProductName} = {scrapMetal:F2} {MaterialName}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu. Please choose S or B.");
                }
            }
            else
            {
                Console.WriteLine($"Error: Invalid amount. Enter a value from 0.01 to {MaxBatch:F2}.");
            }
        }
    }
}
