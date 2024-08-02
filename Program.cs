namespace UTS_5;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Welcome to mini RPG ");
       Console.WriteLine("What's your name ?");
       Novice player = new Novice();
       player.Name = Console.ReadLine();
       Console.Clear();
       Console.WriteLine("Hai "+player.Name+" now you are a novice");
       Console.WriteLine("You can choose your role,if your exp is 100");
       Console.WriteLine("Do you ready to play? [y/n]");
       string? bready = Console.ReadLine();
       Console.WriteLine("----------------------------");
        if(bready == "y"){
            Penjahatkecil penjahatkecil = new Penjahatkecil();
            Encounter encounter4 = new Encounter(player,penjahatkecil);
            Penjahatmenengah penjahatmenengah = new Penjahatmenengah();
            Encounter encounter1 = new Encounter(player,penjahatmenengah);
            Penjahatkakap penjahatkakap = new Penjahatkakap();
            Encounter encounter2 = new Encounter(player, penjahatkakap);
            TreasureBox treasureBox = new TreasureBox();
            treasureBox.TreasureCode(player);
            Koruptor koruptor = new Koruptor();
            Encounter encounter3 = new Encounter(player,koruptor);

    }
    else if(bready=="n")
        {
            Console.WriteLine("Bye-bye");
        }
    else{
        Console.WriteLine("I Dont Know");
        Console.Read();
}
    } 
   
}
