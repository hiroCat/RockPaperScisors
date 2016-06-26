using System.Collections.Generic;

namespace RockPaperScissors.API.Models
{
    public class User : BaseModel
    {
        public List<Move> playsOfUser { get; set; }
    }
}