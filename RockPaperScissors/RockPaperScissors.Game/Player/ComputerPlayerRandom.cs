using RockPaperScissors.Game.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Player
{
    public class ComputerPlayerRandom : IPlayer
    {
        public string Name { get; set; }

        private IOptionFactory optionFactory = new OptionFactory();

        private Random random;
        private Array optionNamePossibleValues;
        public ComputerPlayerRandom()
        {
            Name = "Computer Random Player";
            random = new();
            optionNamePossibleValues = Enum.GetValues(typeof(OptionName));
        }

        public IOption Play()
        {
            Console.WriteLine("Choosing...");
            System.Threading.Thread.Sleep(1000);

            return optionFactory.GetOption((OptionName)optionNamePossibleValues.GetValue(random.Next(optionNamePossibleValues.Length)));
        }
    }
}
