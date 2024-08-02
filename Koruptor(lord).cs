using UTS_5;

class Koruptor: Enemy
    {
        public Koruptor()
        {
            Health = 1000; 
            AttackPower = 100;
            Name = "Rasih";
            Console.WriteLine("Take a Look!!! Rasih Attack The People");
        }
        
        
        public override void BossSkill(Player player)
        {
            Console.WriteLine("Snatch");
            base.BossSkill(player);
        }
    }
    