using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contract.ServiceLibrary.DTO
{
    public class UserDto
    {
        public List<MoveDto> playsOfUser { get; set; }
    }
}
