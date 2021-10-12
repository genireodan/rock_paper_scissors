using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Option
{
    public class FlameThrowerOption : Option
    {
        public FlameThrowerOption()
        {
            OptionName = OptionName.FlameThrower;
            beatableOptions = new List<OptionName> { OptionName.Paper };
        }
    }
}
