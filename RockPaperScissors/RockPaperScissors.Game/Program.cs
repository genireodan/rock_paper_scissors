using RockPaperScissors.Game.Party;
using RockPaperScissors.Game.Player;
using System;

namespace RockPaperScissors.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            IParty mainParty = new MainParty();

            //Define players
            IPlayer player1, player2;
            (player1, player2) = BuildGameMode();

            mainParty.SetupParty(player1, player2, 3);
            //Start Game
            IPlayer winner = mainParty.Start();

            Console.WriteLine("Winner is : " + winner.Name);
        }

        static (IPlayer, IPlayer) BuildGameMode()
        {
            IPartyModeFactory partyModeFactory = new PartyModeFactory();
            do
            {
                Console.WriteLine($"{new string('#', 10)} Welcome To Rock Paper Scissors Game {new string('#', 10)}");
                Console.WriteLine("- Please choose a mode");
                Console.WriteLine(partyModeFactory.AvailableModes());
                Console.WriteLine("Choose a mode: ");
                if (int.TryParse(Console.ReadLine(), out int mode) && Enum.IsDefined(typeof(PartyMode), mode))
                {
                    return partyModeFactory.BuildMode((PartyMode)mode);
                }
                else
                {
                    Console.WriteLine("!!! Please choose an available mode !!!");
                }
            } while (true);
        }
    }
}
