using UTS_5;

class Acolyte : Player
{
    public int Mana { get; set; }
    public int Healing { get; set; }

    public Acolyte()
    {
        Health = 150;
        AttackPower = 6;
        Mana = 5;
    }
    public override void Skill(Enemy enemy)
    {
        Console.WriteLine("Special skill Heal 50% from HP (use 30 of your mana)");
        if(Mana>=30){
            AttackPower = 10;
            Healing = 3 * Health /10;
            Console.WriteLine("Heal");
            Health += Healing;
            Mana -= 30;
        }
    }
    public override void Healer(Player player)
    {
        if (Mana >=30)
        {
            Console.WriteLine("Skill :  Healing ");
            Console.WriteLine("Heal");
            player.GetHeal((int)0.5*player.Health);
            Mana = 0;
        }
        else
        {
            Console.WriteLine($"Mana : {Mana}");
            Console.WriteLine("Your mana getting low");
        }
    }

    public override void Defend()
    {
        base.Defend();
        Console.WriteLine("Recovery Mana");
        Mana+=4;
    }
}