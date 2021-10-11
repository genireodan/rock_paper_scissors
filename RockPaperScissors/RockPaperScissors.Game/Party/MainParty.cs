using RockPaperScissors.Game.Option;
using RockPaperScissors.Game.Player;
using RockPaperScissors.Game.Progress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Party
{
    public class MainParty : IParty
    {
        public IPlayer Player1 { get; set; }
        public IPlayer Player2 { get; set; }

        public int NumberOfWinnerRounds { get; set; }

        private bool partyRunning;

        private IProgressLogger progressLogger = new ProgressLogger();

        public void SetupParty(IPlayer player1, IPlayer player2, int numberOfWinnerRounds)
        {
            Player1 = player1;
            Player2 = player2;
            NumberOfWinnerRounds = numberOfWinnerRounds;

            partyRunning = false;
        }

        public IPlayer Start()
        {
            partyRunning = true;
            return PlayGame();
        }

        private (bool, IPlayer) IsGameProgressing(int player1Score, int player2Score)
        {
            if (player1Score < NumberOfWinnerRounds && player2Score < NumberOfWinnerRounds)
                return (true, null);
            else if (player1Score == 3)
                return (false, Player1);
            else
                return (false, Player2);
        }

        private IPlayer PlayGame()
        {
            int player1Score = 0;
            int player2Score = 0;

            IPlayer winner = null;

            int round = 1;

            while(partyRunning)
            {
                Console.WriteLine($"----- Player {Player1.Name} is playing -----");
                IOption player1Option = Player1.Play();
                Console.WriteLine($"----- Player {Player2.Name} is playing -----");
                IOption player2Option = Player2.Play();

                if (player1Option.WinAgainst(player2Option))
                    player1Score++;
                else if(player2Option.WinAgainst(player1Option))
                    player2Score++;

                (partyRunning, winner) = IsGameProgressing(player1Score, player2Score);

                progressLogger.Log(new ProgressLogger.ProgressInformation
                {
                    Player1 = Player1,
                    Player1Choice = player1Option,
                    Player1Score = player1Score,
                    Player2 = Player2,
                    Player2Choice = player2Option,
                    Player2Score = player2Score,
                    Round = round
                });

                round++;
            }

            return winner;
        }
    }
}
