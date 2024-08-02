using UTS_5;

class Penjahatmenengah : Enemy
    {
        public Penjahatmenengah()
        {
            Health = 70; 
            AttackPower = 6;
            Name = "Chi";
            Console.WriteLine("Take a Look!!! Chi Attack The People");
        }

        public override void Skill(Player player)
        {
            Console.WriteLine("Slap");
            base.Skill(player);
        }
    }
    