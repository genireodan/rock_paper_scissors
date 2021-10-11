using RockPaperScissors.Game.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Party
{
    public enum PartyMode
    {
        HumanVsHuman = 1,
        HumanVsComputerLastChoice,
        HumanVsComputerRandom
    }

    public interface IPartyModeFactory
    {
        (IPlayer, IPlayer) BuildMode(PartyMode partyMode);
        string AvailableModes();
    }

    public class PartyModeFactory : IPartyModeFactory
    {
        public (IPlayer, IPlayer) BuildMode(PartyMode partyMode)
        {
            switch(partyMode)
            {
                case PartyMode.HumanVsHuman:
                    return HumanToHumanBuilder();
                case PartyMode.HumanVsComputerLastChoice:
                    return HumanVsComputerLastChoiceBuilder();
                case PartyMode.HumanVsComputerRandom:
                    return HumanVsComputerRandomBuilder();
                default:
                    throw new Exception("Mode not implemented yet");
            }
        }

        public string AvailableModes()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var option in Enum.GetValues(typeof(PartyMode)))
            {
                stringBuilder.AppendLine($"{option} : {(int)option}");
            }

            return stringBuilder.ToString();
        }

        private (IPlayer, IPlayer) HumanToHumanBuilder()
        {
            Console.WriteLine("--> Enter Human Player 1 Name:");
            var player1Name = Console.ReadLine();
            Console.WriteLine("--> Enter Human Player 2 Name:");
            var player2Name = Console.ReadLine();

            return (new HumanPlayer(player1Name), new HumanPlayer(player2Name));
        }

        private (IPlayer, IPlayer) HumanVsComputerLastChoiceBuilder()
        {
            Console.WriteLine("--> Enter Human Player Name:");
            var player1Name = Console.ReadLine();

            return (new HumanPlayer(player1Name), new ComputerPlayerLastChoice());
        }

        private (IPlayer, IPlayer) HumanVsComputerRandomBuilder()
        {
            Console.WriteLine("--> Enter Human Player Name:");
            var player1Name = Console.ReadLine();

            return (new HumanPlayer(player1Name), new ComputerPlayerRandom());
        }
    }
}
