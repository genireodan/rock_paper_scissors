using RockPaperScissors.Game.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Player
{
    public class HumanPlayer : IPlayer
    {
        private IOptionFactory optionFactory = new OptionFactory();

        public string Name { get; set; }

        public HumanPlayer(string name)
        {
            Name = name;
        }

        public IOption Play()
        {
            OptionName optionName;
            Console.WriteLine("- Available Options:");
            Console.WriteLine(optionFactory.AvailableOptions());
            Console.WriteLine("Choose an option: ");
            if (int.TryParse(Console.ReadLine(), out int option) && Enum.IsDefined(typeof(OptionName), option))
                optionName = (OptionName)option;
            else
                optionName = default;

            return optionFactory.GetOption(optionName);
        }
    }
}
