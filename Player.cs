namespace UTS_5;

class Player
{
    public int Health {get;set;}
    public string Name {get;set;}
    public int AttackPower{get;set;}
    public float Exp {get;set;}
    public bool IsDead {get;set;}
    public bool IsRunningAway{get;set;}

    public Player(){
        Health = 100;
        AttackPower = 15;
        Exp = 0.0f;
    }
    public virtual void Skill(Enemy enemy){
        Console.WriteLine("Skill : Berserk");
        AttackPower *=2;
    }
    public virtual void Defend (){
        Console.WriteLine("Defends");
    }
    public void GetHit(int hitValue){
        Console.WriteLine(Name+ " Get Hit " +hitValue);
        Health -= hitValue;

        if(Health<=0){
            Health = 0;
            Die();
        }

    }
     public void Die(){
            Console.WriteLine("You're Dead! Game Over!");
            IsDead = true;
        }
    public void GetHeal(int hitValue){
        Console.WriteLine(Name+ " Get Hit " +hitValue);
        Health += hitValue;

        if(Health<=0){
            Health = 0;
            Die();
        }

    }
    public virtual void Healer (Player player){
        Console.WriteLine("Skill:Heal");
        AttackPower = 3;

    }
  
}
