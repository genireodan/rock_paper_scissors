using RockPaperScissors.Game.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Player
{
    public class ComputerPlayerLastChoice : IPlayer
    {
        public string Name { get; set; }

        private IOption lastChoice;

        private IOptionFactory optionFactory = new OptionFactory();

        private Random random;

        public ComputerPlayerLastChoice()
        {
            Name = "Computer Last Choice Player";
            lastChoice = null;
            random = new();
        }

        public IOption Play()
        {
            Console.WriteLine("Choosing...");
            System.Threading.Thread.Sleep(1000);
            if(lastChoice == null)
                lastChoice = GenerateFirstOption();
            else
                lastChoice = GenerateNextChoice(lastChoice);

            return lastChoice;
        }

        private IOption GenerateFirstOption()
        {
            Array values = Enum.GetValues(typeof(OptionName));
            return optionFactory.GetOption((OptionName)values.GetValue(random.Next(values.Length)));
        }

        private IOption GenerateNextChoice(IOption lastChoice)
        {
            //There are simpler ways to implement this feature
            //We know that the sequence will be repeated between Rock -> Paper -> Scissors
            //But we try to support that other options may be added with different logic
            foreach (OptionName optionName in Enum.GetValues(typeof(OptionName)))
            {
                var option = optionFactory.GetOption(optionName);
                if (option.WinAgainst(lastChoice))
                    return option;
            }

            //We just admit that if there is no win, it will return the same choice
            //We know that it is not the best idea, because the player will keep the same choice forever
            //But just to simplify this player
            //We could randomize another choice for example
            return lastChoice;
        }
    }
}
