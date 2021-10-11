using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Option
{
    public class ScissorsOption : Option
    {
        public ScissorsOption()
        {
            OptionName = OptionName.Scissors;
            beatableOptions = new List<OptionName> { OptionName.Paper };
        }
    }
}
