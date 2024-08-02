using UTS_5;

class Encounter
    {

        public Encounter(Player player, Enemy enemy)
        {
            Console.WriteLine (enemy.Name +" attacking you ...");
            Console.WriteLine ("choose your action");
            Console.WriteLine ("1. Single attack");
            Console.WriteLine ("2. Skill ");
            Console.WriteLine ("3. Defend");
            Console.WriteLine ("4. Run away");

            if(Warrior.stunDuration<0){
                enemy.isStunned = false;
            }

            while(!enemy.IsDead && !player.IsDead && !player.IsRunningAway)
            {
                Console.WriteLine("Choose your action : ...");
                string? playerAction = Console.ReadLine();
                Console.WriteLine("----------------------------");
                Random rnd = new Random();
                switch(playerAction)
                {
                    case "1" :
                    Console.WriteLine("you are doing single attack");
                    enemy.getHit(player.AttackPower);
                    if(!enemy.isStunned)
                    {
                        player.GetHit(enemy.AttackPower);
                    }
                    player.Exp+= 10;
                    Console.WriteLine("Player HP: " + player.Health+" | Enemy Hp : "+enemy.Health+" | EXP Player:"+player.Exp);
                    break;

                    case "2" :
                    player.Skill(enemy);
                    player.Exp +=15;
                    Console.WriteLine("Player HP: " + player.Health+" | Enemy Hp : "+enemy.Health+" | EXP Player:"+player.Exp);
                    break;

                    case "3" :
                    player.Defend();
                    if(!enemy.isStunned)
                    {
                        if(rnd.Next(1,4)==2)
                        {
                            enemy.Skill(player);
                        }
                    }
                    Console.WriteLine("Player HP: " + player.Health+" | Enemy Hp : "+enemy.Health+" | EXP Player:"+player.Exp);
                    break;

                    case "4" :
                    player.IsRunningAway = true;
                    Console.WriteLine(player.Name+" is runing away ");
                    player.Exp = 0;
                    Console.Read();
                    break;
                
                }

                //jika exp sudah mencapai 100 maka player akan diberikan pilihan berganti role
                    if (player.Exp >= 100)
                    {
                        Console.WriteLine("Congrataulation, you have achived 100 EXP! You can choose role.");
                        Console.WriteLine("Choose role:");
                        Console.WriteLine("1) Acolyte");
                        Console.WriteLine("2) Mage");
                        Console.WriteLine("3) Rogue");
                        Console.WriteLine("4) Warrior");
                        Console.Write("Select (1-4): ");

                        string? roleChoice = Console.ReadLine();

                        switch (roleChoice)
                        {
                            case "1":
                                player = new Acolyte(); // Ganti peran menjadi Acolyte
                                break;
                            case "2":
                                player = new Mage(); // Ganti peran menjadi Mage
                                break;
                            case "3":
                                player = new Rogue(); // Ganti peran menjadi Rogue
                                break;
                            case "4":
                                player = new Warrior(); // Ganti peran menjadi Warrior
                                break;
                            default:
                                Console.WriteLine("Not valid");
                                break;
                        }
                        player.Exp = 0;
                    }
                if(enemy.isStunned)
                {
                    Warrior.stunDuration--;
                }
            }
            if(enemy.IsDead)
            {
                Console.WriteLine("you get "+player.Exp+" Exp");
                Console.WriteLine("level up ");
                player.Health+= 100;
                player.AttackPower+= 5;
                Console.WriteLine("Player HP: " + player.Health+" | Enemy Hp : "+enemy.Health+" | EXP Player:"+player.Exp);

            }else if(player.IsDead) 
            {
                Console.WriteLine(" Nice Try ");
                Console.WriteLine(" Thank you for playing...");
                Console.WriteLine("See you..");
                Environment.Exit(0);
            }
            else if(enemy.IsBoss){
                Console.WriteLine("Congratulation!");
            }
        }
    }


