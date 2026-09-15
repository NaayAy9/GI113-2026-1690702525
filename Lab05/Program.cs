/*
 * Student ID : 1690702525
 * Name       : Lab05
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */
internal class Program
{
    static void Main(string[] args)
    {
        // Game title, Sub-title
        Console.WriteLine("==>> MY GAME DEE <<==");
        Console.WriteLine("Hero vs. Monster, Fight damage calculator\n");

        // Hero stats input HP, ATK, DEF
        Console.Write("Hero Health: ");
        bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
        Console.Write("Hero Attack: ");
        bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk); 
        Console.Write("Hero Defense: ");
        bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

        // Monster stats input
        Console.Write("Monster Health: ");
        bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
        Console.Write("Monster Attack: ");
        bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
        Console.Write("Monster Defense: ");
        bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);
        // Input validation
        bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
        bool isMonsterIntValid = monHpOk && monAtkOk && monDefOk;
        Console.WriteLine($"\nHero stats valid: {isHeroIntValid}");
        Console.WriteLine($"Monster stats valid: {isMonsterIntValid}");

        Console.WriteLine($"[Hero] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
        Console.WriteLine($"[Monster] HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");
        //bool allIntValid = !isHeroIntValid && isMonsterIntValid;
        //ถ้าเอาแค่ชื่อ bool มาเช็ค คือ เช็คว่าเป็นจิงมั้ย? แต่ถ้าใส่! ด้านหน้าคือตรงข้าม (จริง -> เท็จ)

        // Compound assignment: += จำลองสถานการณ์การผู้เล่นดื่ม potion ก่อนต่อสู้
        int potionHeal = 8;
        heroHp = heroHp + potionHeal;           //แบบยาว
        heroHp += potionHeal;                   //แบบสั้น ความหมายเดียวกัน
        Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} HP. Hero HP now {heroHp}");

        // Arithmetic + การโจมตีธรรมดา (Normal Attack) ของ Hero ต่อ Monster
        int normalAttackDamage = Math.Max(0, heroAtk - monDef);  // ความเสียหายการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู
        Console.WriteLine($"\nNormal Attack would deal {normalAttackDamage} damage.");

        // Precedence
        int powerAttackDamage = Math.Max(0, (heroAtk * 2) - monDef);  // ความเสียหายการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู)
        Console.WriteLine($"Power Attack would deal {powerAttackDamage} damage.");


        // Random, Simple percent of critical chance
        Random random = new Random();
        int roll = random.Next(1, 101); // ต้องบวก 1 เสมอ เพราะ Next(1, 101) จะให้ค่า 1-100
        bool isCriticalHit = roll <= 54; // 54% chance of critical hit
        int criticalDamage = normalAttackDamage + Convert.ToInt32(isCriticalHit) * normalAttackDamage; // ถ้า isCriticalHit เป็นจริง จะได้ค่า 1 * normalAttackDamage, ถ้าเป็นเท็จ จะได้ค่า 0 * normalAttackDamage
        Console.WriteLine($"Critical Hit rolled {roll}: {isCriticalHit} damage.");
        Console.WriteLine($"If critical, normal attack would instead deal: {criticalDamage}");
    }
}
