using UTS_5;

class Mage : Player
{
    public int Mana { get; set; }
    
    public Mage()
    {
        Health = 200;
        AttackPower = 15;
        Mana = 20;
    }

    public override void Skill(Enemy enemy)
    {
        if (Mana >= 30)
        {
            Console.WriteLine("Skill : Fire Bolt");
            Console.WriteLine("Fireeeee!");
            enemy.getHit(AttackPower + 100);
            Mana = 0;
        }else{
            Console.WriteLine($"Mana : {Mana}");
            Console.WriteLine("You're mana not enough ");
        }
    }

    public override void Defend()
    {
        base.Defend();
        Console.WriteLine("Recovery mana");
        Mana+=5;
    }
}