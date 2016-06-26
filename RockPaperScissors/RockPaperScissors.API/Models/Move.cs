using System;

namespace RockPaperScissors.API.Models
{
    public class Move : BaseModel
    {
        public int playerWins { get; set; } // 0 wins , 1 loses , 2 tie 
        public DateTime dateMove { get; set; }
        public int computerMove { get; set; }
        public int humanMove { get; set; }
        public int gameType { get; set; }   // 0 normal game , 1 spocktype
        public int difficultyType { get; set; }
    }
}