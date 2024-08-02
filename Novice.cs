using UTS_5;

class Novice : Player
    {

        public int Energy { get; set; }
        public Novice()
        {
            Health = 100;
            AttackPower = 15;
            Energy = 15;
        }

        public override void Skill(Enemy enemy)
        {
            if(Energy >= 5){
                Console.WriteLine(" Skill : Slash ");
                enemy.getHit(2* AttackPower);
                Energy-=5;
            }else{
                Console.WriteLine("You Do Not Have Energy");
            }
        }

        public override void Defend()
        {
            base.Defend();
            Energy += 5;
            Console.WriteLine("Generating Enargy...");
        }
    }