using UTS_5;

class Rogue : Player
{ 
    
    public int MultipleAttack{ get; set; }
    Random rnd = new Random();

    public Rogue(){
        Health = 250;
        AttackPower = 10;
        MultipleAttack = 2;

    }

    public override void Skill(Enemy enemy)
    {
        if(MultipleAttack >= 3){
            Console.WriteLine("Skill : Slaughter ");
            for(int i=0;i<=MultipleAttack;i++){
                Console.WriteLine("SLASH!!!");
                enemy.getHit(AttackPower + rnd.Next(2,11));
            }
            MultipleAttack = 10 ;
        }else{
            Console.WriteLine("Slaughter Point : "+MultipleAttack);
            Console.WriteLine("Increase your slautgher point!!!");

        }
    }

        public override void Defend()
    {
        base.Defend();
        Console.WriteLine("Recovery is on the progress");
        MultipleAttack++;
    }

}