namespace UTS_5;

class Enemy
{
     public int Health {get;set;}
    public string? Name {get;set;}
    public int AttackPower{get;set;}
    public bool IsDead {get;set;}
    public bool isStunned {get;set;}
    public bool IsBoss {get;set;}

    Random rnd = new Random();
    internal static bool IsStunned;
    

    public void getHit(int hitValue){
        Console.WriteLine(Name+ " Get hit " +hitValue);
        Health -= hitValue;

        if(Health<=0){
            Health = 0;
            Die();
        }
    }
            public void Die (){
            Console.WriteLine("Enemy dead");
            IsDead = true;
        }
    public virtual void Skill(Player player)
        {
            player.GetHit(2* AttackPower);
        }

        public virtual void BossSkill(Player player) 
        {
            player.GetHit(3*AttackPower);
        }
}
