using RockPaperScissors.Game.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Player
{
    public interface IPlayer
    {
        string Name { get; set; }
        IOption Play();
    }
}
