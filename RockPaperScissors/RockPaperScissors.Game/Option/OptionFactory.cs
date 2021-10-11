using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Option
{
    public interface IOptionFactory
    {
        IOption GetOption(OptionName optionName);
        string AvailableOptions();
    }

    public class OptionFactory : IOptionFactory
    {
        public IOption GetOption(OptionName optionName)
        {
            switch(optionName)
            {
                case OptionName.Paper: return new PaperOption();
                case OptionName.Rock: return new RockOption();
                case OptionName.Scissors: return new ScissorsOption();
                default: return null;
            }
        }

        public string AvailableOptions()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var option in Enum.GetValues(typeof(OptionName)))
            {
                stringBuilder.AppendLine($"{option} : {(int)option}");
            }

            return stringBuilder.ToString();
        }
    }
}
