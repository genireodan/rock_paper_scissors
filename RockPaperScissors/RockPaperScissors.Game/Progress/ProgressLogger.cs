using RockPaperScissors.Game.Option;
using RockPaperScissors.Game.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Progress
{

    public class ProgressLogger : IProgressLogger
    {
        public class ProgressInformation : IProgressInformation
        {
            public int Round { get; set; }
            public IPlayer Player1 { get; set; }
            public IPlayer Player2 { get; set; }
            public IOption Player1Choice { get; set; }
            public IOption Player2Choice { get; set; }
            public int Player1Score { get; set; }
            public int Player2Score { get; set; }
        }

        public void Log(IProgressInformation progressInformation)
        {
            var progressInfo = (ProgressInformation)progressInformation;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{new string('#', 10)} Round {progressInfo.Round} {new string('#', 10)}");
            stringBuilder.AppendLine(new string('-', 30));
            stringBuilder.AppendLine($"Player One: {progressInfo.Player1.Name}");
            stringBuilder.AppendLine($"Round Choice: {progressInfo.Player1Choice.OptionName}");
            stringBuilder.AppendLine($"Score: {progressInfo.Player1Score}");
            stringBuilder.AppendLine(new string('-', 30));
            stringBuilder.AppendLine($"Player Two: {progressInfo.Player2.Name}");
            stringBuilder.AppendLine($"Round Choice: {progressInfo.Player2Choice.OptionName}");
            stringBuilder.AppendLine($"Score: {progressInfo.Player2Score}");
            stringBuilder.AppendLine($"{new string('#', 10)} End Round {new string('#', 10)}");

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
