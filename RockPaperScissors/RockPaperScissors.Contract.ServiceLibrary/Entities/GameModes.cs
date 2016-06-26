using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contract.ServiceLibrary.Entities
{
    public enum ClassicGameMove
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    };

    public enum SpockGameMove
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2,
        Lizard = 3,
        Spock = 4
    };

    public enum GameModes
    {
        ClassicGameMove = 3,
        SpockGameMove = 5
    }
}
