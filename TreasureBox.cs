
using UTS_5;


class TreasureBox
{
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }
    public int D { get; set; }


    public TreasureBox()
    {
        A = 1;
        B = 9;
        C = 4;
        D = 5;
    }

    public bool TreasureCode (Player player)
    {

        Console.Write("Input First Code: ");
        string? tebakanA = Console.ReadLine();
        Console.Write("Input Second Code: ");
        string? tebakanB = Console.ReadLine();
        Console.Write("Input Third Code: ");
        string? tebakanC = Console.ReadLine();
        Console.Write("Input Fourth Code: ");
        string? tebakanD = Console.ReadLine();
        Console.WriteLine("Your Guess : "+tebakanA+" "+tebakanB+" "+tebakanC+" "+tebakanD+"");

        int ptebakA = Convert.ToInt32(tebakanA);
        int ptebakB = Convert.ToInt32(tebakanB);
        int ptebakC = Convert.ToInt32(tebakanC);
        int ptebakD = Convert.ToInt32(tebakanD);


        if(A == ptebakA && B == ptebakB && C == ptebakC && D == ptebakD)
        {
            Console.WriteLine("");
            Console.WriteLine("Your guess is correct");
            Console.WriteLine("You got Extra HP as big as 100 and Attack power as big as 5 ");
            player.AttackPower += 10;
            player.Health += 150;
            Console.WriteLine(player.Name+"'s Stats: HP: "+player.Health+" Attack power: "+player.AttackPower);
            return true;

        }else
        {
            Console.WriteLine("Sorry,Your guess is wrong");
            Console.WriteLine("Focus for the next chance!");
            return false;
        }

    }
}