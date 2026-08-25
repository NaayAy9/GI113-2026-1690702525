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

            // Part B
            // ตัวละคร 1
            string infectedName = "Eren";
            int Health = 40;
            float StaminaRegen = 1.25f;
            char Rank = 'B';
            bool IsInfected = false;

            Console.WriteLine($"Name: {infectedName}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Stamina Regen: {StaminaRegen}");
            Console.WriteLine($"Rank: {Rank}");
            Console.WriteLine($"Is Infected: {IsInfected}");
            Console.WriteLine();

            // ตัวละคร 2
            string survivalName = "Mikasa";
            int meleeAttack = 40;
            double attackRange = 1.25;
            char Zone = 'N';
            bool HasKnife = true;

            Console.WriteLine($"Name: {survivalName}");
            Console.WriteLine($"Melee Attack: {meleeAttack}");
            Console.WriteLine($"Attack Range: {attackRange}%");
            Console.WriteLine($"Zone: {Zone}");
            Console.WriteLine($"Has Knife: {HasKnife}");
            Console.WriteLine();

            // ตัวละคร 3
            string survival2Name = "Armin";
            int survival2Level = 3;
            float survival2Speed = 6.8f;
            char survival2Role = 'S';
            bool survival2IsLeader = true;

            Console.WriteLine($"Name: {survival2Name}");
            Console.WriteLine($"Level: {survival2Level}");
            Console.WriteLine($"Speed: {survival2Speed}");
            Console.WriteLine($"Role: {survival2Role}");
            Console.WriteLine($"Is Leader: {survival2IsLeader}");
            Console.WriteLine();

            // ตัวละคร 4
            string survival3Name = "Levi";
            int survival3Kills = 14;
            double survival3SurvivalDays = 22.5;
            char survival3Status = 'A';
            bool survival3IsDisabled = true;

            Console.WriteLine($"Name: {survival3Name}");
            Console.WriteLine($"Kills: {survival3Kills}");
            Console.WriteLine($"Survival Days: {survival3SurvivalDays}");
            Console.WriteLine($"Status: {survival3Status}");
            Console.WriteLine($"Is Disabled: {survival3IsDisabled}");
        }
    }
}
