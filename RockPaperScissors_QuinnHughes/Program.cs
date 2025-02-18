using RockPaperScissors_QuinnHughes;

namespace RockPaperScissors_QuinnHughes
{

}
internal class Program
{
    //Declarations and Initializations
    static public int playerWins = 0;
    static public int cpuWins = 0;
    static public bool playing = true;
    static void Main(string[] args)
    {
        while (playing)
        {
            SelectHand();
        }
    }


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
        Console.WriteLine("SHODAN picked: " + hands[cpuHand]);

        PlayRound(playerInput, cpuHand);
    }
    static void PlayRound(string playerChoice, int cpuChoice)
    {
        int[] outcomes;   //0 is stalemate, 1 is win, 2 is loss
        switch (playerChoice)
        {
            case "ROCK":
                outcomes = [0, 2, 1, 1, 2];
                OutputOutcomes(outcomes[cpuChoice]);
                break;
            case "PAPER":
                outcomes = [1, 0, 2, 2, 1];
                OutputOutcomes(outcomes[cpuChoice]);
                break;
            case "SCISSORS":
                outcomes = [2, 1, 0, 1, 2];
                OutputOutcomes(outcomes[cpuChoice]);
                break;
            case "LIZARD":
                outcomes = [2, 1, 2, 0, 1];
                OutputOutcomes(outcomes[cpuChoice]);
                break;
            case "SPOCK":
                outcomes = [1, 2, 1, 2, 0];
                OutputOutcomes(outcomes[cpuChoice]);
                break;
        }
    }
    static void OutputOutcomes(int p1)
    {
        switch (p1)
        {
            case 0:
                Console.WriteLine("Its a tie, no points. Score: " + playerWins + " - " + cpuWins);
                break;
            case 1:
                playerWins++;
                Console.WriteLine("You won a round. Score: " + playerWins + " - " + cpuWins);
                break;
            case 2:
                cpuWins++;
                Console.WriteLine("You lost a round. Score: " + playerWins + " - " + cpuWins);
                break;
        }

        if (playerWins >= 5)
        {
            Console.WriteLine("You win! Final score: " + playerWins + " - " + cpuWins);
            playerWins = 0;
            cpuWins = 0;
            EndGame();
        }
        else if (cpuWins >= 5)
        {
            Console.WriteLine("You Lose! Final score: " + playerWins + " - " + cpuWins);
            playerWins = 0;
            cpuWins = 0;
            EndGame();
        }
    }
    static void EndGame()
    {
        Console.WriteLine("Press 'ESC' to end the game or any other key to continue.");
        var key = Console.ReadKey(true).Key; //suffex .key returns consoleKey value. true/false is for the optional display of the key pressed.
        if (key == ConsoleKey.Escape)
        {
            playing = false;
        }
    }
}

