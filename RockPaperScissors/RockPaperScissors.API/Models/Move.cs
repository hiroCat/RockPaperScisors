using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissors.API.Models
{
    public class Move : BaseModel
    {
        public bool playerWins { get; set; }
        public DateTime dateMove { get; set; }
        public int computerMove { get; set; }
        public int humanMove { get; set; }
        public int gameType { get; set; }
        public int difficultyType { get; set; }
    }
}