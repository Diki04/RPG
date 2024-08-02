using UTS_5;

class Penjahatkakap : Enemy
    {
        public Penjahatkakap()
        {
            Health = 80; 
            AttackPower = 9;
            Name = "Raja";
            Console.WriteLine("Take a Look!!! Gamy Attack The People");
        }

        public override void Skill(Player player)
        {
            Console.WriteLine("Thunder");
            base.Skill(player);
        }
    }
    