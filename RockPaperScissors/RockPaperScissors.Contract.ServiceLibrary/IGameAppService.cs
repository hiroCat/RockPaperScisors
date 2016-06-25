using RockPaperScissors.Contract.ServiceLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contract.ServiceLibrary
{
    public interface IGameAppService
    {
        MoveDto getMove(long id);
        MoveDto makeMove(MoveDto moveDto);
    }
}
