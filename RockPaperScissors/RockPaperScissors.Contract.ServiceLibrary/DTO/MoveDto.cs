using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contract.ServiceLibrary.DTO
{
    public class MoveDto
    {
        public bool playerWins { get; set; }
        public DateTime dateMove { get; set; }
        public int computerMove { get; set; }
        public int humanMove { get; set; }
        public int gameType { get; set; }
    }
}
