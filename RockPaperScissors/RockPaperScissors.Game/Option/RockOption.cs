using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Option
{
    public class RockOption : Option
    {
        public RockOption()
        {
            OptionName = OptionName.Rock;
            beatableOptions = new List<OptionName> { OptionName.Scissors, OptionName.FlameThrower };
        }
    }
}
