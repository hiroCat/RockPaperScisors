﻿using System;

namespace RockPaperScissors.Contract.ServiceLibrary.DTO
{
    public class MoveDto : BaseDto
    {
        public int playerWins { get; set; }
        public DateTime dateMove { get; set; }
        public int computerMove { get; set; }
        public int humanMove { get; set; }
        public int gameType { get; set; }
        public int difficultyType { get; set; }
    }
}
