using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var aux = getPlayerWins(0, 2, 0);
            var aux2 = getMove(2,0,1);
            var resultin = getPlayerWins(aux2, 2, 0);
        }

        public static int getPlayerWins(int iaMove, int humanMove, int gameType)
        {
            int gameMod = 3;
            if (gameType == 1)
                gameMod = 5;

            var result = (gameMod + humanMove - iaMove) % gameMod;
            if (result == 0)
                return 2; // it's a tie
            if (result % 2 == 1)
                return 0; // human wins 
            if (result % 2 == 0)
                return 1; // robot wins 
            return 2; // if error we send a tie 
        }

        public static int getMove(int humanMove, int gameType, int gameResult)
        {
            if (gameResult == 2)
                return humanMove;

            int gameMod = 3;
            if (gameType == 1)
                gameMod = 5;

            return humanMove - 1;




        }
    }


}
