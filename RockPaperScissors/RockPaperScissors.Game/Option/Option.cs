using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Option
{
    public class Option : IOption
    {
        public OptionName OptionName { get; set; }

        protected List<OptionName> beatableOptions;

        public virtual bool WinAgainst(IOption option)
        {
            return beatableOptions.Contains(option.OptionName);
        }
    }
}
