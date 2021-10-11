using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Game.Progress
{
    public interface IProgressInformation
    {

    }

    public interface IProgressLogger
    {
        void Log(IProgressInformation progressInformation);
    }
}
