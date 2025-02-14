using RockPaperScissors_QuinnHughes;

namespace RockPaperScissors_QuinnHughes
{

}
internal class Program
{

    static void Main(string[] args)
    {
        SelectHand();
        //Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
    }
   /* static void KeepScore()
    {
        int playerWins;
        int cpuWins;


        if (playerWins == 5)
        {
            Console.WriteLine("You win! Final score: " + playerWins + " - " + cpuWins);
            playerWins = 0;
            cpuWins = 0;
        }
    }*/

    static void SelectHand()
    {
        string[] hands = { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
        bool preRound = true;
        string? playerInput = "";

        while (preRound == true)
        {
            Console.WriteLine("Please select: Rock, Paper, Scissors, Lizard, Spock");
            playerInput = Console.ReadLine();
                playerInput = playerInput.ToUpper();
                for (int i = 0; i < hands.Length; i++)
                {
                    if (playerInput == hands[i])
                    {
                        preRound = false;
                        break;
                    }

                }
        }
        Console.WriteLine("You picked: " + playerInput);
        Random rand = new Random();
        int cpuHand = rand.Next(0, hands.Length);
        Console.WriteLine("I picked: " + cpuHand);


        PlayRound(playerInput,cpuHand,hands);

    }
    static void PlayRound(string Input, int cpu,string[] hands)
    {

    }

}

