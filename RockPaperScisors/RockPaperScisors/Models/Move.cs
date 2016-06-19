using System;

namespace RockPaperScisors.Models
{
    public class Move
    {
        public long id { get; set; }
        public bool playerWins { get; set; }
        public DateTime dateMove { get; set; }
        public int computerMove { get; set; }
        public int humanMove { get; set; }
        public int gameType { get; set; }
    }
}