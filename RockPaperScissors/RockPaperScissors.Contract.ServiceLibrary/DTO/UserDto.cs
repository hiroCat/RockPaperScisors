using System.Collections.Generic;

namespace RockPaperScissors.Contract.ServiceLibrary.DTO
{
    public class UserDto : BaseDto
    {
        public List<MoveDto> playsOfUser { get; set; }
    }
}
