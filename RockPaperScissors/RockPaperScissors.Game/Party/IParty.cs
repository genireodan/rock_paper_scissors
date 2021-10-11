using RockPaperScissors.Game.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Party
{
    public interface IParty
    {
        IPlayer Player1 { get; set; }
        IPlayer Player2 { get; set; }
        int NumberOfWinnerRounds { get; set; }

        void SetupParty(IPlayer player1, IPlayer player2, int numberOfWinnerRounds);
        IPlayer Start();
    }
}
