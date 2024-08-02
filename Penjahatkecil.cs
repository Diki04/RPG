using UTS_5;

class Penjahatkecil : Enemy
    {
        public Penjahatkecil()
        {
            Health = 60; 
            AttackPower = 3;
            Name = "Vi";
            Console.WriteLine("Take a Look!!! Vi Attack The People");
        }

        public override void Skill(Player player)
        {
            Console.WriteLine("Punch");
            base.Skill(player);
        }
    }
    