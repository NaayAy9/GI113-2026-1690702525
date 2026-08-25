/*
 * Student ID : 1690702525
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
using System.Collections;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== BOSS STATUS: INTITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp}/ {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            // คำนวณเปอร์เซ็น
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            // ลด Hp 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: INTITIAL =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
        }
    }
}
