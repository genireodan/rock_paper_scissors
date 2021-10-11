using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Option
{
    public enum OptionName
    {
        Rock = 1,
        Paper,
        Scissors
    }

    public interface IOption
    {
        OptionName OptionName { get; set; }
        bool WinAgainst(IOption option);
    }
}
