using System.Collections.Generic;

namespace RockPaperScisors.Models
{
    public class User
    {
        public long id { get; set; }
        public List<Move> playsOfUser { get; set; }
    }
}