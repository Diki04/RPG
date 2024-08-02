using UTS_5;
class Warrior : Player
    {
        public int Energy { get; set; }
        public static int stunDuration = 3;

        public Warrior()
        {
            Health = 300;
            AttackPower = 10;
            Energy = 5;
        }
        public override void Skill(Enemy enemy)
        {
            Console.WriteLine("Skill : Desert Tornado");
            if(Energy >= 3){
                Console.WriteLine("Fyuhhhh!! ");
                stunDuration = 3;
                enemy.getHit(3*AttackPower);
                Energy -=3;
            }else{
                Console.WriteLine("You Do Not Have Energy");
            }
    
        }
       
        public override void Defend()
        {
            base.Defend();
            Energy += 3;
            Console.WriteLine("Generating Energy...");
        }



    }