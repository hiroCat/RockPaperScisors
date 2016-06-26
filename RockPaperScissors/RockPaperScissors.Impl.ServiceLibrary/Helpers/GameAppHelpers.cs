using RockPaperScissors.Contract.ServiceLibrary.Entities;
using System;
using System.Collections.Generic;

namespace RockPaperScissors.Impl.ServiceLibrary.Helpers
{
    public class GameAppHelpers
    {
        /// <summary>
        /// Returns when the player either wins or loses the game with the move 
        /// </summary>
        /// <param name="iaMove"></param>
        /// <param name="humanMove"></param>
        /// <param name="gameType"></param>
        /// <returns>integer 0 wins , 1 loses , 2 ties
        /// in case of error returns tie , because if furthermore we want to make a "predicting" 
        /// of something the mean is always better than a outlier value</returns>
        /// 

        public static int getPlayerWins(int iaMove, int humanMove, int gameType)
        {
            int gameMod = (int)GameModes.ClassicGameMove;
            if (gameType == 1)
                gameMod = (int)GameModes.SpockGameMove;

            var result = (gameMod + humanMove - iaMove) % gameMod;
            if (result == 0)
                return 2; // it's a tie
            if (result % 2 == 1)
                return 0; // human wins 
            if (result % 2 == 0)
                return 1; // robot wins 
            return 2; // if error we send a tie 
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="iaMove"></param>
        /// <param name="humanMove"></param>
        /// <param name="gameType"></param>
        /// <param name="gameResult"> if it's a 0 returns a win , 1 returns a loose , 2 returns a tie</param>
        /// <returns></returns>
        public static int getMove(int humanMove, int gameType, int gameResult)
        {
            var result = humanMove;

            if (gameResult == 2)
                return result;

            int gameMod = 3;
            if (gameType == 1)
                gameMod = 5;

            if (gameResult == 0)
            {
                result = humanMove - 1;
                return result < 0 ? gameMod - 1 : result;
            }

            result = humanMove + 1;
            return result == gameMod ? 0 : result;

        }
    }
}
