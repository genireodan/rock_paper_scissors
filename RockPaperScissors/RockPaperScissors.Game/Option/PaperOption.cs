using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Option
{
    public class PaperOption : Option
    {
        public PaperOption()
        {
            OptionName = OptionName.Paper;
            beatableOptions = new List<OptionName> { OptionName.Rock };
        }
    }
}
